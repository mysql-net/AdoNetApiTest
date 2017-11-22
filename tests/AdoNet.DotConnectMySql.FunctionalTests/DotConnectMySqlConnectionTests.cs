using AdoNet.Specification.Tests;

namespace AdoNet.DotConnectMySql.FunctionalTests
{
	public sealed class DotConnectMySqlConnectionTests : ConnectionTestBase<DotConnectMySqlDbFactoryFixture>
	{
		public DotConnectMySqlConnectionTests(DotConnectMySqlDbFactoryFixture fixture)
			: base(fixture)
		{
		}
	}
}
