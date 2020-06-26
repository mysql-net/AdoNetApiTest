using AdoNet.Specification.Tests;

namespace Npgsql3.Tests
{
	public sealed class Npgsql3DbProviderFactoryTests : DbProviderFactoryTestBase<Npgsql3DbFactoryFixture>
	{
		public Npgsql3DbProviderFactoryTests(Npgsql3DbFactoryFixture fixture)
			: base(fixture)
		{
		}
	}
}
