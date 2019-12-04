using AdoNet.Specification.Tests;

namespace MicrosoftSqlite22.Tests
{
	public sealed class MicrosoftSqlite22TransactionTests : TransactionTestBase<MicrosoftSqlite22DbFactoryFixture>
	{
		public MicrosoftSqlite22TransactionTests(MicrosoftSqlite22DbFactoryFixture fixture)
			: base(fixture)
		{
		}
	}
}
