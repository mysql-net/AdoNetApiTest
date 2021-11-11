namespace Npgsql6.Tests;

public sealed class Npgsql6ConnectionTests : ConnectionTestBase<Npgsql6DbFactoryFixture>
{
	public Npgsql6ConnectionTests(Npgsql6DbFactoryFixture fixture)
		: base(fixture)
	{
	}
}
