using AdoNet.Specification.Tests;

namespace MicrosoftSqlClient6.Tests;

public sealed class MicrosoftSqlClient6ConnectionTests : ConnectionTestBase<MicrosoftSqlClient6DbFactoryFixture>
{
	public MicrosoftSqlClient6ConnectionTests(MicrosoftSqlClient6DbFactoryFixture fixture)
		: base(fixture)
	{
	}
}
