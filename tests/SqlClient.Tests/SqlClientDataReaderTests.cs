using AdoNet.Specification.Tests;
using Xunit;

namespace SqlClient.Tests
{
	public sealed class SqlClientDataReaderTests : DataReaderTestBase<SqlClientSelectValueFixture>
	{
		public SqlClientDataReaderTests(SqlClientSelectValueFixture fixture)
			: base(fixture)
		{
		}

		[Fact(Skip = "Deliberately returns empty StringReader")]
		public override void GetTextReader_throws_for_null_String() { }
	}
}
