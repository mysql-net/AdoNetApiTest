using AdoNet.Specification.Tests;

namespace Sqlite2.Tests;

public sealed class Sqlite2ConnectionTests : ConnectionTestBase<Sqlite2DbFactoryFixture>
{
	public Sqlite2ConnectionTests(Sqlite2DbFactoryFixture fixture)
		: base(fixture)
	{
	}
}
