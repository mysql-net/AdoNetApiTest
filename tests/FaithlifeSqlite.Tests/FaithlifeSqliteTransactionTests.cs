using AdoNet.Specification.Tests;

namespace FaithlifeSqlite.Tests
{
	public sealed class FaithlifeSqliteTransactionTests : TransactionTestBase<FaithlifeSqliteDbFactoryFixture>
	{
		public FaithlifeSqliteTransactionTests(FaithlifeSqliteDbFactoryFixture fixture)
			: base(fixture)
		{
		}
	}
}
