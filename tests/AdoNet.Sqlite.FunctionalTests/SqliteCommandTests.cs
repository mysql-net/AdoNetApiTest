using AdoNet.Specification.Tests;

namespace AdoNet.Sqlite.FunctionalTests
{
	public sealed class SqliteCommandTests : CommandTestBase<SqliteDbFactoryFixture>
	{
		public SqliteCommandTests(SqliteDbFactoryFixture fixture)
			: base(fixture)
		{
		}
	}
}
