using AdoNet.Specification.Tests;

namespace MicrosoftSqlClient3.Tests
{
	public sealed class MicrosoftSqlClient3DbProviderFactoryTests : DbProviderFactoryTestBase<MicrosoftSqlClient3DbFactoryFixture>
	{
		public MicrosoftSqlClient3DbProviderFactoryTests(MicrosoftSqlClient3DbFactoryFixture fixture)
			: base(fixture)
		{
		}
	}
}
