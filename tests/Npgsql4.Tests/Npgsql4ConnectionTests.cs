using AdoNet.Specification.Tests;

namespace Npgsql4.Tests
{
	public sealed class Npgsql4ConnectionTests : ConnectionTestBase<Npgsql4DbFactoryFixture>
	{
		public Npgsql4ConnectionTests(Npgsql4DbFactoryFixture fixture)
			: base(fixture)
		{
		}
	}
}
