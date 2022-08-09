using AdoNet.Specification.Tests;

namespace Npgsql5.Tests;

public sealed class Npgsql5DbProviderFactoryTests : DbProviderFactoryTestBase<Npgsql5DbFactoryFixture>
{
	public Npgsql5DbProviderFactoryTests(Npgsql5DbFactoryFixture fixture)
		: base(fixture)
	{
	}
}
