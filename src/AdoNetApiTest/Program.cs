using System.Diagnostics;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace AdoNetApiTest;

class Program
{
	static bool RunXUnit = true;

	static async Task Main(string[] args)
	{
		IReadOnlyCollection<string> testResultPaths;
		string outputPath;
		if (args.Length == 0)
		{
			var assemblyPath = new Uri(Assembly.GetEntryAssembly().Location).AbsolutePath;
			var testsPath = Path.GetFullPath(Path.Combine(Path.GetDirectoryName(assemblyPath), "..", "..", "..", "..", "..", "tests"));

			Console.Write("Running tests");

			testResultPaths = (await Task.WhenAll(Directory.GetDirectories(testsPath)
					.Where(x => x[0] != '.')
					.Select(RunTestsAsync)))
				.ToList();

			Console.WriteLine("done.");

			outputPath = Path.GetTempPath();
		}
		else
		{
			testResultPaths = Directory.GetFiles(args[0], "*.trx", SearchOption.AllDirectories);
			outputPath = args[1];
		}

		var assemblyTestResults = testResultPaths
			.Select(ProcessTests)
			.OrderBy(x => x.Category)
			.ThenBy(x => x.Name)
			.ToList();
		var sb = new StringBuilder($@"<!doctype html>
<html>
<head>
<title>ADO.NET Specification Tests</title>
<link rel='stylesheet' type='text/css' href='https://mysql-net.github.io/AdoNetResults/style.css'>
<meta charset='utf-8'>
</head>
<body>
<h1>ADO.NET Specification Tests</h1>
<p>Generated by <a href='https://github.com/mysql-net/AdoNetApiTest'>AdoNetApiTest</a> on {DateTime.UtcNow:u}. See <a href='https://mysql-net.github.io/AdoNetResults/'>latest results</a>.</p>
<div style='position: fixed; top: 0; right: 16px'>
<h4>Legend</h4>
<table>
    <tr><td class='EXPECTED_RESULT'>expected result</td></tr>
    <tr><td class='WRONG_EXCEPTION'>exception was not of expected type</td></tr>
    <tr><td class='SHOULD_HAVE_PASSED'>should have succeeded but failed</td></tr>
    <tr><td class='SHOULD_HAVE_FAILED'>should have failed but succeeded</td></tr>
    <tr><td class='IMPLEMENTATION_PASS'>result undefined; test succeeded; OR<br>GetBoolean returns <tt>true</tt></td></tr>
    <tr><td class='IMPLEMENTATION_FAIL'>result undefined; test failed; OR<br>GetBoolean returns <tt>false</tt>; OR<br>Test skipped</td></tr>
    <tr><td class='NOT_APPLICABLE'>test not applicable to this provider</td></tr>
    <tr><td class='CRASH'>provider threw unhandled exception</td></tr>
</table>
</div>
<h4>Results</h4>
<table>
    <tr>
        <th></th>
");
		string lastCategory = null;
		foreach (var testResult in assemblyTestResults)
		{
			if (lastCategory != null && testResult.Category != lastCategory)
				sb.Append("<th style='width: 4px'></th>");
			lastCategory = testResult.Category;
			sb.AppendFormat("<th class='vertical'><div>{0}</div></th>", EscapeHtml(testResult.Name));
		}
		sb.AppendLine("</tr><tr><th></th>");

		var isFirst = true;
		foreach (var category in assemblyTestResults.GroupBy(x => x.Category))
		{
			if (!isFirst)
				sb.Append("<th></th>");
			else
				isFirst = false;
			sb.AppendFormat("<th colspan={0} style='border: 1px solid black;'>{1}</th>", category.Count(), EscapeHtml(category.Key));
		}
		sb.AppendLine("</tr>");

		var allTestNames = assemblyTestResults.SelectMany(x => x.Results).Select(x => x.Key).Distinct().OrderBy(x => x).ToList();
		foreach (var testName in allTestNames)
		{
			sb.AppendFormat("<tr><td id='{0}'><a href='#{0}'>{0}</a></td>", EscapeHtml(testName));

			lastCategory = null;
			foreach (var result in assemblyTestResults)
			{
				if (lastCategory != null && result.Category != lastCategory)
					sb.AppendFormat("<td></td>");
				lastCategory = result.Category;

				result.Results.TryGetValue(testName, out var testResult);
				var status = testResult.Status;
				var className =
					status == TestStatus.Pass ? "EXPECTED_RESULT" :
					status == TestStatus.Fail ? "SHOULD_HAVE_PASSED" :
					status == TestStatus.Exception ? "CRASH" :
					status == TestStatus.NoException ? "SHOULD_HAVE_FAILED" :
					status == TestStatus.WrongException ? "WRONG_EXCEPTION" :
					status == TestStatus.ImplementationPass ? "IMPLEMENTATION_PASS" :
					status == TestStatus.ImplementationFail ? "IMPLEMENTATION_FAIL" :
					status == TestStatus.NotApplicable ? "NOT_APPLICABLE" :
					"";
				sb.AppendFormat("<td class='{0}'{1}></td>", className, testResult.Message == null ? "" : $" title=\"{EscapeHtml(testResult.Message)}\"'");
			}

			sb.AppendLine("</tr>");
		}

		sb.Append(@"</table>
</body>
</html>
");
		var path = Path.Combine(outputPath, "results.html");
		File.WriteAllText(path, sb.ToString());
		Process.Start(new ProcessStartInfo
		{
			FileName = path,
			UseShellExecute = true,
		});
	}

	private static async Task<string> RunTestsAsync(string testFolder)
	{
		var outputXmlPath = Path.Combine(testFolder, "bin", "output.trx");
		var outputDirectory = new DirectoryInfo(Path.GetDirectoryName(outputXmlPath));
		if (RunXUnit)
		{
			foreach (var file in outputDirectory.GetFiles("output*.trx"))
				file.Delete();

			while (true)
			{
				await RunXunitAsync(testFolder, outputXmlPath).ConfigureAwait(false);
				Console.Write(".");
				var actualOutputPath = outputDirectory.GetFiles("output*.trx").Select(x => x.FullName).FirstOrDefault();
				if (actualOutputPath is null)
					Console.Error.WriteLine("\nCouldn't find TRX in {0}", outputDirectory.FullName);
				else
					return actualOutputPath;
			}
		}
		return null;
	}

	private static (string Category, string Name, IReadOnlyDictionary<string, TestResult> Results) ProcessTests(string outputXmlPath)
	{
		var outputXml = XDocument.Load(outputXmlPath);
		var testResults = CreateTestResults(outputXml);

		// this needs to handle "C:\...\AdoNetApiTest\tests\MySqlConnector.Tests\bin\output_YYYY-MM-DD_HH-mm-ss-fff.trx" (local)
		// and "$(Build.ArtifactStagingDirectory)/MySqlConnector.Tests.trx" (Azure Pipelines)
		var folderName = Regex.Match(Path.GetFileName(Regex.Replace(outputXmlPath, @"\\bin\\output.*?\.trx$", "")), @"^(.*?)\.Tests").Groups[1].Value;

		// SqlClient doesn't support SqlDataReader.GetChar; override all its test failures for this method
		if (folderName.IndexOf("SqlClient", StringComparison.Ordinal) != -1)
		{
			var getCharTests = testResults
				.Where(x => x.Key.StartsWith("GetChar_", StringComparison.Ordinal) && x.Value.Status == TestStatus.Exception && x.Value.Message.IndexOf("NotSupportedException", StringComparison.Ordinal) != -1)
				.Select(x => x.Key)
				.ToHashSet();
			testResults = testResults.Select(x => getCharTests.Contains(x.Key) ? new KeyValuePair<string, TestResult>(x.Key, new TestResult(TestStatus.NotApplicable, x.Value.Message)) : x)
				.ToDictionary(x => x.Key, x => x.Value);
		}

		var name = folderName;
		string category;
		if (name.IndexOf("mysql", StringComparison.OrdinalIgnoreCase) != -1)
			category = "MySQL";
		else if (name.IndexOf("npgsql", StringComparison.OrdinalIgnoreCase) != -1 || name.IndexOf("postgres", StringComparison.OrdinalIgnoreCase) != -1)
			category = "PG";
		else if (name.IndexOf("sqlite", StringComparison.OrdinalIgnoreCase) != -1)
			category = "SQLite";
		else if (name.IndexOf("sqlclient", StringComparison.OrdinalIgnoreCase) != -1)
			category = "MSSQL";
		else
			category = "Unknown";

		return ((category, name, testResults));
	}

	private static Task RunXunitAsync(string testFolder, string outputXmlPath)
	{
		var taskCompletionSource = new TaskCompletionSource<object>();
		var process = new Process
		{
			StartInfo =
				{
					FileName = "dotnet",
					Arguments = $"test -c Release --logger \"trx;LogFileName={outputXmlPath}\"",
					CreateNoWindow = true,
					UseShellExecute = false,
					WorkingDirectory = testFolder,
				},
			EnableRaisingEvents = true,
		};
		process.Exited += (sender, args) =>
		{
			((Process) sender).Dispose();
			taskCompletionSource.SetResult(null);
		};
		process.Start();
		return taskCompletionSource.Task;
	}

	private static IReadOnlyDictionary<string, TestResult> CreateTestResults(XDocument xml)
	{
		var testResults = new Dictionary<string, TestResult>();
		var teamTest = XNamespace.Get("http://microsoft.com/schemas/VisualStudio/TeamTest/2010");
		foreach (var test in xml.Root.Element(teamTest + "Results").Elements(teamTest + "UnitTestResult"))
		{
			var testName = (string) test.Attribute("testName");
			testName = testName.Substring(GetNthIndexOf(testName, '.', 3) + 1);

			TestStatus testStatus;
			string testMessage = null;
			if ((string) test.Attribute("outcome") == "Passed")
			{
				testStatus = TestStatus.Pass;
			}
			else if ((string) test.Attribute("outcome") == "NotExecuted")
			{
				testMessage = (string) test.Element(teamTest + "Output")?.Element(teamTest + "StdOut");
				testStatus = testMessage == "Database doesn't support this data type" || testMessage == "Not supported on this TargetFramework" ? TestStatus.NotApplicable : TestStatus.ImplementationFail;
			}
			else
			{
				var failure = test.Element(teamTest + "Output").Element(teamTest + "ErrorInfo");
				var message = ((string) failure.Element(teamTest + "Message")).Replace("\\r\\n", "\n");

				if (message.StartsWith("$XunitDynamicSkip$", StringComparison.Ordinal))
				{
					testMessage = message.Replace("$XunitDynamicSkip$", "");
					testStatus = TestStatus.NotApplicable;
				}
				else if (message.StartsWith("AdoNet.Specification.Tests.UnexpectedValueException :", StringComparison.Ordinal))
				{
					testStatus = TestStatus.Fail;
					testMessage = message.Replace("AdoNet.Specification.Tests.UnexpectedValueException : ", "");

					if (testName.StartsWith("GetBoolean_throws_", StringComparison.Ordinal))
					{
						if (testMessage == "Unexpected value: True (System.Boolean)")
							testStatus = TestStatus.ImplementationPass;
						else if (testMessage == "Unexpected value: False (System.Boolean)")
							testStatus = TestStatus.ImplementationFail;
					}
				}
				else if (message.StartsWith("Assert.Throws() Failure", StringComparison.Ordinal))
				{
					// distinguish the wrong type of exception being thrown from NullReferenceException (which is always a "crash")
					var actual = Regex.Match(message, @"\bActual:\s+(.*?)$", RegexOptions.Singleline).Groups[1].Value;
					testStatus = actual == "(No exception was thrown)" ? TestStatus.NoException :
						actual.StartsWith("typeof(System.NullReferenceException)", StringComparison.Ordinal) ? TestStatus.Exception :
						actual.StartsWith("typeof(System.NotSupportedException)", StringComparison.Ordinal) ? TestStatus.Exception :
						actual.StartsWith("typeof(System.NotImplementedException)", StringComparison.Ordinal) ? TestStatus.Exception :
						TestStatus.WrongException;
					if (testStatus != TestStatus.NoException)
						testMessage = Regex.Replace(actual, @"^typeof\((.*?)\)(.*)$", "$1$2");
				}
				else if (message.StartsWith("Assert.Equal() Failure", StringComparison.Ordinal) ||
						 message.StartsWith("Assert.False() Failure", StringComparison.Ordinal) ||
						message.StartsWith("Assert.Null() Failure", StringComparison.Ordinal) ||
						message.StartsWith("Assert.True() Failure", StringComparison.Ordinal))
				{
					testStatus = TestStatus.Fail;
					testMessage = message;
				}
				else
				{
					testStatus = TestStatus.Exception;
					testMessage = message;
				}
			}
			testResults.Add(testName, new(testStatus, testMessage));
		}

		return testResults;
	}

	private static int GetNthIndexOf(string value, char ch, int count)
	{
		int startIndex = -1;
		for (int i = 0; i < count; i++)
		{
			startIndex = value.IndexOf(ch, startIndex + 1);
			if (startIndex == -1)
				break;
		}
		return startIndex;
	}

	private static string GetConnectorName(string testFolder)
	{
		var csproj = Directory.GetFiles(testFolder, "*.csproj").First();
		var project = XDocument.Load(csproj);
		foreach (var package in project.Root.Elements("ItemGroup").Elements("PackageReference"))
		{
			var include = (string) package.Attribute("Include");
			if (include.IndexOf("sql", StringComparison.OrdinalIgnoreCase) != -1 || include.IndexOf("connect", StringComparison.OrdinalIgnoreCase) != -1)
				return include.Replace(".Express.for", "") + " " + (string) package.Attribute("Version");
		}
		return null;
	}

	private static string EscapeHtml(string value) => value?.Replace("&", "&amp;").Replace("\"", "&quot").Replace("<", "&lt;");
}
