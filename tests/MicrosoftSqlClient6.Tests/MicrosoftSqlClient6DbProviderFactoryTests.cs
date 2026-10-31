using AdoNet.Specification.Tests;

namespace MicrosoftSqlClient6.Tests;

public sealed class MicrosoftSqlClient6DbProviderFactoryTests : DbProviderFactoryTestBase<MicrosoftSqlClient6DbFactoryFixture>
{
	public MicrosoftSqlClient6DbProviderFactoryTests(MicrosoftSqlClient6DbFactoryFixture fixture)
		: base(fixture)
	{
	}
}
