using AdoNet.Specification.Tests;

namespace MySqlData9.Tests;

public sealed class MySqlData9ParameterTests : ParameterTestBase<MySqlData9DbFactoryFixture>
{
	public MySqlData9ParameterTests(MySqlData9DbFactoryFixture fixture)
		: base(fixture)
	{
	}
}
