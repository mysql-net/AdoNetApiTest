using AdoNet.Specification.Tests;

namespace MicrosoftSqlite22.Tests
{
	public sealed class MicrosoftSqlite22ConnectionStringBuilderTests : ConnectionStringTestBase<MicrosoftSqlite22DbFactoryFixture>
	{
		public MicrosoftSqlite22ConnectionStringBuilderTests(MicrosoftSqlite22DbFactoryFixture fixture)
			: base(fixture)
		{
		}
	}

}
