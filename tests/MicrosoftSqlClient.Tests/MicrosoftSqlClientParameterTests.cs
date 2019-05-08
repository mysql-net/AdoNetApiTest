using AdoNet.Specification.Tests;

namespace MicrosoftSqlClient.Tests
{
	public sealed class MicrosoftSqlClientParameterTests : ParameterTestBase<MicrosoftSqlClientDbFactoryFixture>
	{
		public MicrosoftSqlClientParameterTests(MicrosoftSqlClientDbFactoryFixture fixture)
			: base(fixture)
		{
		}
	}
}
