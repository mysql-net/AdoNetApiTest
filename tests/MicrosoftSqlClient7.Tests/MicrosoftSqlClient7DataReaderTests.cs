using AdoNet.Specification.Tests;

namespace MicrosoftSqlClient7.Tests;

public sealed class MicrosoftSqlClient7DataReaderTests : DataReaderTestBase<MicrosoftSqlClient7SelectValueFixture>
{
	public MicrosoftSqlClient7DataReaderTests(MicrosoftSqlClient7SelectValueFixture fixture)
		: base(fixture)
	{
	}
}
