using AdoNet.Specification.Tests;

namespace MicrosoftSqlClient3.Tests;

public sealed class MicrosoftSqlClient3DataReaderTests : DataReaderTestBase<MicrosoftSqlClient3SelectValueFixture>
{
	public MicrosoftSqlClient3DataReaderTests(MicrosoftSqlClient3SelectValueFixture fixture)
		: base(fixture)
	{
	}
}
