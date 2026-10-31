using AdoNet.Specification.Tests;

namespace MySqlData9.Tests;

public sealed class MySqlData9DataReaderTests : DataReaderTestBase<MySqlData9SelectValueFixture>
{
	public MySqlData9DataReaderTests(MySqlData9SelectValueFixture fixture)
		: base(fixture)
	{
	}
}
