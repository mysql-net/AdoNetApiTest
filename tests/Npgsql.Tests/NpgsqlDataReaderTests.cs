using AdoNet.Specification.Tests;

namespace Npgsql.Tests
{
	public sealed class NpgsqlDataReaderTests : DataReaderTestBase<NpgsqlGetValueFixture>
	{
		public NpgsqlDataReaderTests(NpgsqlGetValueFixture fixture)
			: base(fixture)
		{
		}
	}
}
