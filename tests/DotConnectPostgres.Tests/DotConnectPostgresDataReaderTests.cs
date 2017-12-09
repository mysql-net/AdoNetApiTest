using AdoNet.Specification.Tests;

namespace DotConnectPostgres.Tests
{
	public sealed class DotConnectPostgresDataReaderTests : DataReaderTestBase<DotConnectPostgresSelectValueFixture>
	{
		public DotConnectPostgresDataReaderTests(DotConnectPostgresSelectValueFixture fixture)
			: base(fixture)
		{
		}
	}
}
