using AdoNet.Specification.Tests;

namespace MicrosoftSqlite9.Tests;

public sealed class MicrosoftSqlite9TransactionTests(MicrosoftSqlite9DbFactoryFixture fixture)
	: TransactionTestBase<MicrosoftSqlite9DbFactoryFixture>(fixture)
{
}
