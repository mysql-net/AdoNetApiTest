using AdoNet.Specification.Tests;

namespace MicrosoftSqlite5.Tests;

public class MicrosoftSqlite5GetValueConversionTests : GetValueConversionTestBase<MicrosoftSqlite5SelectValueFixture>
{
	public MicrosoftSqlite5GetValueConversionTests(MicrosoftSqlite5SelectValueFixture fixture)
		: base(fixture)
	{
	}
}
