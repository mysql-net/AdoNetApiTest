using AdoNet.Specification.Tests;

namespace Npgsql3.Tests
{
	public sealed class Npgsql3ConnectionStringBuilderTests : ConnectionStringTestBase<Npgsql3DbFactoryFixture>
	{
		public Npgsql3ConnectionStringBuilderTests(Npgsql3DbFactoryFixture fixture)
			: base(fixture)
		{
		}
	}
}
