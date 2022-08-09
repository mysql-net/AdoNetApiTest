using AdoNet.Specification.Tests;

namespace MicrosoftSqlClient3.Tests;

public sealed class MicrosoftSqlClient3ConnectionStringBuilderTests : ConnectionStringTestBase<MicrosoftSqlClient3DbFactoryFixture>
{
	public MicrosoftSqlClient3ConnectionStringBuilderTests(MicrosoftSqlClient3DbFactoryFixture fixture)
		: base(fixture)
	{
	}
}
