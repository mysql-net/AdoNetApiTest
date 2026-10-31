using AdoNet.Specification.Tests;

namespace MySqlData9.Tests;

public sealed class MySqlData9ConnectionStringBuilderTests : ConnectionStringTestBase<MySqlData9DbFactoryFixture>
{
	public MySqlData9ConnectionStringBuilderTests(MySqlData9DbFactoryFixture fixture)
		: base(fixture)
	{
	}
}
