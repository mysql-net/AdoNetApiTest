using AdoNet.Specification.Tests;

namespace MicrosoftSqlite.Tests;

public class MicrosoftSqliteGetValueConversionTests : GetValueConversionTestBase<MicrosoftSqliteSelectValueFixture>
{
	public MicrosoftSqliteGetValueConversionTests(MicrosoftSqliteSelectValueFixture fixture)
		: base(fixture)
	{
	}
}
