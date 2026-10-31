using AdoNet.Specification.Tests;

namespace Sqlite2.Tests;

public sealed class Sqlite2DataReaderTests : DataReaderTestBase<Sqlite2SelectValueFixture>
{
	public Sqlite2DataReaderTests(Sqlite2SelectValueFixture fixture)
		: base(fixture)
	{
	}
}
