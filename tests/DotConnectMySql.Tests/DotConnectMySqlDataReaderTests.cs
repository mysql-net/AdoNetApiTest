using AdoNet.Specification.Tests;

namespace DotConnectMySql.Tests
{
	public sealed class DotConnectMySqlDataReaderTests : DataReaderTestBase<DotConnectMySqlDbFactoryFixture>
	{
		public DotConnectMySqlDataReaderTests(DotConnectMySqlDbFactoryFixture fixture)
			: base(fixture)
		{
		}
	}
}
