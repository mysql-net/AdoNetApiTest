using AdoNet.Specification.Tests;

namespace MicrosoftSqlite6.Tests;

public sealed class MicrosoftSqlite6DataReaderTests : DataReaderTestBase<MicrosoftSqlite6SelectValueFixture>
{
	public MicrosoftSqlite6DataReaderTests(MicrosoftSqlite6SelectValueFixture fixture)
		: base(fixture)
	{
	}
}
