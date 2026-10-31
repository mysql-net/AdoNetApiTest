using AdoNet.Specification.Tests;

namespace MicrosoftSqlClient7.Tests;

public sealed class MicrosoftSqlClient7TransactionTests : TransactionTestBase<MicrosoftSqlClient7DbFactoryFixture>
{
	public MicrosoftSqlClient7TransactionTests(MicrosoftSqlClient7DbFactoryFixture fixture)
		: base(fixture)
	{
	}
}
