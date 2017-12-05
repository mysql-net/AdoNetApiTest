using System.Data.Common;
using AdoNet.Specification.Tests.Databases;
using MySql.Data.MySqlClient;

namespace MySqlConnector.Tests
{
	public class MySqlConnectorDbFactoryFixture : DbFactoryFixtureBase<MySqlDatabaseBase>
	{
		public override DbProviderFactory Factory => MySqlClientFactory.Instance;
		public override string ConnectionString => "Server=localhost;User Id=root;Password=test;SSL Mode=none;Database=mysqlconnector";
	}
}
