using AdoNet.Specification.Tests;

namespace MicrosoftSqlClient.Tests
{
	public sealed class MicrosoftSqlClientTransactionTests : TransactionTestBase<MicrosoftSqlClientDbFactoryFixture>
	{
		public MicrosoftSqlClientTransactionTests(MicrosoftSqlClientDbFactoryFixture fixture)
			: base(fixture)
		{
		}
	}
}
