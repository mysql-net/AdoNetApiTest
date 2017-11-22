using AdoNet.Specification.Tests;

namespace AdoNet.SqlClient.FunctionalTests
{
	public sealed class SqlClientCommandTests : CommandTestBase<SqlClientDbFactoryFixture>
	{
		public SqlClientCommandTests(SqlClientDbFactoryFixture fixture)
			: base(fixture)
		{
		}
	}
}
