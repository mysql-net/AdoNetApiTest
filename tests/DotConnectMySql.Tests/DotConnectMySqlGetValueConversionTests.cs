using AdoNet.Specification.Tests;

namespace DotConnectMySql.Tests
{
	public class DotConnectMySqlGetValueConversionTests : GetValueConversionTestBase<DotConnectMySqlSelectValueFixture>
	{
		public DotConnectMySqlGetValueConversionTests(DotConnectMySqlSelectValueFixture fixture)
			: base(fixture)
		{
		}
	}
}
