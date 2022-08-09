using AdoNet.Specification.Tests;

namespace MicrosoftSqlClient5.Tests;

public sealed class MicrosoftSqlClient5CommandTests : CommandTestBase<MicrosoftSqlClient5DbFactoryFixture>
{
	public MicrosoftSqlClient5CommandTests(MicrosoftSqlClient5DbFactoryFixture fixture)
		: base(fixture)
	{
	}
}
