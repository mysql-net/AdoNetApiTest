using AdoNet.Specification.Tests;

namespace Sqlite2.Tests;

public sealed class Sqlite2DbProviderFactoryTests : DbProviderFactoryTestBase<Sqlite2DbFactoryFixture>
{
	public Sqlite2DbProviderFactoryTests(Sqlite2DbFactoryFixture fixture)
		: base(fixture)
	{
	}
}
