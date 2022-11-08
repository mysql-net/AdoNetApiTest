using AdoNet.Specification.Tests;

namespace MicrosoftSqlite7.Tests;

public sealed class MicrosoftSqlite7DbProviderFactoryTests : DbProviderFactoryTestBase<MicrosoftSqlite7DbFactoryFixture>
{
	public MicrosoftSqlite7DbProviderFactoryTests(MicrosoftSqlite7DbFactoryFixture fixture)
		: base(fixture)
	{
	}
}
