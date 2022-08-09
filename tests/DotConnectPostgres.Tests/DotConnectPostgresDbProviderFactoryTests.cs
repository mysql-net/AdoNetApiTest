using AdoNet.Specification.Tests;

namespace DotConnectPostgres.Tests;

public sealed class DotConnectPostgresDbProviderFactoryTests : DbProviderFactoryTestBase<DotConnectPostgresDbFactoryFixture>
{
	public DotConnectPostgresDbProviderFactoryTests(DotConnectPostgresDbFactoryFixture fixture)
		: base(fixture)
	{
	}
}
