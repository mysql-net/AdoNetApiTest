using AdoNet.Specification.Tests;

namespace MicrosoftSqlClient.Tests
{
	public sealed class MicrosoftSqlClientDbProviderFactoryTests : DbProviderFactoryTestBase<MicrosoftSqlClientDbFactoryFixture>
	{
		public MicrosoftSqlClientDbProviderFactoryTests(MicrosoftSqlClientDbFactoryFixture fixture)
			: base(fixture)
		{
		}
	}
}
