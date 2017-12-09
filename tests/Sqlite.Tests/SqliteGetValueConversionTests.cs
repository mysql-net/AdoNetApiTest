using AdoNet.Specification.Tests;

namespace Sqlite.Tests
{
	public class SqliteGetValueConversionTests : GetValueConversionTestBase<SqliteSelectValueFixture>
	{
		public SqliteGetValueConversionTests(SqliteSelectValueFixture fixture)
			: base(fixture)
		{
		}
	}
}
