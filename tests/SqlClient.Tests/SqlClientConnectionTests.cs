using AdoNet.Specification.Tests;

namespace SqlClient.Tests
{
	public sealed class SqlClientConnectionTests : ConnectionTestBase<SqlClientDbFactoryFixture>
	{
		public SqlClientConnectionTests(SqlClientDbFactoryFixture fixture)
			: base(fixture)
		{
		}
	}
}
