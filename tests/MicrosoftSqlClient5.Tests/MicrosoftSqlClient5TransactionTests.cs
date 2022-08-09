using AdoNet.Specification.Tests;

namespace MicrosoftSqlClient5.Tests;

public sealed class MicrosoftSqlClient5TransactionTests : TransactionTestBase<MicrosoftSqlClient5DbFactoryFixture>
{
	public MicrosoftSqlClient5TransactionTests(MicrosoftSqlClient5DbFactoryFixture fixture)
		: base(fixture)
	{
	}
}
