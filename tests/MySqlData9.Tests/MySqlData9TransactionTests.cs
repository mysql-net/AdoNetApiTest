using AdoNet.Specification.Tests;

namespace MySqlData9.Tests;

public sealed class MySqlData9TransactionTests : TransactionTestBase<MySqlData9DbFactoryFixture>
{
	public MySqlData9TransactionTests(MySqlData9DbFactoryFixture fixture)
		: base(fixture)
	{
	}
}
