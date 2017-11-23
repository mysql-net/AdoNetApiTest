using AdoNet.Specification.Tests;
using Xunit;

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
