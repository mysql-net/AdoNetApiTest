using AdoNet.Specification.Tests;

namespace SqlClient.Tests
{
	public sealed class SqlClientDataReaderTests : DataReaderTestBase<SqlClientDbFactoryFixture>
	{
		public SqlClientDataReaderTests(SqlClientDbFactoryFixture fixture)
			: base(fixture)
		{
		}
	}
}
