using AdoNet.Specification.Tests;

namespace Npgsql4.Tests;

public class Npgsql4GetValueConversionTests : GetValueConversionTestBase<Npgsql4SelectValueFixture>
{
	public Npgsql4GetValueConversionTests(Npgsql4SelectValueFixture fixture)
		: base(fixture)
	{
	}
}
