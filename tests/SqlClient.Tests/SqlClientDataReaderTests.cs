using AdoNet.Specification.Tests;

namespace SqlClient.Tests
{
	public sealed class SqlClientDataReaderTests : DataReaderTestBase<SqlClientGetValueFixture>
	{
		public SqlClientDataReaderTests(SqlClientGetValueFixture fixture)
			: base(fixture)
		{
		}
	}
}
