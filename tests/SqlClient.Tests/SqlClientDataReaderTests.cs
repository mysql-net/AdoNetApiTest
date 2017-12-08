using AdoNet.Specification.Tests;

namespace SqlClient.Tests
{
	public sealed class SqlClientDataReaderTests : DataReaderTestBase<SqlClientSelectValueFixture>
	{
		public SqlClientDataReaderTests(SqlClientSelectValueFixture fixture)
			: base(fixture)
		{
		}
	}
}
