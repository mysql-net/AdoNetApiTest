using AdoNet.Specification.Tests;

namespace MicrosoftSqlite6.Tests
{
	public sealed class MicrosoftSqlite6DbProviderFactoryTests : DbProviderFactoryTestBase<MicrosoftSqlite6DbFactoryFixture>
	{
		public MicrosoftSqlite6DbProviderFactoryTests(MicrosoftSqlite6DbFactoryFixture fixture)
			: base(fixture)
		{
		}
	}
}
