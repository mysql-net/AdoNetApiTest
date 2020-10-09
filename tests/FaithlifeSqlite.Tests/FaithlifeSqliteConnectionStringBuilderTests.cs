using AdoNet.Specification.Tests;

namespace FaithlifeSqlite.Tests
{
	public sealed class FaithlifeSqliteConnectionStringBuilderTests : ConnectionStringTestBase<FaithlifeSqliteDbFactoryFixture>
	{
		public FaithlifeSqliteConnectionStringBuilderTests(FaithlifeSqliteDbFactoryFixture fixture)
			: base(fixture)
		{
		}
	}
}
