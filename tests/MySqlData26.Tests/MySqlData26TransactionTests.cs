using AdoNet.Specification.Tests;

namespace MySqlData26.Tests;

public sealed class MySqlData26TransactionTests : TransactionTestBase<MySqlData26DbFactoryFixture>
{
	public MySqlData26TransactionTests(MySqlData26DbFactoryFixture fixture)
		: base(fixture)
	{
	}
}
