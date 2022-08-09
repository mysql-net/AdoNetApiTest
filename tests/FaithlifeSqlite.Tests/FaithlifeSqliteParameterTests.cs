using AdoNet.Specification.Tests;

namespace FaithlifeSqlite.Tests;

public sealed class FaithlifeSqliteParameterTests : ParameterTestBase<FaithlifeSqliteDbFactoryFixture>
{
	public FaithlifeSqliteParameterTests(FaithlifeSqliteDbFactoryFixture fixture)
		: base(fixture)
	{
	}
}
