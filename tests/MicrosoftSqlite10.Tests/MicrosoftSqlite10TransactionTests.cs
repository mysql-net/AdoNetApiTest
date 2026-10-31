using AdoNet.Specification.Tests;

namespace MicrosoftSqlite10.Tests;

public sealed class MicrosoftSqlite10TransactionTests(MicrosoftSqlite10DbFactoryFixture fixture)
	: TransactionTestBase<MicrosoftSqlite10DbFactoryFixture>(fixture)
{
}
