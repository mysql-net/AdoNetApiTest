using AdoNet.Specification.Tests;

namespace MicrosoftSqlClient2.Tests;

public sealed class MicrosoftSqlClient2DbProviderFactoryTests : DbProviderFactoryTestBase<MicrosoftSqlClient2DbFactoryFixture>
{
	public MicrosoftSqlClient2DbProviderFactoryTests(MicrosoftSqlClient2DbFactoryFixture fixture)
		: base(fixture)
	{
	}
}
