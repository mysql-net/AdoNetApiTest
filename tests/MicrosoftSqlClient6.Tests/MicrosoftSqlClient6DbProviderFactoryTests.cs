using AdoNet.Specification.Tests;
using Xunit;

namespace MicrosoftSqlClient6.Tests;

public sealed class MicrosoftSqlClient6DbProviderFactoryTests : DbProviderFactoryTestBase<MicrosoftSqlClient6DbFactoryFixture>
{
	public MicrosoftSqlClient6DbProviderFactoryTests(MicrosoftSqlClient6DbFactoryFixture fixture)
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
