using AdoNet.Specification.Tests;

namespace Sqlite.Tests;

public sealed class SqliteCommandTests : CommandTestBase<SqliteDbFactoryFixture>
{
	public SqliteCommandTests(SqliteDbFactoryFixture fixture)
		: base(fixture)
	{
	}
}
