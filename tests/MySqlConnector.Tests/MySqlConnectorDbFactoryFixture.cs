using System.Data.Common;
using AdoNet.Specification.Tests;
using MySql.Data.MySqlClient;

namespace MySqlConnector.Tests
{
    public sealed class MySqlConnectorDbFactoryFixture : IDbFactoryFixture
	{
		public DbProviderFactory Factory => MySqlClientFactory.Instance;

		// docker run --name mysql -e MYSQL_ROOT_PASSWORD=test -p 3306:3306 -d mysql:5.7
		public string ConnectionString => "Server=localhost;User Id=root;Password=test;SSL Mode=none";
	}
}
