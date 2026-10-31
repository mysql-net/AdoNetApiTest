using AdoNet.Specification.Tests;

namespace Sqlite2.Tests;

public sealed class Sqlite2ParameterTests : ParameterTestBase<Sqlite2DbFactoryFixture>
{
	public Sqlite2ParameterTests(Sqlite2DbFactoryFixture fixture)
		: base(fixture)
	{
	}
}
