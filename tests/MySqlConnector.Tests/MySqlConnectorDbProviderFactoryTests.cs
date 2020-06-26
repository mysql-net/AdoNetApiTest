using AdoNet.Specification.Tests;

namespace MySqlConnector.Tests
{
	public sealed class MySqlConnectorDbProviderFactoryTests : DbProviderFactoryTestBase<MySqlConnectorDbFactoryFixture>
	{
		public MySqlConnectorDbProviderFactoryTests(MySqlConnectorDbFactoryFixture fixture)
			: base(fixture)
		{
		}
	}
}
