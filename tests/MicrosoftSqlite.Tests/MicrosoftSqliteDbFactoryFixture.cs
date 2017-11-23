using System.Data.Common;
using Microsoft.Data.Sqlite;
using AdoNet.Specification.Tests;

namespace MicrosoftSqlite.Tests
{
    public class MicrosoftSqliteDbFactoryFixture : IDbFactoryFixture
	{
		public DbProviderFactory Factory => SqliteFactory.Instance;
		public string ConnectionString => "data source=:memory:";
	}
}
