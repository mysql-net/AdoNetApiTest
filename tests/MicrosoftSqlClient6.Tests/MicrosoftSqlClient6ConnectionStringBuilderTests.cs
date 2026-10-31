using AdoNet.Specification.Tests;

namespace MicrosoftSqlClient6.Tests;

public sealed class MicrosoftSqlClient6ConnectionStringBuilderTests : ConnectionStringTestBase<MicrosoftSqlClient6DbFactoryFixture>
{
	public MicrosoftSqlClient6ConnectionStringBuilderTests(MicrosoftSqlClient6DbFactoryFixture fixture)
		: base(fixture)
	{
	}
}
