using AdoNet.Specification.Tests;

namespace MicrosoftSqlClient5.Tests
{
	public sealed class MicrosoftSqlClient5DataReaderTests : DataReaderTestBase<MicrosoftSqlClient5SelectValueFixture>
	{
		public MicrosoftSqlClient5DataReaderTests(MicrosoftSqlClient5SelectValueFixture fixture)
			: base(fixture)
		{
		}
	}
}
