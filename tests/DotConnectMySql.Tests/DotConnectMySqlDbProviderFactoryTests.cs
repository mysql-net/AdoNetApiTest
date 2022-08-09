using AdoNet.Specification.Tests;

namespace DotConnectMySql.Tests;

public sealed class DotConnectMySqlDbProviderFactoryTests : DbProviderFactoryTestBase<DotConnectMySqlDbFactoryFixture>
{
	public DotConnectMySqlDbProviderFactoryTests(DotConnectMySqlDbFactoryFixture fixture)
		: base(fixture)
	{
	}
}
