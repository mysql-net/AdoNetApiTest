using AdoNet.Specification.Tests;

namespace MySqlData.Tests;

public sealed class MySqlDataTransactionTests : TransactionTestBase<MySqlDataDbFactoryFixture>
{
	public MySqlDataTransactionTests(MySqlDataDbFactoryFixture fixture)
		: base(fixture)
	{
	}
}
