using AdoNet.Specification.Tests;

namespace MySqlData.Tests
{
	public sealed class MySqlDataDataReaderTests : DataReaderTestBase<MySqlDataGetValueFixture>
	{
		public MySqlDataDataReaderTests(MySqlDataGetValueFixture fixture)
			: base(fixture)
		{
		}
	}
}
