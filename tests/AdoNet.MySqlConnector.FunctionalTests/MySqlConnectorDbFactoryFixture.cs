using System.Data.Common;
using AdoNet.Specification.Tests;
using MySql.Data.MySqlClient;

namespace AdoNet.MySqlConnector.FunctionalTests
{
    public sealed class MySqlConnectorDbFactoryFixture : IDbFactoryFixture
	{
		public DbProviderFactory Factory => MySqlClientFactory.Instance;

		// docker run --name mysql -e MYSQL_ROOT_PASSWORD=test -p 3306:3306 -d mysql:5.7
		public string ConnectionString => "server=localhost;user id=root;password=test;ssl mode=none";
	}
}
