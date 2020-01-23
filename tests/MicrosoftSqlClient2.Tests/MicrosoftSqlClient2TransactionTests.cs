using AdoNet.Specification.Tests;

namespace MicrosoftSqlClient2.Tests
{
	public sealed class MicrosoftSqlClient2TransactionTests : TransactionTestBase<MicrosoftSqlClient2DbFactoryFixture>
	{
		public MicrosoftSqlClient2TransactionTests(MicrosoftSqlClient2DbFactoryFixture fixture)
			: base(fixture)
		{
		}
	}
}
