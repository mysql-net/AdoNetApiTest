using AdoNet.Specification.Tests;

namespace Npgsql4.Tests;

public sealed class Npgsql4ConnectionStringBuilderTests : ConnectionStringTestBase<Npgsql4DbFactoryFixture>
{
	public Npgsql4ConnectionStringBuilderTests(Npgsql4DbFactoryFixture fixture)
		: base(fixture)
	{
	}
}
