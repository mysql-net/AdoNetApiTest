using AdoNet.Specification.Tests;

namespace MySqlConnector.Tests
{
	public sealed class MySqlConnectorDataReaderTests : DataReaderTestBase<MySqlConnectorSelectValueFixture>
	{
		public MySqlConnectorDataReaderTests(MySqlConnectorSelectValueFixture fixture)
			: base(fixture)
		{
		}
	}
}
