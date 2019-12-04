using AdoNet.Specification.Tests;

namespace DotConnectPostgres.Tests
{
	public sealed class DotConnectConnectionStringBuilderTests : ConnectionStringTestBase<DotConnectPostgresDbFactoryFixture>
	{
		public DotConnectConnectionStringBuilderTests(DotConnectPostgresSelectValueFixture fixture)
			: base(fixture)
		{
		}
	}
}
