using System;
using System.Collections.Generic;
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
			mySqlConnector.Initialize("server=localhost;user id=mysqltest;password='test;key=\"val';port=3306;database=mysqltest;ssl mode=none");
			connectors.Add(mySqlConnector);

			var mySqlDataConnector = new MySqlDataConnector();
			mySqlDataConnector.Initialize("server=localhost;user id=mysqltest;password='test;key=\"val';port=3306;database=mysqltest;ssl mode=none;UseAffectedRows=true");
			connectors.Add(mySqlDataConnector);

			var npgsqlConnector = new NpgsqlConnector();
			npgsqlConnector.Initialize("Host=localhost;Username=root;Password=test");
			connectors.Add(npgsqlConnector);

			var sqlConnector = new SqlConnector();
			sqlConnector.Initialize("Data Source=localhost;Integrated Security=True");
			connectors.Add(sqlConnector);

			return connectors;
		}

		private static void RunAllTests(Connector connector)
		{
			// TODO: use reflection
			var commandTests = new CommandTests();
			InitializeTest(connector, commandTests);
			Console.WriteLine(commandTests.CreateCommandDoesNotSetTransaction());
		}

		private static void InitializeTest(Connector connector, TestBase test)
		{
			test.SetConnector(connector);
		}
	}
}
