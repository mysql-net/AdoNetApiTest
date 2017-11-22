using AdoNet.Specification.Tests;

namespace AdoNet.MicrosoftSqlite.FunctionalTests
{
	public sealed class MicrosoftSqliteCommandTests : CommandTestBase<MicrosoftSqliteDbFactoryFixture>
	{
		public MicrosoftSqliteCommandTests(MicrosoftSqliteDbFactoryFixture fixture)
			: base(fixture)
		{
		}
	}
}
