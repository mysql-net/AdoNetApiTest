using AdoNet.Specification.Tests;

namespace DotConnectPostgres.Tests;

public sealed class DotConnectPostgresTransactionTests : TransactionTestBase<DotConnectPostgresDbFactoryFixture>
{
	public DotConnectPostgresTransactionTests(DotConnectPostgresSelectValueFixture fixture)
		: base(fixture)
	{
	}
}
