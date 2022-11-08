namespace Npgsql7.Tests;

public sealed class Npgsql7DataReaderTests : DataReaderTestBase<Npgsql7SelectValueFixture>
{
	public Npgsql7DataReaderTests(Npgsql7SelectValueFixture fixture)
		: base(fixture)
	{
	}

	[Fact(Skip = "Deliberately throws InvalidCastException")]
	public override void GetTextReader_returns_empty_for_null_String() { }
}
