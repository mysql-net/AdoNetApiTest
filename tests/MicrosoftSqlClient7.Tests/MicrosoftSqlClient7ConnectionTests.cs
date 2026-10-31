using AdoNet.Specification.Tests;

namespace MicrosoftSqlClient7.Tests;

public sealed class MicrosoftSqlClient7ConnectionTests : ConnectionTestBase<MicrosoftSqlClient7DbFactoryFixture>
{
	public MicrosoftSqlClient7ConnectionTests(MicrosoftSqlClient7DbFactoryFixture fixture)
		: base(fixture)
	{
	}
}
