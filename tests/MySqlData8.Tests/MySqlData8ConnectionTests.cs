using AdoNet.Specification.Tests;

namespace MySqlData8.Tests;

public sealed class MySqlData8ConnectionTests : ConnectionTestBase<MySqlData8DbFactoryFixture>
{
	public MySqlData8ConnectionTests(MySqlData8DbFactoryFixture fixture)
		: base(fixture)
	{
	}
}
