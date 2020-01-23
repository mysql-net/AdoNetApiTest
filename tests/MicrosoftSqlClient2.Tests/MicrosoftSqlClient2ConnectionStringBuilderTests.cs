using AdoNet.Specification.Tests;

namespace MicrosoftSqlClient2.Tests
{
	public sealed class MicrosoftSqlClient2ConnectionStringBuilderTests : ConnectionStringTestBase<MicrosoftSqlClient2DbFactoryFixture>
	{
		public MicrosoftSqlClient2ConnectionStringBuilderTests(MicrosoftSqlClient2DbFactoryFixture fixture)
			: base(fixture)
		{
		}
	}
}
