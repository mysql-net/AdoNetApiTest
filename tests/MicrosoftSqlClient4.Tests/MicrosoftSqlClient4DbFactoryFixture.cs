using System.Data.Common;
using AdoNet.Specification.Tests;
using Microsoft.Data.SqlClient;

namespace MicrosoftSqlClient4.Tests
{
	public class MicrosoftSqlClient4DbFactoryFixture : IDbFactoryFixture
	{
		public DbProviderFactory Factory => SqlClientFactory.Instance;
		public string ConnectionString => "data source=localhost;user id=sa;password=P@ssw0rd;initial catalog=mssqlclient4;Encrypt=False";
	}
}
