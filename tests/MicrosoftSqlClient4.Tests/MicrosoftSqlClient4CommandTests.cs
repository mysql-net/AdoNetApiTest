using AdoNet.Specification.Tests;

namespace MicrosoftSqlClient4.Tests;

public sealed class MicrosoftSqlClient4CommandTests : CommandTestBase<MicrosoftSqlClient4DbFactoryFixture>
{
	public MicrosoftSqlClient4CommandTests(MicrosoftSqlClient4DbFactoryFixture fixture)
		: base(fixture)
	{
	}
}
