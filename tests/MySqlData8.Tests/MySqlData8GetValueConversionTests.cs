using AdoNet.Specification.Tests;

namespace MySqlData8.Tests
{
	public class MySqlData8GetValueConversionTests : GetValueConversionTestBase<MySqlData8SelectValueFixture>
	{
		public MySqlData8GetValueConversionTests(MySqlData8SelectValueFixture fixture)
			: base(fixture)
		{
		}
	}
}
