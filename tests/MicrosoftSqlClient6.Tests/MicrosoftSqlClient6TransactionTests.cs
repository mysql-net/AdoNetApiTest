using AdoNet.Specification.Tests;

namespace MicrosoftSqlClient6.Tests;

public sealed class MicrosoftSqlClient6TransactionTests : TransactionTestBase<MicrosoftSqlClient6DbFactoryFixture>
{
	public MicrosoftSqlClient6TransactionTests(MicrosoftSqlClient6DbFactoryFixture fixture)
		: base(fixture)
	{
	}
}
