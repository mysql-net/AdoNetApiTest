using System.Data.Common;
using System.Data.SQLite;
using AdoNet.Specification.Tests.Databases;

namespace Sqlite.Tests
{
	public class SqliteDbFactoryFixture : DbFactoryFixtureBase<SqliteDatabaseBase>
	{
		public override DbProviderFactory Factory => SQLiteFactory.Instance;
	}
}
