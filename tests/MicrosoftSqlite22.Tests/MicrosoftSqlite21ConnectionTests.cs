using AdoNet.Specification.Tests;

namespace MicrosoftSqlite22.Tests
{
	public sealed class MicrosoftSqlite22ConnectionTests : ConnectionTestBase<MicrosoftSqlite22DbFactoryFixture>
	{
		public MicrosoftSqlite22ConnectionTests(MicrosoftSqlite22DbFactoryFixture fixture)
			: base(fixture)
		{
		}
	}
}
