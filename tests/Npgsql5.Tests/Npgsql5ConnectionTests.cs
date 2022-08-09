using AdoNet.Specification.Tests;

namespace Npgsql5.Tests;

public sealed class Npgsql5ConnectionTests : ConnectionTestBase<Npgsql5DbFactoryFixture>
{
	public Npgsql5ConnectionTests(Npgsql5DbFactoryFixture fixture)
		: base(fixture)
	{
	}
}
