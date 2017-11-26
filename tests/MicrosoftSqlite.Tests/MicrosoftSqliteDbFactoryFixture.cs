using System.Data.Common;
using Microsoft.Data.Sqlite;
using AdoNet.Specification.Tests.Databases;

namespace MicrosoftSqlite.Tests
{
	public class MicrosoftSqliteDbFactoryFixture : DbFactoryFixtureBase<SqliteDatabaseBase>
	{
		public override DbProviderFactory Factory => SqliteFactory.Instance;
		public override string ConnectionString => "data source=:memory:";
	}
}
