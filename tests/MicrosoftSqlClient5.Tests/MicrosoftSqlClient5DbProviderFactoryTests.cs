using AdoNet.Specification.Tests;

namespace MicrosoftSqlClient5.Tests;

public sealed class MicrosoftSqlClient5DbProviderFactoryTests : DbProviderFactoryTestBase<MicrosoftSqlClient5DbFactoryFixture>
{
	public MicrosoftSqlClient5DbProviderFactoryTests(MicrosoftSqlClient5DbFactoryFixture fixture)
		: base(fixture)
	{
	}
}
