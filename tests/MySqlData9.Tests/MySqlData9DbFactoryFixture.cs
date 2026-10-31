using System.Data.Common;
using AdoNet.Specification.Tests;
using MySql.Data.MySqlClient;

namespace MySqlData9.Tests;

public class MySqlData9DbFactoryFixture : IDbFactoryFixture
{
	public DbProviderFactory Factory => MySqlClientFactory.Instance;
	public string ConnectionString => "server=localhost;user id=root;password=test;characterset=utf8mb4;database=mysqldata9";
}
