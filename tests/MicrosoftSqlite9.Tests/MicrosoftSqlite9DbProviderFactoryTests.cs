using AdoNet.Specification.Tests;

namespace MicrosoftSqlite9.Tests;

public sealed class MicrosoftSqlite9DbProviderFactoryTests(MicrosoftSqlite9DbFactoryFixture fixture)
	: DbProviderFactoryTestBase<MicrosoftSqlite9DbFactoryFixture>(fixture)
{
}
