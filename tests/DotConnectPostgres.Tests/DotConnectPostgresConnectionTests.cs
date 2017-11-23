using AdoNet.Specification.Tests;

namespace DotConnectPostgres.Tests
{
	public sealed class DotConnectPostgresConnectionTests : ConnectionTestBase<DotConnectPostgresDbFactoryFixture>
	{
		public DotConnectPostgresConnectionTests(DotConnectPostgresDbFactoryFixture fixture)
			: base(fixture)
		{
		}
	}
}
