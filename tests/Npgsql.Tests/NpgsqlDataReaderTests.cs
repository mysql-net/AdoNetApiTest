using AdoNet.Specification.Tests;

namespace Npgsql.Tests
{
	public sealed class NpgsqlDataReaderTests : DataReaderTestBase<NpgsqlSelectValueFixture>
	{
		public NpgsqlDataReaderTests(NpgsqlSelectValueFixture fixture)
			: base(fixture)
		{
		}
	}
}
