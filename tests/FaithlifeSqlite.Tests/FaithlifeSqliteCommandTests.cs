using AdoNet.Specification.Tests;

namespace FaithlifeSqlite.Tests
{
	public sealed class FaithlifeSqliteCommandTests : CommandTestBase<FaithlifeSqliteDbFactoryFixture>
	{
		public FaithlifeSqliteCommandTests(FaithlifeSqliteDbFactoryFixture fixture)
			: base(fixture)
		{
		}
	}
}
