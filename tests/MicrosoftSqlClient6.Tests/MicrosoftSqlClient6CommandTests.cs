using AdoNet.Specification.Tests;

namespace MicrosoftSqlClient6.Tests;

public sealed class MicrosoftSqlClient6CommandTests : CommandTestBase<MicrosoftSqlClient6DbFactoryFixture>
{
	public MicrosoftSqlClient6CommandTests(MicrosoftSqlClient6DbFactoryFixture fixture)
		: base(fixture)
	{
	}
}
