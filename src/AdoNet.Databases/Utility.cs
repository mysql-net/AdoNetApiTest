using System;
using AdoNet.Specification.Tests;

namespace AdoNet.Databases;

public static class Utility
{
	public static void ExecuteNonQuery(IDbFactoryFixture factoryFixture, string sql)
	{
		using (var connection = factoryFixture.Factory.CreateConnection())
		{
			connection.ConnectionString = Environment.GetEnvironmentVariable("ConnectionString") ?? factoryFixture.ConnectionString;
			connection.Open();

			using (var command = connection.CreateCommand())
			{
				command.CommandText = sql;
				command.ExecuteNonQuery();
			}
		}
	}
}
