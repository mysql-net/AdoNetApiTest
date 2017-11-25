using AdoNet.Specification.Tests;

namespace Npgsql.Tests
{
	public sealed class NpgsqlParameterTests : ParameterTestBase<NpgsqlDbFactoryFixture>
	{
		public NpgsqlParameterTests(NpgsqlDbFactoryFixture fixture)
			: base(fixture)
		{
		}
	}
}
