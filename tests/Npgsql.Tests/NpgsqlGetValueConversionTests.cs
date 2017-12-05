using AdoNet.Specification.Tests;

namespace Npgsql.Tests
{
	public class NpgsqlGetValueConversionTests : GetValueConversionTestBase<NpgsqlGetValueFixture>
	{
		public NpgsqlGetValueConversionTests(NpgsqlGetValueFixture fixture)
			: base(fixture)
		{
		}
	}
}
