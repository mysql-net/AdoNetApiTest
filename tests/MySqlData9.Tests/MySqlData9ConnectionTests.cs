using AdoNet.Specification.Tests;

namespace MySqlData9.Tests;

public sealed class MySqlData9ConnectionTests : ConnectionTestBase<MySqlData9DbFactoryFixture>
{
	public MySqlData9ConnectionTests(MySqlData9DbFactoryFixture fixture)
		: base(fixture)
	{
	}
}
