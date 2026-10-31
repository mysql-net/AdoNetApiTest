using AdoNet.Specification.Tests;

namespace MicrosoftSqlite10.Tests;

public sealed class MicrosoftSqlite10DataReaderTests(MicrosoftSqlite10SelectValueFixture fixture)
	: DataReaderTestBase<MicrosoftSqlite10SelectValueFixture>(fixture)
{
}
