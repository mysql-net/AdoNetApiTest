using AdoNet.Specification.Tests;

namespace MicrosoftSqlite10.Tests;

public sealed class MicrosoftSqlite10ConnectionTests(MicrosoftSqlite10DbFactoryFixture fixture)
	: ConnectionTestBase<MicrosoftSqlite10DbFactoryFixture>(fixture)
{
}
