using System.Data.Common;
using AdoNet.Specification.Tests.Databases;
using Devart.Data.MySql;

namespace DotConnectMySql.Tests
{
	public sealed class DotConnectMySqlDbFactoryFixture : DbFactoryFixtureBase<MySqlDatabaseBase>
	{
		public override DbProviderFactory Factory => MySqlProviderFactory.Instance;
		public override string ConnectionString => "server=localhost;user id=root;password=test;character set=utf8mb4;database=dotconnect";
	}
}
