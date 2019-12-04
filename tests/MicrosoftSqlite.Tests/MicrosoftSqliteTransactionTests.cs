using AdoNet.Specification.Tests;

namespace MicrosoftSqlite.Tests
{
	public sealed class MicrosoftSqliteTransactionTests : TransactionTestBase<MicrosoftSqliteDbFactoryFixture>
	{
		public MicrosoftSqliteTransactionTests(MicrosoftSqliteDbFactoryFixture fixture)
			: base(fixture)
		{
		}
	}
}
