using AdoNet.Specification.Tests;

namespace MicrosoftSqlClient4.Tests
{
	public sealed class MicrosoftSqlClient4TransactionTests : TransactionTestBase<MicrosoftSqlClient4DbFactoryFixture>
	{
		public MicrosoftSqlClient4TransactionTests(MicrosoftSqlClient4DbFactoryFixture fixture)
			: base(fixture)
		{
		}
	}
}
