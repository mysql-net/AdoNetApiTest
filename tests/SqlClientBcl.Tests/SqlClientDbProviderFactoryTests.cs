using AdoNet.Specification.Tests;

namespace SqlClientBcl.Tests
{
	public sealed class SqlClientDbProviderFactoryTests : DbProviderFactoryTestBase<SqlClientDbFactoryFixture>
	{
		public SqlClientDbProviderFactoryTests(SqlClientDbFactoryFixture fixture)
			: base(fixture)
		{
		}
	}
}
