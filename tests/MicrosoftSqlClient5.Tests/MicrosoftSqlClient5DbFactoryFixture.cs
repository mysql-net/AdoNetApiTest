using System.Data.Common;
using AdoNet.Specification.Tests;
using Microsoft.Data.SqlClient;

namespace MicrosoftSqlClient5.Tests
{
	public class MicrosoftSqlClient5DbFactoryFixture : IDbFactoryFixture
	{
		public DbProviderFactory Factory => SqlClientFactory.Instance;
		public string ConnectionString => "data source=localhost;user id=sa;password=P@ssw0rd;TrustServerCertificate=True;initial catalog=mssqlclient5";
	}
}
