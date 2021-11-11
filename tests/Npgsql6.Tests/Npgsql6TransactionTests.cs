namespace Npgsql6.Tests;

public sealed class Npgsql6TransactionTests : TransactionTestBase<Npgsql6DbFactoryFixture>
{
	public Npgsql6TransactionTests(Npgsql6DbFactoryFixture fixture)
		: base(fixture)
	{
	}
}
