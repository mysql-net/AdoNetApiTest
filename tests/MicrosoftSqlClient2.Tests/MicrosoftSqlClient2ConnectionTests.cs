using AdoNet.Specification.Tests;

namespace MicrosoftSqlClient2.Tests;

public sealed class MicrosoftSqlClient2ConnectionTests : ConnectionTestBase<MicrosoftSqlClient2DbFactoryFixture>
{
	public MicrosoftSqlClient2ConnectionTests(MicrosoftSqlClient2DbFactoryFixture fixture)
		: base(fixture)
	{
	}
}
