using AdoNet.Specification.Tests;

namespace MicrosoftSqlite21.Tests
{
	public sealed class MicrosoftSqlite21DataReaderTests : DataReaderTestBase<MicrosoftSqlite21SelectValueFixture>
	{
		public MicrosoftSqlite21DataReaderTests(MicrosoftSqlite21SelectValueFixture fixture)
			: base(fixture)
		{
		}
	}
}
