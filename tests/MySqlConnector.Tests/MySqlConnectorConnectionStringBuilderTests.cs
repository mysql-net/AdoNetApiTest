using AdoNet.Specification.Tests;

namespace MySqlConnector.Tests;

public sealed class MySqlConnectorConnectionStringBuilderTests : ConnectionStringTestBase<MySqlConnectorDbFactoryFixture>
{
	public MySqlConnectorConnectionStringBuilderTests(MySqlConnectorDbFactoryFixture fixture)
		: base(fixture)
	{
	}
}

