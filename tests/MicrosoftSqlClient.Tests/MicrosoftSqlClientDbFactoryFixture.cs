using System.Data.Common;
using AdoNet.Specification.Tests;
using Microsoft.Data.SqlClient;

namespace MicrosoftSqlClient.Tests
{
	public class MicrosoftSqlClientDbFactoryFixture : IDbFactoryFixture
	{
		public DbProviderFactory Factory => SqlClientFactory.Instance;
		public string ConnectionString => "data source=localhost;user id=sa;password=P@ssw0rd;initial catalog=mssqlclient";
	}
}
