using AdoNet.Specification.Tests;

namespace MySqlData9.Tests;

public sealed class MySqlData9DbProviderFactoryTests : DbProviderFactoryTestBase<MySqlData9DbFactoryFixture>
{
	public MySqlData9DbProviderFactoryTests(MySqlData9DbFactoryFixture fixture)
		: base(fixture)
	{
	}
}
