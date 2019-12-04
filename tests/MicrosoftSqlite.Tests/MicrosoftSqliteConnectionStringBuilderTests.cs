using AdoNet.Specification.Tests;

namespace MicrosoftSqlite.Tests
{
	public sealed class MicrosoftSqliteConnectionStringBuilderTests : ConnectionStringTestBase<MicrosoftSqliteDbFactoryFixture>
	{
		public MicrosoftSqliteConnectionStringBuilderTests(MicrosoftSqliteDbFactoryFixture fixture)
			: base(fixture)
		{
		}
	}

}
