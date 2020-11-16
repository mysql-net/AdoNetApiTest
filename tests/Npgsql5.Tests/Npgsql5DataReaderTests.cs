using AdoNet.Specification.Tests;
using Xunit;

namespace Npgsql5.Tests
{
	public sealed class Npgsql5DataReaderTests : DataReaderTestBase<Npgsql5SelectValueFixture>
	{
		public Npgsql5DataReaderTests(Npgsql5SelectValueFixture fixture)
			: base(fixture)
		{
		}

		[Fact(Skip = "Deliberately throws InvalidCastException")]
		public override void GetTextReader_returns_empty_for_null_String() { }
	}
}
