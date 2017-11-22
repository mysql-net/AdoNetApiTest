using AdoNet.Specification.Tests;

namespace AdoNet.Npgsql.FunctionalTests
{
	public sealed class NpgsqlCommandTests : CommandTestBase<NpgsqlDbFactoryFixture>
	{
		public NpgsqlCommandTests(NpgsqlDbFactoryFixture fixture)
			: base(fixture)
		{
		}
	}
}
