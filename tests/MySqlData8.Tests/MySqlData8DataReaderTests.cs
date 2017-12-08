using AdoNet.Specification.Tests;

namespace MySqlData8.Tests
{
	public sealed class MySqlData8DataReaderTests : DataReaderTestBase<MySqlData8SelectValueFixture>
	{
		public MySqlData8DataReaderTests(MySqlData8SelectValueFixture fixture)
			: base(fixture)
		{
		}
	}
}
