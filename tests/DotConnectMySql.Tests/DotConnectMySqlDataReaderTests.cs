using AdoNet.Specification.Tests;

namespace DotConnectMySql.Tests
{
	public sealed class DotConnectMySqlDataReaderTests : DataReaderTestBase<DotConnectMySqlSelectValueFixture>
	{
		public DotConnectMySqlDataReaderTests(DotConnectMySqlSelectValueFixture fixture)
			: base(fixture)
		{
		}
	}
}
