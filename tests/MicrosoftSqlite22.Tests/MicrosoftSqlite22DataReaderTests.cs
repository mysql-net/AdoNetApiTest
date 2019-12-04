using AdoNet.Specification.Tests;

namespace MicrosoftSqlite22.Tests
{
	public sealed class MicrosoftSqlite22DataReaderTests : DataReaderTestBase<MicrosoftSqlite22SelectValueFixture>
	{
		public MicrosoftSqlite22DataReaderTests(MicrosoftSqlite22SelectValueFixture fixture)
			: base(fixture)
		{
		}
	}
}
