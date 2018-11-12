using AdoNet.Specification.Tests;

namespace MicrosoftSqlite21.Tests
{
	public sealed class MicrosoftSqlite21ConnectionTests : ConnectionTestBase<MicrosoftSqlite21DbFactoryFixture>
	{
		public MicrosoftSqlite21ConnectionTests(MicrosoftSqlite21DbFactoryFixture fixture)
			: base(fixture)
		{
		}
	}
}
