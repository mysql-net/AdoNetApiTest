using AdoNet.Specification.Tests;

namespace Npgsql4.Tests
{
	public sealed class Npgsql4TransactionTests : TransactionTestBase<Npgsql4DbFactoryFixture>
	{
		public Npgsql4TransactionTests(Npgsql4DbFactoryFixture fixture)
			: base(fixture)
		{
		}
	}
}
