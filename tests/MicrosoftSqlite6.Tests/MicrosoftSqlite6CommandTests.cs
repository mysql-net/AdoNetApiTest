using AdoNet.Specification.Tests;

namespace MicrosoftSqlite6.Tests;

public sealed class MicrosoftSqlite6CommandTests : CommandTestBase<MicrosoftSqlite6DbFactoryFixture>
{
	public MicrosoftSqlite6CommandTests(MicrosoftSqlite6DbFactoryFixture fixture)
		: base(fixture)
	{
	}
}
