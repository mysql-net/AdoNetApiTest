using AdoNet.Specification.Tests;

namespace MicrosoftSqlite6.Tests;

public sealed class MicrosoftSqlite6ConnectionTests : ConnectionTestBase<MicrosoftSqlite6DbFactoryFixture>
{
	public MicrosoftSqlite6ConnectionTests(MicrosoftSqlite6DbFactoryFixture fixture)
		: base(fixture)
	{
	}
}
