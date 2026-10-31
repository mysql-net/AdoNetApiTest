using AdoNet.Specification.Tests;

namespace MicrosoftSqlClient7.Tests;

public sealed class MicrosoftSqlClient7DbProviderFactoryTests : DbProviderFactoryTestBase<MicrosoftSqlClient7DbFactoryFixture>
{
	public MicrosoftSqlClient7DbProviderFactoryTests(MicrosoftSqlClient7DbFactoryFixture fixture)
		: base(fixture)
	{
	}
}
