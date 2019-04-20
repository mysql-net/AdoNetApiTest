using AdoNet.Specification.Tests;
using Xunit;

namespace Npgsql4.Tests
{
	public sealed class Npgsql4DataReaderTests : DataReaderTestBase<Npgsql4SelectValueFixture>
	{
		public Npgsql4DataReaderTests(Npgsql4SelectValueFixture fixture)
			: base(fixture)
		{
		}

		[Fact(Skip = "Deliberately throws InvalidCastException")]
		public override void GetTextReader_returns_empty_for_null_String() { }
	}
}
