using AdoNet.Specification.Tests;
using Xunit;

namespace MySqlConnector.Tests
{
	public sealed class MySqlConnectorCommandTests : CommandTestBase<MySqlConnectorDbFactoryFixture>
	{
		public MySqlConnectorCommandTests(MySqlConnectorDbFactoryFixture fixture)
			: base(fixture)
		{
		}
	}
}
