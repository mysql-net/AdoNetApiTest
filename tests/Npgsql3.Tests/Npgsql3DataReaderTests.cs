using AdoNet.Specification.Tests;
using Xunit;

namespace Npgsql3.Tests
{
	public sealed class Npgsql3DataReaderTests : DataReaderTestBase<Npgsql3SelectValueFixture>
	{
		public Npgsql3DataReaderTests(Npgsql3SelectValueFixture fixture)
			: base(fixture)
		{
		}

		[Fact(Skip = "Deliberately throws InvalidCastException")]
		public override void GetTextReader_returns_empty_for_null_String() { }
	}
}
