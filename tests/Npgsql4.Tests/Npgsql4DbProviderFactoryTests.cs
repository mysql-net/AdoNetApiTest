using AdoNet.Specification.Tests;

namespace Npgsql4.Tests;

public sealed class Npgsql4DbProviderFactoryTests : DbProviderFactoryTestBase<Npgsql4DbFactoryFixture>
{
	public Npgsql4DbProviderFactoryTests(Npgsql4DbFactoryFixture fixture)
		: base(fixture)
	{
	}
}
