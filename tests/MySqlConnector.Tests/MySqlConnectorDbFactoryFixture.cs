using System.Data.Common;
using AdoNet.Specification.Tests;
using MySqlConnector;

namespace MySqlConnector.Tests;

public class MySqlConnectorDbFactoryFixture : IDbFactoryFixture
{
	public DbProviderFactory Factory => MySqlConnectorFactory.Instance;
	public string ConnectionString => "Server=localhost;User Id=root;Password=test;SSL Mode=none;Database=mysqlconnector";
}
