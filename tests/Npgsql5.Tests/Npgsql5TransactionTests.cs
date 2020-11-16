using AdoNet.Specification.Tests;

namespace Npgsql5.Tests
{
	public sealed class Npgsql5TransactionTests : TransactionTestBase<Npgsql5DbFactoryFixture>
	{
		public Npgsql5TransactionTests(Npgsql5DbFactoryFixture fixture)
			: base(fixture)
		{
		}
	}
}
