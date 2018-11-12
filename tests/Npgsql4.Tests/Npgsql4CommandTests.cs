using AdoNet.Specification.Tests;

namespace Npgsql4.Tests
{
	public sealed class Npgsql4CommandTests : CommandTestBase<Npgsql4DbFactoryFixture>
	{
		public Npgsql4CommandTests(Npgsql4DbFactoryFixture fixture)
			: base(fixture)
		{
		}
	}
}
