using AdoNet.Specification.Tests;

namespace MySqlData.Tests
{
	public sealed class MySqlDataCommandTests : CommandTestBase<MySqlDataDbFactoryFixture>
	{
		public MySqlDataCommandTests(MySqlDataDbFactoryFixture fixture)
			: base(fixture)
		{
		}
	}
}
