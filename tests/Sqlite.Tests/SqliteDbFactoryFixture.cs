using System.Data.Common;
using System.Data.SQLite;
using AdoNet.Specification.Tests;

namespace Sqlite.Tests
{
	public class SqliteDbFactoryFixture : IDbFactoryFixture
	{
		public DbProviderFactory Factory => SQLiteFactory.Instance;
		public string ConnectionString => "data source=:memory:";
	}
}
