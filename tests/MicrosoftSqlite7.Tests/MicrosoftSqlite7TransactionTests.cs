using AdoNet.Specification.Tests;

namespace MicrosoftSqlite7.Tests;

public sealed class MicrosoftSqlite7TransactionTests : TransactionTestBase<MicrosoftSqlite7DbFactoryFixture>
{
	public MicrosoftSqlite7TransactionTests(MicrosoftSqlite7DbFactoryFixture fixture)
		: base(fixture)
	{
	}
}
