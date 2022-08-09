using AdoNet.Specification.Tests;

namespace MicrosoftSqlite5.Tests;

public sealed class MicrosoftSqlite5DbProviderFactoryTests : DbProviderFactoryTestBase<MicrosoftSqlite5DbFactoryFixture>
{
	public MicrosoftSqlite5DbProviderFactoryTests(MicrosoftSqlite5DbFactoryFixture fixture)
		: base(fixture)
	{
	}
}
