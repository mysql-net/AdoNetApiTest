using AdoNet.Specification.Tests;

namespace MicrosoftSqlite8.Tests;

public sealed class MicrosoftSqlite8DbProviderFactoryTests(MicrosoftSqlite8DbFactoryFixture fixture)
	: DbProviderFactoryTestBase<MicrosoftSqlite8DbFactoryFixture>(fixture)
{
}
