namespace Npgsql10.Tests;

public sealed class Npgsql10TransactionTests(Npgsql10DbFactoryFixture fixture)
	: TransactionTestBase<Npgsql10DbFactoryFixture>(fixture)
{
}
