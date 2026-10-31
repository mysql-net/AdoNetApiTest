using AdoNet.Specification.Tests;

namespace MySqlData9.Tests;

public sealed class MySqlData9CommandTests : CommandTestBase<MySqlData9DbFactoryFixture>
{
	public MySqlData9CommandTests(MySqlData9DbFactoryFixture fixture)
		: base(fixture)
	{
	}
}
