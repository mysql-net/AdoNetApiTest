using AdoNet.Specification.Tests;

namespace MicrosoftSqlClient3.Tests;

public sealed class MicrosoftSqlClient3CommandTests : CommandTestBase<MicrosoftSqlClient3DbFactoryFixture>
{
	public MicrosoftSqlClient3CommandTests(MicrosoftSqlClient3DbFactoryFixture fixture)
		: base(fixture)
	{
	}
}
