using AdoNet.Specification.Tests;

namespace SqlClient.Tests
{
	public sealed class SqlClientCommandTests : CommandTestBase<SqlClientDbFactoryFixture>
	{
		public SqlClientCommandTests(SqlClientDbFactoryFixture fixture)
			: base(fixture)
		{
		}
	}
}
