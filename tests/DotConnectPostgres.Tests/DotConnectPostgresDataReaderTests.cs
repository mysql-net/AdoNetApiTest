using AdoNet.Specification.Tests;
using Xunit;

namespace DotConnectPostgres.Tests
{
	public sealed class DotConnectPostgresDataReaderTests : DataReaderTestBase<DotConnectPostgresSelectValueFixture>
	{
		public DotConnectPostgresDataReaderTests(DotConnectPostgresSelectValueFixture fixture)
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
