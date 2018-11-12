using AdoNet.Specification.Tests;

namespace Npgsql4.Tests
{
	public sealed class Npgsql4ParameterTests : ParameterTestBase<Npgsql4DbFactoryFixture>
	{
		public Npgsql4ParameterTests(Npgsql4DbFactoryFixture fixture)
			: base(fixture)
		{
		}
	}
}
