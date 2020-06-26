using AdoNet.Specification.Tests;

namespace MicrosoftSqlite22.Tests
{
	public sealed class MicrosoftSqlite22DbProviderFactoryTests : DbProviderFactoryTestBase<MicrosoftSqlite22DbFactoryFixture>
	{
		public MicrosoftSqlite22DbProviderFactoryTests(MicrosoftSqlite22DbFactoryFixture fixture)
			: base(fixture)
		{
		}
	}
}
