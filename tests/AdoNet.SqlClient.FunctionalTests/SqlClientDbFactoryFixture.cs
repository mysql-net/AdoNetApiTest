using System.Data.Common;
using System.Data.SqlClient;
using AdoNet.Specification.Tests;

namespace AdoNet.SqlClient.FunctionalTests
{
    public class SqlClientDbFactoryFixture : IDbFactoryFixture
	{
		public DbProviderFactory Factory => SqlClientFactory.Instance;

		// docker run --name mssql -e ACCEPT_EULA=Y -e MSSQL_SA_PASSWORD=Pa$$word -p 1433:1433 -d microsoft/mssql-server-linux:2017-latest
		public string ConnectionString => "data source=localhost;user id=sa;password=Pa$$word";
	}
}
