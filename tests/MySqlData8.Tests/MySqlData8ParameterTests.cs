using AdoNet.Specification.Tests;

namespace MySqlData8.Tests;

public sealed class MySqlData8ParameterTests : ParameterTestBase<MySqlData8DbFactoryFixture>
{
	public MySqlData8ParameterTests(MySqlData8DbFactoryFixture fixture)
		: base(fixture)
	{
	}
}
