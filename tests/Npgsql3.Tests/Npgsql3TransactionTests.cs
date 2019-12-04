using AdoNet.Specification.Tests;

namespace Npgsql3.Tests
{
	public sealed class Npgsql3TransactionTests : TransactionTestBase<Npgsql3DbFactoryFixture>
	{
		public Npgsql3TransactionTests(Npgsql3DbFactoryFixture fixture)
			: base(fixture)
		{
		}
	}
}
