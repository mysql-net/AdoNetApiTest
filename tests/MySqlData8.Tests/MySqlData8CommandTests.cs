using AdoNet.Specification.Tests;

namespace MySqlData8.Tests;

public sealed class MySqlData8CommandTests : CommandTestBase<MySqlData8DbFactoryFixture>
{
	public MySqlData8CommandTests(MySqlData8DbFactoryFixture fixture)
		: base(fixture)
	{
	}
}
