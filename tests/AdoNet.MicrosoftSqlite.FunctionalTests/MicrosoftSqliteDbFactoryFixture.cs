using System.Data.Common;
using Microsoft.Data.Sqlite;
using AdoNet.Specification.Tests;

namespace AdoNet.MicrosoftSqlite.FunctionalTests
{
    public class MicrosoftSqliteDbFactoryFixture : IDbFactoryFixture
	{
		public DbProviderFactory Factory => SqliteFactory.Instance;
		public string ConnectionString => "data source=:memory:";
	}
}
