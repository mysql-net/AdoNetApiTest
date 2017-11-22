using AdoNet.Specification.Tests;

namespace AdoNet.DotConnectPostgres.FunctionalTests
{
	public sealed class DotConnectPostgresConnectionTests : ConnectionTestBase<DotConnectPostgresDbFactoryFixture>
	{
		public DotConnectPostgresConnectionTests(DotConnectPostgresDbFactoryFixture fixture)
			: base(fixture)
		{
		}
	}
}
