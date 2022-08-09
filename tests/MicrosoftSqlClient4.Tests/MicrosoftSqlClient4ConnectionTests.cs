using AdoNet.Specification.Tests;

namespace MicrosoftSqlClient4.Tests;

public sealed class MicrosoftSqlClient4ConnectionTests : ConnectionTestBase<MicrosoftSqlClient4DbFactoryFixture>
{
	public MicrosoftSqlClient4ConnectionTests(MicrosoftSqlClient4DbFactoryFixture fixture)
		: base(fixture)
	{
	}
}
