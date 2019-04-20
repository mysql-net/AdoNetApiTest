using AdoNet.Specification.Tests;
using Xunit;

namespace MySqlConnector.Tests
{
	public sealed class MySqlConnectorDataReaderTests : DataReaderTestBase<MySqlConnectorSelectValueFixture>
	{
		public MySqlConnectorDataReaderTests(MySqlConnectorSelectValueFixture fixture)
			: base(fixture)
		{
		}

		[Fact(Skip = "Deliberately throws InvalidCastException")]
		public override void GetTextReader_returns_empty_for_null_String() { }
	}
}
