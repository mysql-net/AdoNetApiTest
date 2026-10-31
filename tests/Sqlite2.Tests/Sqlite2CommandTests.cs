using AdoNet.Specification.Tests;

namespace Sqlite2.Tests;

public sealed class Sqlite2CommandTests : CommandTestBase<Sqlite2DbFactoryFixture>
{
	public Sqlite2CommandTests(Sqlite2DbFactoryFixture fixture)
		: base(fixture)
	{
	}
}
