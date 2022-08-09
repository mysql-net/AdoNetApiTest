using AdoNet.Specification.Tests;

namespace MySqlData.Tests;

public sealed class MySqlDataDbProviderFactoryTests : DbProviderFactoryTestBase<MySqlDataDbFactoryFixture>
{
	public MySqlDataDbProviderFactoryTests(MySqlDataDbFactoryFixture fixture)
		: base(fixture)
	{
	}
}
