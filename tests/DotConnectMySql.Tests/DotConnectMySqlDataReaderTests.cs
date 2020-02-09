using AdoNet.Specification.Tests;
using Xunit;

namespace DotConnectMySql.Tests
{
	public sealed class DotConnectMySqlDataReaderTests : DataReaderTestBase<DotConnectMySqlSelectValueFixture>
	{
		public DotConnectMySqlDataReaderTests(DotConnectMySqlSelectValueFixture fixture)
			: base(fixture)
		{
		}

		[Fact(Skip = "GetColumSchema is not supported")]
		public override void GetColumnSchema_is_empty_after_Delete() { }

		[Fact(Skip = "GetColumSchema is not supported")]
		public override void GetColumnSchema_ColumnName() { }

		[Fact(Skip = "GetColumSchema is not supported")]
		public override void GetColumnSchema_DataTypeName() { }

		[Fact(Skip = "GetColumSchema is not supported")]
		public override void GetColumnSchema_DataType() { }
	}
}
