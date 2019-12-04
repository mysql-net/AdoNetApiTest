using AdoNet.Specification.Tests;

namespace SqlClient.Tests
{
	public sealed class SqlClientConnectionStringBuilderTests : ConnectionStringTestBase<SqlClientDbFactoryFixture>
	{
		public SqlClientConnectionStringBuilderTests(SqlClientDbFactoryFixture fixture)
			: base(fixture)
		{
		}
	}
}
