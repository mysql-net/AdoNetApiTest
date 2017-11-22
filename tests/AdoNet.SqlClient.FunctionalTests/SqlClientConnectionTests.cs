using AdoNet.Specification.Tests;

namespace AdoNet.SqlClient.FunctionalTests
{
	public sealed class SqlClientConnectionTests : ConnectionTestBase<SqlClientDbFactoryFixture>
	{
		public SqlClientConnectionTests(SqlClientDbFactoryFixture fixture)
			: base(fixture)
		{
		}
	}
}
