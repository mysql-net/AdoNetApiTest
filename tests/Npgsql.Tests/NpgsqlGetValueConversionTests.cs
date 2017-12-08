using AdoNet.Specification.Tests;

namespace Npgsql.Tests
{
	public class NpgsqlGetValueConversionTests : GetValueConversionTestBase<NpgsqlSelectValueFixture>
	{
		public NpgsqlGetValueConversionTests(NpgsqlSelectValueFixture fixture)
			: base(fixture)
		{
		}
	}
}
