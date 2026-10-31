using AdoNet.Specification.Tests;

namespace MicrosoftSqlite9.Tests;

public sealed class MicrosoftSqlite9CommandTests(MicrosoftSqlite9DbFactoryFixture fixture)
	: CommandTestBase<MicrosoftSqlite9DbFactoryFixture>(fixture)
{
}
