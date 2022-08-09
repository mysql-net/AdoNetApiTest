using AdoNet.Specification.Tests;

namespace MicrosoftSqlite5.Tests;

public sealed class MicrosoftSqlite5ConnectionStringBuilderTests : ConnectionStringTestBase<MicrosoftSqlite5DbFactoryFixture>
{
	public MicrosoftSqlite5ConnectionStringBuilderTests(MicrosoftSqlite5DbFactoryFixture fixture)
		: base(fixture)
	{
	}
}

