using AdoNet.Specification.Tests;

namespace MicrosoftSqlite.Tests
{
	public sealed class MicrosoftSqliteDbProviderFactoryTests : DbProviderFactoryTestBase<MicrosoftSqliteDbFactoryFixture>
	{
		public MicrosoftSqliteDbProviderFactoryTests(MicrosoftSqliteDbFactoryFixture fixture)
			: base(fixture)
		{
		}
	}
}
