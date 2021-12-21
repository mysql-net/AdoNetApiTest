using AdoNet.Specification.Tests;

namespace MicrosoftSqlClient4.Tests
{
	public sealed class MicrosoftSqlClient4DataReaderTests : DataReaderTestBase<MicrosoftSqlClient4SelectValueFixture>
	{
		public MicrosoftSqlClient4DataReaderTests(MicrosoftSqlClient4SelectValueFixture fixture)
			: base(fixture)
		{
		}
	}
}
