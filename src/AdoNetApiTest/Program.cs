using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using AdoNetApiTest.Connectors;
using AdoNetApiTest.Tests;
using MySqlConnector = AdoNetApiTest.Connectors.MySqlConnector;

namespace AdoNetApiTest
{
	class Program
	{
		static List<string> s_rows;

		static void Main(string[] args)
		{
			var connectors = CreateConnectors();

			var sb = new StringBuilder(@"<!DOCTYPE html>
<HTML>
<HEAD>
<TITLE>ADO.NET API Tests</TITLE>
<LINK rel='stylesheet' type='text/css' href='http://seriot.ch/json/style.css'>
<STYLE type='text/css'>
.WRONG_EXCEPTION {
	border: 1px solid black;
	background-color: #F96384;
}
</STYLE>
<META charset='utf-8'>
</HEAD>

<BODY>
<H1>ADO.NET API Tests</H1>
<TABLE>
    <TR>
        <TH></TH>
");
			foreach (var connector in connectors)
				sb.AppendFormat("<TH class='vertical'><DIV>{0}</DIV></TH>", connector.Name);
			sb.AppendLine("</TR>");

			s_rows = new List<string>();

			foreach (var connector in connectors)
				RunAllTests(connector);

			foreach (var connector in connectors)
				connector.Uninitialize();

			foreach (var row in s_rows)
				sb.AppendLine($"<TR>{row}</TR>");
			sb.Append(@"</TABLE>
</BODY>
</HTML>
");
			var path = Path.Combine(Path.GetTempPath(), "results.html");
			File.WriteAllText(path, sb.ToString());
			Process.Start(path);
		}

		private static IReadOnlyList<Connector> CreateConnectors()
		{
			var connectors = new List<Connector>();

			// TODO: make data-driven
			var mySqlConnector = new MySqlConnector();
			mySqlConnector.Initialize("server=localhost;user id=root;password=test;ssl mode=none");
			connectors.Add(mySqlConnector);

			var mySqlDataConnector = new MySqlDataConnector();
			mySqlDataConnector.Initialize("server=localhost;user id=root;password=test;ssl mode=none;UseAffectedRows=true");
			connectors.Add(mySqlDataConnector);

			var npgsqlConnector = new NpgsqlConnector();
			npgsqlConnector.Initialize("host=localhost;user id=root;password=test");
			connectors.Add(npgsqlConnector);

			var sqlConnector = new SqlConnector();
			sqlConnector.Initialize("data source=localhost;user id=sa;password=Pa$$word");
			connectors.Add(sqlConnector);

			var microsoftSqliteConnector = new MicrosoftSqliteConnector();
			microsoftSqliteConnector.Initialize("data source=:memory:");
			connectors.Add(microsoftSqliteConnector);

			var sqliteConnector = new SqliteConnector();
			sqliteConnector.Initialize("data source=:memory:");
			connectors.Add(sqliteConnector);

			return connectors;
		}

		private static void RunAllTests(Connector connector)
		{
			int index = 0;

			Console.WriteLine(connector.Name);
			Console.WriteLine(new string('=', connector.Name.Length));
			var testTypes = Assembly.GetExecutingAssembly().GetTypes().Where(x => x.IsSubclassOf(typeof(TestBase))).ToList();
			foreach (var testType in testTypes)
			{
				Console.WriteLine(testType.Name);
				var constructor = testType.GetConstructor(new Type[0]);
				var test = (TestBase) constructor.Invoke(new object[0]);
				InitializeTest(connector, test);

				foreach (var method in testType.GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.DeclaredOnly).Where(x => x.GetParameters().Length == 0))
				{
					Console.Write("{0}: ", method.Name);
					if (index >= s_rows.Count)
						s_rows.Add($"<TD>{method.Name}</TD>");

					TestResult testResult;
					try
					{
						var result = method.Invoke(test, new object[0]);
						if (method.ReturnType == typeof(bool))
							testResult = (bool) result ? TestResult.Pass : TestResult.Fail;
						else if (method.ReturnType == typeof(TestResult))
							testResult = (TestResult) result;
						else
							testResult = TestResult.Exception;
						Console.WriteLine(result);
					}
					catch (TargetInvocationException ex)
					{
						testResult = TestResult.Exception;
						Console.WriteLine("EXCEPTION {0} {1}", ex.InnerException.GetType().Name, ex.InnerException.Message);
					}
					catch (Exception ex)
					{
						testResult = TestResult.Exception;
						Console.WriteLine("UNEXPECTED EXCEPTION {0} {1}", ex.GetType().Name, ex.Message);
					}

					var isImplementationSpecific = method.GetCustomAttribute<ImplementationSpecificAttribute>() != null;
					if (isImplementationSpecific)
						testResult = testResult == TestResult.Pass ? TestResult.ImplementationPass : testResult == TestResult.Fail ? TestResult.ImplementationFail : testResult;

					var className =
						testResult == TestResult.Pass ? "EXPECTED_RESULT" :
						testResult == TestResult.Fail ? "SHOULD_HAVE_PASSED" :
						testResult == TestResult.Exception ? "CRASH" :
						testResult == TestResult.NoException ? "SHOULD_HAVE_FAILED" :
						testResult == TestResult.WrongException ? "WRONG_EXCEPTION" :
						testResult == TestResult.ImplementationPass ? "IMPLEMENTATION_PASS" :
						testResult == TestResult.ImplementationFail ? "IMPLEMENTATION_FAIL" :
						"";
					s_rows[index] += $"<TD class='{className}'></TD>";

					index++;
				}
			}
			Console.WriteLine();
		}

		private static void InitializeTest(Connector connector, TestBase test)
		{
			test.SetConnector(connector);
		}
	}
}
