using AdoNet.Specification.Tests;

namespace MicrosoftSqlite.Tests
{
	public sealed class MicrosoftSqliteDataReaderTests : DataReaderTestBase<MicrosoftSqliteSelectValueFixture>
	{
		public MicrosoftSqliteDataReaderTests(MicrosoftSqliteSelectValueFixture fixture)
			: base(fixture)
		{
		}
	}
}
