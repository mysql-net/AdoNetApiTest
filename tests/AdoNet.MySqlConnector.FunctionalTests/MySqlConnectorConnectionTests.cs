using AdoNet.Specification.Tests;

namespace AdoNet.MySqlConnector.FunctionalTests
{
	public sealed class MySqlConnectorConnectionTests : ConnectionTestBase<MySqlConnectorDbFactoryFixture>
	{
		public MySqlConnectorConnectionTests(MySqlConnectorDbFactoryFixture fixture)
			: base(fixture)
		{
		}
	}
}
