using AdoNet.Specification.Tests;

namespace MicrosoftSqlClient5.Tests
{
	public sealed class MicrosoftSqlClient5ConnectionTests : ConnectionTestBase<MicrosoftSqlClient5DbFactoryFixture>
	{
		public MicrosoftSqlClient5ConnectionTests(MicrosoftSqlClient5DbFactoryFixture fixture)
			: base(fixture)
		{
		}
	}
}
