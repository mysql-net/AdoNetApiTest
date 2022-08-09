using AdoNet.Specification.Tests;

namespace SqlClientBcl.Tests;

public sealed class SqlClientCommandTests : CommandTestBase<SqlClientDbFactoryFixture>
{
	public SqlClientCommandTests(SqlClientDbFactoryFixture fixture)
		: base(fixture)
	{
	}
}
