using AdoNet.Specification.Tests;

namespace Npgsql5.Tests
{
	public sealed class Npgsql5ConnectionStringBuilderTests : ConnectionStringTestBase<Npgsql5DbFactoryFixture>
	{
		public Npgsql5ConnectionStringBuilderTests(Npgsql5DbFactoryFixture fixture)
			: base(fixture)
		{
		}
	}
}
