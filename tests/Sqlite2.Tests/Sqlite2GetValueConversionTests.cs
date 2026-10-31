using AdoNet.Specification.Tests;

namespace Sqlite2.Tests;

public class Sqlite2GetValueConversionTests : GetValueConversionTestBase<Sqlite2SelectValueFixture>
{
	public Sqlite2GetValueConversionTests(Sqlite2SelectValueFixture fixture)
		: base(fixture)
	{
	}
}
