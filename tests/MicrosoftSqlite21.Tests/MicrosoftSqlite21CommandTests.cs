using AdoNet.Specification.Tests;

namespace MicrosoftSqlite21.Tests
{
	public sealed class MicrosoftSqlite21CommandTests : CommandTestBase<MicrosoftSqlite21DbFactoryFixture>
	{
		public MicrosoftSqlite21CommandTests(MicrosoftSqlite21DbFactoryFixture fixture)
			: base(fixture)
		{
		}
	}
}
