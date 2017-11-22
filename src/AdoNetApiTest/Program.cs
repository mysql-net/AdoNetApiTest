using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace AdoNetApiTest
{
	class Program
	{
		static void Main()
		{
			var assemblyPath = new Uri(Assembly.GetEntryAssembly().CodeBase).AbsolutePath;
			var testsPath = Path.GetFullPath(Path.Combine(Path.GetDirectoryName(assemblyPath), "..", "..", "..", "..", "tests"));

			var assemblyTestResults = new Dictionary<string, IReadOnlyDictionary<string, TestResult>>();
			foreach (var testFolder in Directory.GetDirectories(testsPath).Where(x => x[0] != '.'))
			{
				var assemblyName = Regex.Match(testFolder, @"AdoNet\.(.*?)\.FunctionalTests").Groups[1].Value;
				Console.Write("Processing {0}...", assemblyName);

				// RunXunit(testFolder);
				var outputXml = LoadXunitOutput(testFolder);
				var testResults = CreateTestResults(outputXml);
				assemblyTestResults.Add(assemblyName, testResults);

				Console.WriteLine("done.");
			}

			var sb = new StringBuilder(@"<!doctype html>
<html>
<head>
<title>ADO.NET Specification Tests</title>
<link rel='stylesheet' type='text/css' href='http://seriot.ch/json/style.css'>
<style type='text/css'>
.WRONG_EXCEPTION {
	border: 1px solid black;
	background-color: #f96384;
}
</style>
<meta charset='utf-8'>
</head>

<body>
<h1>ADO.NET Specification Tests</h1>
<table>
    <tr>
        <th></th>
");
			foreach (var assemblyName in assemblyTestResults.Keys)
				sb.AppendFormat("<th class='vertical'><div>{0}</div></th>", assemblyName);
			sb.AppendLine("</tr>");

			var allTestNames = assemblyTestResults.SelectMany(x => x.Value.Keys).Distinct().ToList();
			foreach (var testName in allTestNames)
			{
				sb.AppendFormat("<tr><td>{0}</td>", testName);

				foreach (var testResults in assemblyTestResults.Values)
				{
					testResults.TryGetValue(testName, out var testResult);
					var className =
						testResult == TestResult.Pass ? "EXPECTED_RESULT" :
						testResult == TestResult.Fail ? "SHOULD_HAVE_PASSED" :
						testResult == TestResult.Exception ? "CRASH" :
						testResult == TestResult.NoException ? "SHOULD_HAVE_FAILED" :
						testResult == TestResult.WrongException ? "WRONG_EXCEPTION" :
						testResult == TestResult.ImplementationPass ? "IMPLEMENTATION_PASS" :
						testResult == TestResult.ImplementationFail ? "IMPLEMENTATION_FAIL" :
						"";
					sb.AppendFormat("<td class='{0}'></td>", className);
				}

				sb.Append("</tr>");
			}

			sb.Append(@"</table>
</body>
</html>
");
			var path = Path.Combine(Path.GetTempPath(), "results.html");
			File.WriteAllText(path, sb.ToString());
			Process.Start(path);
		}

		private static void RunXunit(string testFolder)
		{
			using (var process = new Process
			{
				StartInfo =
				{
					FileName = "dotnet",
					Arguments = "xunit -xml bin\\output.xml",
					CreateNoWindow = true,
					UseShellExecute = false,
					WorkingDirectory = testFolder,
				},
				EnableRaisingEvents = true,
			})
			{
				process.Start();
				process.WaitForExit();
			}
		}

		private static XDocument LoadXunitOutput(string testFolder) => XDocument.Load(Path.Combine(testFolder, "bin\\output.xml"));

		private static IReadOnlyDictionary<string, TestResult> CreateTestResults(XDocument xml)
		{
			var testResults = new Dictionary<string, TestResult>();
			foreach (var test in xml.Root.Element("assembly").Elements("collection").Elements("test"))
			{
				var testName = (string) test.Attribute("name");
				testName = testName.Substring(testName.LastIndexOf('.') + 1);

				TestResult testResult;
				if ((string) test.Attribute("result") == "Pass")
				{
					testResult = TestResult.Pass;
				}
				else
				{
					var failure = test.Element("failure");
					var exceptionType = (string) failure.Attribute("exception-type");
					var message = (string) failure.Element("message");

					switch (exceptionType)
					{
					case "Xunit.Sdk.ThrowsException":
						// distinguish the wrong type of exception being thrown from NullReferenceException (which is always a "crash")
						var actual = Regex.Match(message, @"\\nActual:\s+(.*?)$").Groups[1].Value;
						testResult = actual == "(No exception was thrown)" ? TestResult.NoException :
							actual == "typeof(System.NullReferenceException)" ? TestResult.Exception :
							TestResult.WrongException;
						break;

					default:
						// an Xunit exception indicates a test failure; any other type of exception is a crash
						testResult = exceptionType.StartsWith("Xunit.Sdk.", StringComparison.Ordinal) ? TestResult.Fail : TestResult.Exception;
						break;
					}
				}
				testResults.Add(testName, testResult);
			}

			return testResults;
		}
	}
}
