using AdoNet.Specification.Tests;

namespace MySqlData26.Tests;

public sealed class MySqlData26DbProviderFactoryTests : DbProviderFactoryTestBase<MySqlData26DbFactoryFixture>
{
	public MySqlData26DbProviderFactoryTests(MySqlData26DbFactoryFixture fixture)
		: base(fixture)
	{
	}
}
