using AdoNet.Specification.Tests;

namespace Npgsql4.Tests
{
	public sealed class Npgsql4DataReaderTests : DataReaderTestBase<Npgsql4SelectValueFixture>
	{
		public Npgsql4DataReaderTests(Npgsql4SelectValueFixture fixture)
			: base(fixture)
		{
		}
	}
}
