using AdoNet.Specification.Tests;

namespace MySqlData8.Tests
{
	public sealed class MySqlData8TransactionTests : TransactionTestBase<MySqlData8DbFactoryFixture>
	{
		public MySqlData8TransactionTests(MySqlData8DbFactoryFixture fixture)
			: base(fixture)
		{
		}
	}
}
