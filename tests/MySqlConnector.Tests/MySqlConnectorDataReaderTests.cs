using AdoNet.Specification.Tests;

namespace MySqlConnector.Tests
{
	public sealed class MySqlConnectorDataReaderTests : DataReaderTestBase<MySqlConnectorDbFactoryFixture>
	{
		public MySqlConnectorDataReaderTests(MySqlConnectorDbFactoryFixture fixture)
			: base(fixture)
		{
		}
	}
}
