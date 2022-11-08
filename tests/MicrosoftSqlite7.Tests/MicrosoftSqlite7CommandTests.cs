using AdoNet.Specification.Tests;

namespace MicrosoftSqlite7.Tests;

public sealed class MicrosoftSqlite7CommandTests : CommandTestBase<MicrosoftSqlite7DbFactoryFixture>
{
	public MicrosoftSqlite7CommandTests(MicrosoftSqlite7DbFactoryFixture fixture)
		: base(fixture)
	{
	}
}
