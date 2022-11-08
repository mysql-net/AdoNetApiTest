namespace Npgsql7.Tests;

public sealed class Npgsql7TransactionTests : TransactionTestBase<Npgsql7DbFactoryFixture>
{
	public Npgsql7TransactionTests(Npgsql7DbFactoryFixture fixture)
		: base(fixture)
	{
	}
}
