using AdoNet.Specification.Tests;

namespace Npgsql.Tests
{
	public sealed class NpgsqlConnectionTests : ConnectionTestBase<NpgsqlDbFactoryFixture>
	{
		public NpgsqlConnectionTests(NpgsqlDbFactoryFixture fixture)
			: base(fixture)
		{
		}
	}
}
