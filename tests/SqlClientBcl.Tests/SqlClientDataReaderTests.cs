using AdoNet.Specification.Tests;
using Xunit;

namespace SqlClientBcl.Tests;

public sealed class SqlClientDataReaderTests : DataReaderTestBase<SqlClientSelectValueFixture>
{
	public SqlClientDataReaderTests(SqlClientSelectValueFixture fixture)
		: base(fixture)
	{
	}

	[Fact(Skip = "Deliberately returns empty StringReader")]
	public override void GetTextReader_throws_for_null_String() { }

	[Fact(Skip = "GetColumSchema is not supported")]
	public override void GetColumnSchema_is_empty_after_Delete() { }

	[Fact(Skip = "GetColumSchema is not supported")]
	public override void GetColumnSchema_ColumnName() { }

	[Fact(Skip = "GetColumSchema is not supported")]
	public override void GetColumnSchema_DataTypeName() { }

	[Fact(Skip = "GetColumSchema is not supported")]
	public override void GetColumnSchema_DataType() { }
}
