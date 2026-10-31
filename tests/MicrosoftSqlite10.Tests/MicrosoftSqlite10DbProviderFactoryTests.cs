using AdoNet.Specification.Tests;

namespace MicrosoftSqlite10.Tests;

public sealed class MicrosoftSqlite10DbProviderFactoryTests(MicrosoftSqlite10DbFactoryFixture fixture)
	: DbProviderFactoryTestBase<MicrosoftSqlite10DbFactoryFixture>(fixture)
{
}
