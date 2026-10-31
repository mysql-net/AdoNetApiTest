using AdoNet.Specification.Tests;
using Xunit;

namespace MicrosoftSqlClient7.Tests;

public sealed class MicrosoftSqlClient7DbProviderFactoryTests : DbProviderFactoryTestBase<MicrosoftSqlClient7DbFactoryFixture>
{
	public MicrosoftSqlClient7DbProviderFactoryTests(MicrosoftSqlClient7DbFactoryFixture fixture)
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
