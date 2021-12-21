using AdoNet.Specification.Tests;

namespace MicrosoftSqlite6.Tests
{
	public sealed class MicrosoftSqlite6ConnectionStringBuilderTests : ConnectionStringTestBase<MicrosoftSqlite6DbFactoryFixture>
	{
		public MicrosoftSqlite6ConnectionStringBuilderTests(MicrosoftSqlite6DbFactoryFixture fixture)
			: base(fixture)
		{
		}
	}

}
