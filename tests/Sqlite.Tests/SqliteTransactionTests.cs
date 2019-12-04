using AdoNet.Specification.Tests;

namespace Sqlite.Tests
{
	public sealed class SqliteTransactionTests : TransactionTestBase<SqliteDbFactoryFixture>
	{
		public SqliteTransactionTests(SqliteDbFactoryFixture fixture)
			: base(fixture)
		{
		}
	}
}
