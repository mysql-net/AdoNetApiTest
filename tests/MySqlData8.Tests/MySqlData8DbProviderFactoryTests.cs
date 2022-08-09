using AdoNet.Specification.Tests;

namespace MySqlData8.Tests;

public sealed class MySqlData8DbProviderFactoryTests : DbProviderFactoryTestBase<MySqlData8DbFactoryFixture>
{
	public MySqlData8DbProviderFactoryTests(MySqlData8DbFactoryFixture fixture)
		: base(fixture)
	{
	}
}
