using AdoNet.Specification.Tests;

namespace MicrosoftSqlClient.Tests
{
	public sealed class MicrosoftSqlClientConnectionStringBuilderTests : ConnectionStringTestBase<MicrosoftSqlClientDbFactoryFixture>
	{
		public MicrosoftSqlClientConnectionStringBuilderTests(MicrosoftSqlClientDbFactoryFixture fixture)
			: base(fixture)
		{
		}
	}
}
