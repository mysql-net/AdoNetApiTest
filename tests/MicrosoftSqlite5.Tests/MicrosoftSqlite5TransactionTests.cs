using AdoNet.Specification.Tests;

namespace MicrosoftSqlite5.Tests
{
	public sealed class MicrosoftSqlite5TransactionTests : TransactionTestBase<MicrosoftSqlite5DbFactoryFixture>
	{
		public MicrosoftSqlite5TransactionTests(MicrosoftSqlite5DbFactoryFixture fixture)
			: base(fixture)
		{
		}
	}
}
