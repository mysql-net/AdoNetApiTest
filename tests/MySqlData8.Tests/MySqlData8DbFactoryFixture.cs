using System.Data.Common;
using AdoNet.Specification.Tests;
using MySql.Data.MySqlClient;

namespace MySqlData.Tests
{
	public sealed class MySqlDataDbFactoryFixture : IDbFactoryFixture
	{
		public DbProviderFactory Factory => MySqlClientFactory.Instance;
		public string ConnectionString => "server=localhost;user id=root;password=test;characterset=utf8mb4";
	}
}
