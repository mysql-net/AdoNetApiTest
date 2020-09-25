using AdoNet.Specification.Tests;

namespace MicrosoftSqlite5.Tests
{
	public sealed class MicrosoftSqlite5ConnectionTests : ConnectionTestBase<MicrosoftSqlite5DbFactoryFixture>
	{
		public MicrosoftSqlite5ConnectionTests(MicrosoftSqlite5DbFactoryFixture fixture)
			: base(fixture)
		{
		}
	}
}
