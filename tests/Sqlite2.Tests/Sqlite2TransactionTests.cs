using AdoNet.Specification.Tests;

namespace Sqlite2.Tests;

public sealed class Sqlite2TransactionTests : TransactionTestBase<Sqlite2DbFactoryFixture>
{
	public Sqlite2TransactionTests(Sqlite2DbFactoryFixture fixture)
		: base(fixture)
	{
	}
}
