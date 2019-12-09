using AdoNet.Specification.Tests;

namespace DotConnectPostgres.Tests
{
	public sealed class DotConnectConnectionStringBuilderTests : ConnectionStringTestBase<DotConnectPostgresDbFactoryFixture>
	{
		public DotConnectConnectionStringBuilderTests(DotConnectPostgresDbFactoryFixture fixture)
			: base(fixture)
		{
		}
	}
}
