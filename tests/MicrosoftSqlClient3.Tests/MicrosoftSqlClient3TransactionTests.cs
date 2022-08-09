using AdoNet.Specification.Tests;

namespace MicrosoftSqlClient3.Tests;

public sealed class MicrosoftSqlClient3TransactionTests : TransactionTestBase<MicrosoftSqlClient3DbFactoryFixture>
{
	public MicrosoftSqlClient3TransactionTests(MicrosoftSqlClient3DbFactoryFixture fixture)
		: base(fixture)
	{
	}
}
