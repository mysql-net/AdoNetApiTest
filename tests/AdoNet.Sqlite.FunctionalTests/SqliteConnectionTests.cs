using AdoNet.Specification.Tests;

namespace AdoNet.Sqlite.FunctionalTests
{
	public sealed class SqliteConnectionTests : ConnectionTestBase<SqliteDbFactoryFixture>
	{
		public SqliteConnectionTests(SqliteDbFactoryFixture fixture)
			: base(fixture)
		{
		}
	}
}
