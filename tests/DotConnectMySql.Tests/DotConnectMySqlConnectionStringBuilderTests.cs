using AdoNet.Specification.Tests;

namespace DotConnectMySql.Tests
{
	public sealed class DotConnectConnectionStringBuilderTests : ConnectionStringTestBase<DotConnectMySqlDbFactoryFixture>
	{
		public DotConnectConnectionStringBuilderTests(DotConnectMySqlDbFactoryFixture fixture)
			: base(fixture)
		{
		}
	}
}
