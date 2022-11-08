using AdoNet.Specification.Tests;

namespace MicrosoftSqlite7.Tests;

public sealed class MicrosoftSqlite7ConnectionStringBuilderTests : ConnectionStringTestBase<MicrosoftSqlite7DbFactoryFixture>
{
	public MicrosoftSqlite7ConnectionStringBuilderTests(MicrosoftSqlite7DbFactoryFixture fixture)
		: base(fixture)
	{
	}
}

