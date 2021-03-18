using AdoNet.Specification.Tests;

namespace MicrosoftSqlClient3.Tests
{
	public sealed class MicrosoftSqlClient3ConnectionTests : ConnectionTestBase<MicrosoftSqlClient3DbFactoryFixture>
	{
		public MicrosoftSqlClient3ConnectionTests(MicrosoftSqlClient3DbFactoryFixture fixture)
			: base(fixture)
		{
		}
	}
}
