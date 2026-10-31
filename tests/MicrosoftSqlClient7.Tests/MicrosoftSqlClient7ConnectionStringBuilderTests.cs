using AdoNet.Specification.Tests;

namespace MicrosoftSqlClient7.Tests;

public sealed class MicrosoftSqlClient7ConnectionStringBuilderTests : ConnectionStringTestBase<MicrosoftSqlClient7DbFactoryFixture>
{
	public MicrosoftSqlClient7ConnectionStringBuilderTests(MicrosoftSqlClient7DbFactoryFixture fixture)
		: base(fixture)
	{
	}
}
