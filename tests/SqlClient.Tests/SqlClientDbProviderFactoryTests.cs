using AdoNet.Specification.Tests;

namespace SqlClient.Tests;

public sealed class SqlClientDbProviderFactoryTests : DbProviderFactoryTestBase<SqlClientDbFactoryFixture>
{
	public SqlClientDbProviderFactoryTests(SqlClientDbFactoryFixture fixture)
		: base(fixture)
	{
	}
}
