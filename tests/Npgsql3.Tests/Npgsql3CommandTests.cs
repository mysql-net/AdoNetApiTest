using AdoNet.Specification.Tests;

namespace Npgsql3.Tests
{
	public sealed class Npgsql3CommandTests : CommandTestBase<Npgsql3DbFactoryFixture>
	{
		public Npgsql3CommandTests(Npgsql3DbFactoryFixture fixture)
			: base(fixture)
		{
		}
	}
}
