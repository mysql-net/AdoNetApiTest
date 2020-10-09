using AdoNet.Specification.Tests;

namespace FaithlifeSqlite.Tests
{
	public sealed class FaithlifeSqliteConnectionTests : ConnectionTestBase<FaithlifeSqliteDbFactoryFixture>
	{
		public FaithlifeSqliteConnectionTests(FaithlifeSqliteDbFactoryFixture fixture)
			: base(fixture)
		{
		}
	}
}
