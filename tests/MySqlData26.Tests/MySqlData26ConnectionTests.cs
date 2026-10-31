using AdoNet.Specification.Tests;

namespace MySqlData26.Tests;

public sealed class MySqlData26ConnectionTests : ConnectionTestBase<MySqlData26DbFactoryFixture>
{
	public MySqlData26ConnectionTests(MySqlData26DbFactoryFixture fixture)
		: base(fixture)
	{
	}
}
