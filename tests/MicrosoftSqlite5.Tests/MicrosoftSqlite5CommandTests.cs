using AdoNet.Specification.Tests;

namespace MicrosoftSqlite5.Tests
{
	public sealed class MicrosoftSqlite5CommandTests : CommandTestBase<MicrosoftSqlite5DbFactoryFixture>
	{
		public MicrosoftSqlite5CommandTests(MicrosoftSqlite5DbFactoryFixture fixture)
			: base(fixture)
		{
		}
	}
}
