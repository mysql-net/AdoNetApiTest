using AdoNet.Specification.Tests;

namespace Npgsql5.Tests;

public class Npgsql5GetValueConversionTests : GetValueConversionTestBase<Npgsql5SelectValueFixture>
{
	public Npgsql5GetValueConversionTests(Npgsql5SelectValueFixture fixture)
		: base(fixture)
	{
	}
}
