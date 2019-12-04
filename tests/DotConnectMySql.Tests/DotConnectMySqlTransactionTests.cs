using AdoNet.Specification.Tests;

namespace DotConnectMySql.Tests
{
	public sealed class DotConnectMySqlTransactionTests : TransactionTestBase<DotConnectMySqlDbFactoryFixture>
	{
		public DotConnectMySqlTransactionTests(DotConnectMySqlSelectValueFixture fixture)
			: base(fixture)
		{
		}
	}
}
