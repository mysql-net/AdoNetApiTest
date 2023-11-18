using AdoNet.Specification.Tests;

namespace MicrosoftSqlite8.Tests;

public sealed class MicrosoftSqlite8CommandTests(MicrosoftSqlite8DbFactoryFixture fixture)
	: CommandTestBase<MicrosoftSqlite8DbFactoryFixture>(fixture)
{
}
