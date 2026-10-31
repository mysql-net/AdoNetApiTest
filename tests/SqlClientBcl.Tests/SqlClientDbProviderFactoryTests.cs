using AdoNet.Specification.Tests;
using Xunit;

namespace SqlClientBcl.Tests;

public sealed class SqlClientDbProviderFactoryTests : DbProviderFactoryTestBase<SqlClientDbFactoryFixture>
{
	public SqlClientDbProviderFactoryTests(SqlClientDbFactoryFixture fixture)
		: base(fixture)
	{
	}

	public override void DbProviderFactory_CanCreateDataSourceEnumerator_is_false()
	{
		Assert.SkipWhen(Fixture.Factory.CanCreateDataSourceEnumerator, "Supports SqlDataSourceEnumerator");
		base.DbProviderFactory_CanCreateDataSourceEnumerator_is_false();
	}

	public override void DbProviderFactory_CreateDataSourceEnumerator_is_null()
	{
		Assert.SkipWhen(Fixture.Factory.CanCreateDataSourceEnumerator, "Supports SqlDataSourceEnumerator");
		base.DbProviderFactory_CreateDataSourceEnumerator_is_null();
	}
}
