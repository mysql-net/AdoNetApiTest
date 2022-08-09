using AdoNet.Specification.Tests;

namespace Npgsql5.Tests;

public sealed class Npgsql5ParameterTests : ParameterTestBase<Npgsql5DbFactoryFixture>
{
	public Npgsql5ParameterTests(Npgsql5DbFactoryFixture fixture)
		: base(fixture)
	{
	}
}
