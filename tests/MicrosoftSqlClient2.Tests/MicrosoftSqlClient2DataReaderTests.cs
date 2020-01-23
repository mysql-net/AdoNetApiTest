using AdoNet.Specification.Tests;

namespace MicrosoftSqlClient2.Tests
{
	public sealed class MicrosoftSqlClient2DataReaderTests : DataReaderTestBase<MicrosoftSqlClient2SelectValueFixture>
	{
		public MicrosoftSqlClient2DataReaderTests(MicrosoftSqlClient2SelectValueFixture fixture)
			: base(fixture)
		{
		}
	}
}
