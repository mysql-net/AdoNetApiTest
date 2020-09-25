using AdoNet.Specification.Tests;

namespace MicrosoftSqlite5.Tests
{
	public sealed class MicrosoftSqlite5DataReaderTests : DataReaderTestBase<MicrosoftSqlite5SelectValueFixture>
	{
		public MicrosoftSqlite5DataReaderTests(MicrosoftSqlite5SelectValueFixture fixture)
			: base(fixture)
		{
		}
	}
}
