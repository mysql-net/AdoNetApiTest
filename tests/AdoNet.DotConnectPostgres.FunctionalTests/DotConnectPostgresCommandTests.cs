using AdoNet.Specification.Tests;

namespace AdoNet.DotConnectPostgres.FunctionalTests
{
	public sealed class DotConnectPostgresCommandTests : CommandTestBase<DotConnectPostgresDbFactoryFixture>
	{
		public DotConnectPostgresCommandTests(DotConnectPostgresDbFactoryFixture fixture)
			: base(fixture)
		{
		}
	}
}
