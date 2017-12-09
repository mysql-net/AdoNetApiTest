using AdoNet.Specification.Tests;

namespace SqlClientBcl.Tests
{
	public sealed class SqlClientDataReaderTests : DataReaderTestBase<SqlClientSelectValueFixture>
	{
		public SqlClientDataReaderTests(SqlClientSelectValueFixture fixture)
			: base(fixture)
		{
		}
	}
}
