using AdoNet.Specification.Tests;

namespace AdoNet.Npgsql.FunctionalTests
{
	public sealed class NpgsqlConnectionTests : ConnectionTestBase<NpgsqlDbFactoryFixture>
	{
		public NpgsqlConnectionTests(NpgsqlDbFactoryFixture fixture)
			: base(fixture)
		{
		}
	}
}
