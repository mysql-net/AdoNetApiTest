using AdoNet.Specification.Tests;

namespace MicrosoftSqlClient7.Tests;

public sealed class MicrosoftSqlClient7CommandTests : CommandTestBase<MicrosoftSqlClient7DbFactoryFixture>
{
	public MicrosoftSqlClient7CommandTests(MicrosoftSqlClient7DbFactoryFixture fixture)
		: base(fixture)
	{
	}
}
