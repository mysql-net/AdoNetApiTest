using AdoNet.Specification.Tests;

namespace Npgsql3.Tests
{
	public class Npgsql3GetValueConversionTests : GetValueConversionTestBase<Npgsql3SelectValueFixture>
	{
		public Npgsql3GetValueConversionTests(Npgsql3SelectValueFixture fixture)
			: base(fixture)
		{
		}
	}
}
