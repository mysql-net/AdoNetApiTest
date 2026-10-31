using AdoNet.Specification.Tests;

namespace MicrosoftSqlite9.Tests;

public sealed class MicrosoftSqlite9ConnectionTests(MicrosoftSqlite9DbFactoryFixture fixture)
	: ConnectionTestBase<MicrosoftSqlite9DbFactoryFixture>(fixture)
{
}
