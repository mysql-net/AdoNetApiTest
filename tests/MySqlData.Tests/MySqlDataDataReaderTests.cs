using AdoNet.Specification.Tests;

namespace MySqlData.Tests;

public sealed class MySqlDataDataReaderTests : DataReaderTestBase<MySqlDataSelectValueFixture>
{
	public MySqlDataDataReaderTests(MySqlDataSelectValueFixture fixture)
		: base(fixture)
	{
	}
}
