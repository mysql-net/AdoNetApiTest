using AdoNet.Specification.Tests;

namespace MicrosoftSqlClient.Tests
{
	public sealed class MicrosoftSqlClientConnectionTests : ConnectionTestBase<MicrosoftSqlClientDbFactoryFixture>
	{
		public MicrosoftSqlClientConnectionTests(MicrosoftSqlClientDbFactoryFixture fixture)
			: base(fixture)
		{
		}
	}
}
