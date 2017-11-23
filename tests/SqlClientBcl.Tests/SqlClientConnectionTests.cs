using AdoNet.Specification.Tests;

namespace SqlClientBcl.Tests
{
	public sealed class SqlClientConnectionTests : ConnectionTestBase<SqlClientDbFactoryFixture>
	{
		public SqlClientConnectionTests(SqlClientDbFactoryFixture fixture)
			: base(fixture)
		{
		}
	}
}
