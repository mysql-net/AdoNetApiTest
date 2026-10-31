using AdoNet.Specification.Tests;

namespace MicrosoftSqlite10.Tests;

public sealed class MicrosoftSqlite10CommandTests(MicrosoftSqlite10DbFactoryFixture fixture)
	: CommandTestBase<MicrosoftSqlite10DbFactoryFixture>(fixture)
{
}
