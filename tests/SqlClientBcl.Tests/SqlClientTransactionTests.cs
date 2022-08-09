using AdoNet.Specification.Tests;

namespace SqlClientBcl.Tests;

public sealed class SqlClientTransactionTests : TransactionTestBase<SqlClientDbFactoryFixture>
{
	public SqlClientTransactionTests(SqlClientDbFactoryFixture fixture)
		: base(fixture)
	{
	}
}
