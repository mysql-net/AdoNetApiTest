using AdoNet.Specification.Tests;

namespace MicrosoftSqlite6.Tests
{
	public sealed class MicrosoftSqlite6TransactionTests : TransactionTestBase<MicrosoftSqlite6DbFactoryFixture>
	{
		public MicrosoftSqlite6TransactionTests(MicrosoftSqlite6DbFactoryFixture fixture)
			: base(fixture)
		{
		}
	}
}
