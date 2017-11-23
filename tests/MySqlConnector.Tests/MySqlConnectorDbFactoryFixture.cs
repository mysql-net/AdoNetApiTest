using System.Data.Common;
using AdoNet.Specification.Tests.Databases;
using MySql.Data.MySqlClient;

namespace MySqlConnector.Tests
{
    public sealed class MySqlConnectorDbFactoryFixture : DbFactoryFixtureBase<MySqlDatabaseBase>
	{
		public override DbProviderFactory Factory => MySqlClientFactory.Instance;
		public override string ConnectionString => base.ConnectionString + "SSL Mode=none";
	}
}
