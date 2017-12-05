using System.Data.Common;
using AdoNet.Specification.Tests.Databases;
using MySql.Data.MySqlClient;

namespace MySqlData.Tests
{
	public class MySqlDataDbFactoryFixture : DbFactoryFixtureBase<MySqlDatabaseBase>
	{
		public override DbProviderFactory Factory => MySqlClientFactory.Instance;
		public override string ConnectionString => "server=localhost;user id=root;password=test;characterset=utf8mb4;database=mysqldata";
	}
}
