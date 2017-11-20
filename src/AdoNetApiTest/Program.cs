using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using AdoNetApiTest.Connectors;
using AdoNetApiTest.Tests;
using MySqlConnector = AdoNetApiTest.Connectors.MySqlConnector;

namespace AdoNetApiTest
{
	class Program
	{
		static void Main(string[] args)
		{
			var connectors = CreateConnectors();
			foreach (var connector in connectors)
				RunAllTests(connector);

			foreach (var connector in connectors)
				connector.Uninitialize();
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
			npgsqlConnector.Initialize("Host=localhost;Username=root;Password=test");
			connectors.Add(npgsqlConnector);

			var sqlConnector = new SqlConnector();
			sqlConnector.Initialize("Data Source=localhost;User Id=sa;Password=Pa$$word");
			connectors.Add(sqlConnector);

			return connectors;
		}

		private static void RunAllTests(Connector connector)
		{
			Console.WriteLine(connector.Name);
			Console.WriteLine(new string('=', connector.Name.Length));
			var testTypes = Assembly.GetExecutingAssembly().GetTypes().Where(x => x.IsSubclassOf(typeof(TestBase))).ToList();
			foreach (var testType in testTypes)
			{
				Console.WriteLine(testType.Name);
				var constructor = testType.GetConstructor(new Type[0]);
				var test = (TestBase) constructor.Invoke(new object[0]);
				InitializeTest(connector, test);

				foreach (var method in testType.GetMethods(BindingFlags.Instance | BindingFlags.Public).Where(x => x.ReturnType == typeof(bool) && x.GetParameters().Length == 0))
				{
					Console.Write("{0}: ", method.Name);
					try
					{
						var result = (bool) method.Invoke(test, new object[0]);
						Console.WriteLine(result);
					}
					catch (Exception ex)
					{
						Console.WriteLine("EXCEPTION {0} {1}", ex.InnerException.GetType().Name, ex.InnerException.Message);
					}
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
