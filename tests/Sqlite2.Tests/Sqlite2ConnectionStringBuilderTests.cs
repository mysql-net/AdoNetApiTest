using AdoNet.Specification.Tests;

namespace Sqlite2.Tests;

public sealed class Sqlite2ConnectionStringBuilderTests : ConnectionStringTestBase<Sqlite2DbFactoryFixture>
{
	public Sqlite2ConnectionStringBuilderTests(Sqlite2DbFactoryFixture fixture)
		: base(fixture)
	{
	}
}
