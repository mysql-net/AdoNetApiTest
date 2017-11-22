using AdoNet.Specification.Tests;

namespace AdoNet.MicrosoftSqlite.FunctionalTests
{
	public sealed class MicrosoftSqliteConnectionTests : ConnectionTestBase<MicrosoftSqliteDbFactoryFixture>
	{
		public MicrosoftSqliteConnectionTests(MicrosoftSqliteDbFactoryFixture fixture)
			: base(fixture)
		{
		}
	}
}
