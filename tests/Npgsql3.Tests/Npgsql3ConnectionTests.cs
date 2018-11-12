using AdoNet.Specification.Tests;

namespace Npgsql3.Tests
{
	public sealed class Npgsql3ConnectionTests : ConnectionTestBase<Npgsql3DbFactoryFixture>
	{
		public Npgsql3ConnectionTests(Npgsql3DbFactoryFixture fixture)
			: base(fixture)
		{
		}
	}
}
