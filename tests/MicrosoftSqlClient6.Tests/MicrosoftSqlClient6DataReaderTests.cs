using AdoNet.Specification.Tests;

namespace MicrosoftSqlClient6.Tests;

public sealed class MicrosoftSqlClient6DataReaderTests : DataReaderTestBase<MicrosoftSqlClient6SelectValueFixture>
{
	public MicrosoftSqlClient6DataReaderTests(MicrosoftSqlClient6SelectValueFixture fixture)
		: base(fixture)
	{
	}
}
