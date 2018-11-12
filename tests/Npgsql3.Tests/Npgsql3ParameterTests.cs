using AdoNet.Specification.Tests;

namespace Npgsql3.Tests
{
	public sealed class Npgsql3ParameterTests : ParameterTestBase<Npgsql3DbFactoryFixture>
	{
		public Npgsql3ParameterTests(Npgsql3DbFactoryFixture fixture)
			: base(fixture)
		{
		}
	}
}
