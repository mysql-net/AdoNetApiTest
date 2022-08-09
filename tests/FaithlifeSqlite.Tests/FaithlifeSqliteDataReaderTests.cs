using AdoNet.Specification.Tests;

namespace FaithlifeSqlite.Tests;

public sealed class FaithlifeSqliteDataReaderTests : DataReaderTestBase<FaithlifeSqliteSelectValueFixture>
{
	public FaithlifeSqliteDataReaderTests(FaithlifeSqliteSelectValueFixture fixture)
		: base(fixture)
	{
	}
}
