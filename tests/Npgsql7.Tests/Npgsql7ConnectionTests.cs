namespace Npgsql7.Tests;

public sealed class Npgsql7ConnectionTests : ConnectionTestBase<Npgsql7DbFactoryFixture>
{
	public Npgsql7ConnectionTests(Npgsql7DbFactoryFixture fixture)
		: base(fixture)
	{
	}
}
