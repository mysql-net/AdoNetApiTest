using AdoNet.Specification.Tests;

namespace MicrosoftSqlite7.Tests;

public sealed class MicrosoftSqlite7DataReaderTests : DataReaderTestBase<MicrosoftSqlite7SelectValueFixture>
{
	public MicrosoftSqlite7DataReaderTests(MicrosoftSqlite7SelectValueFixture fixture)
		: base(fixture)
	{
	}
}
