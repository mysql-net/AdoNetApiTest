using AdoNet.Specification.Tests;

namespace MicrosoftSqlite7.Tests;

public class MicrosoftSqlite7GetValueConversionTests : GetValueConversionTestBase<MicrosoftSqlite7SelectValueFixture>
{
	public MicrosoftSqlite7GetValueConversionTests(MicrosoftSqlite7SelectValueFixture fixture)
		: base(fixture)
	{
	}
}
