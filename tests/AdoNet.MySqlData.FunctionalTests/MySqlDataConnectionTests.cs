using AdoNet.Specification.Tests;

namespace AdoNet.MySqlData.FunctionalTests
{
	public sealed class MySqlDataConnectionTests : ConnectionTestBase<MySqlDataDbFactoryFixture>
	{
		public MySqlDataConnectionTests(MySqlDataDbFactoryFixture fixture)
			: base(fixture)
		{
		}
	}
}
