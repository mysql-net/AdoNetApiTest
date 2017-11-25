using AdoNet.Specification.Tests;

namespace DotConnectPostgres.Tests
{
	public sealed class DotConnectPostgresParameterTests : ParameterTestBase<DotConnectPostgresDbFactoryFixture>
	{
		public DotConnectPostgresParameterTests(DotConnectPostgresDbFactoryFixture fixture)
			: base(fixture)
		{
		}
	}
}
