using AdoNet.Specification.Tests;

namespace SqlClientBcl.Tests
{
	public sealed class SqlClientParameterTests : ParameterTestBase<SqlClientDbFactoryFixture>
	{
		public SqlClientParameterTests(SqlClientDbFactoryFixture fixture)
			: base(fixture)
		{
		}
	}
}
