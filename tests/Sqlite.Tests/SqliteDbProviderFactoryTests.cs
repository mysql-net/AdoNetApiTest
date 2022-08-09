using AdoNet.Specification.Tests;

namespace Sqlite.Tests;

public sealed class SqliteDbProviderFactoryTests : DbProviderFactoryTestBase<SqliteDbFactoryFixture>
{
	public SqliteDbProviderFactoryTests(SqliteDbFactoryFixture fixture)
		: base(fixture)
	{
	}
}
