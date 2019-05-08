using AdoNet.Specification.Tests;

namespace MicrosoftSqlClient.Tests
{
	public sealed class MicrosoftSqlClientDataReaderTests : DataReaderTestBase<MicrosoftSqlClientSelectValueFixture>
	{
		public MicrosoftSqlClientDataReaderTests(MicrosoftSqlClientSelectValueFixture fixture)
			: base(fixture)
		{
		}
	}
}
