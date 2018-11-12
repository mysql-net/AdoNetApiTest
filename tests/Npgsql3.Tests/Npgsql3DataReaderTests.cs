using AdoNet.Specification.Tests;

namespace Npgsql3.Tests
{
	public sealed class Npgsql3DataReaderTests : DataReaderTestBase<Npgsql3SelectValueFixture>
	{
		public Npgsql3DataReaderTests(Npgsql3SelectValueFixture fixture)
			: base(fixture)
		{
		}
	}
}
