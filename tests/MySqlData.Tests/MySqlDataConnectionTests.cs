using AdoNet.Specification.Tests;

namespace MySqlData.Tests;

public sealed class MySqlDataConnectionTests : ConnectionTestBase<MySqlDataDbFactoryFixture>
{
	public MySqlDataConnectionTests(MySqlDataDbFactoryFixture fixture)
		: base(fixture)
	{
	}
}
