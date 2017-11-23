using AdoNet.Specification.Tests;

namespace Npgsql.Tests
{
	public sealed class NpgsqlDataReaderTests : DataReaderTestBase<NpgsqlDbFactoryFixture>
	{
		public NpgsqlDataReaderTests(NpgsqlDbFactoryFixture fixture)
			: base(fixture)
		{
		}
	}
}
