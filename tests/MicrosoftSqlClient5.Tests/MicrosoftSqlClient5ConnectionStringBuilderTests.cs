using AdoNet.Specification.Tests;

namespace MicrosoftSqlClient5.Tests;

public sealed class MicrosoftSqlClient5ConnectionStringBuilderTests : ConnectionStringTestBase<MicrosoftSqlClient5DbFactoryFixture>
{
	public MicrosoftSqlClient5ConnectionStringBuilderTests(MicrosoftSqlClient5DbFactoryFixture fixture)
		: base(fixture)
	{
	}
}
