using AdoNet.Specification.Tests;

namespace MySqlData.Tests
{
	public sealed class MySqlDataConnectionStringBuilderTests : ConnectionStringTestBase<MySqlDataDbFactoryFixture>
	{
		public MySqlDataConnectionStringBuilderTests(MySqlDataDbFactoryFixture fixture)
			: base(fixture)
		{
		}
	}
}
