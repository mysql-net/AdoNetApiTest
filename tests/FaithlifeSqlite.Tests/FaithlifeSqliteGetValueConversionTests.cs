using AdoNet.Specification.Tests;

namespace FaithlifeSqlite.Tests
{
	public sealed class FaithlifeSqliteGetValueConversionTests : GetValueConversionTestBase<FaithlifeSqliteSelectValueFixture>
	{
		public FaithlifeSqliteGetValueConversionTests(FaithlifeSqliteSelectValueFixture fixture)
			: base(fixture)
		{
		}
	}
}
