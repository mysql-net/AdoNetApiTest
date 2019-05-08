using AdoNet.Specification.Tests;

namespace MicrosoftSqlClient.Tests
{
	public sealed class MicrosoftSqlClientCommandTests : CommandTestBase<MicrosoftSqlClientDbFactoryFixture>
	{
		public MicrosoftSqlClientCommandTests(MicrosoftSqlClientDbFactoryFixture fixture)
			: base(fixture)
		{
		}
	}
}
