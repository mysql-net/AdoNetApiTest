using AdoNet.Specification.Tests;

namespace MySqlConnector.Tests
{
	public sealed class MySqlConnectorDataReaderTests : DataReaderTestBase<MySqlConnectorGetValueFixture>
	{
		public MySqlConnectorDataReaderTests(MySqlConnectorGetValueFixture fixture)
			: base(fixture)
		{
		}
	}
}
