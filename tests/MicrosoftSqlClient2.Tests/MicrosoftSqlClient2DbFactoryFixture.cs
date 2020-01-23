using System.Data.Common;
using AdoNet.Specification.Tests;
using Microsoft.Data.SqlClient;

namespace MicrosoftSqlClient2.Tests
{
	public class MicrosoftSqlClient2DbFactoryFixture : IDbFactoryFixture
	{
		public DbProviderFactory Factory => SqlClientFactory.Instance;
		public string ConnectionString => "data source=localhost;user id=sa;password=P@ssw0rd;initial catalog=mssqlclient2";
	}
}
