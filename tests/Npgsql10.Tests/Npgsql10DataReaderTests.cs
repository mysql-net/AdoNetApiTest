namespace Npgsql10.Tests;

public sealed class Npgsql10DataReaderTests(Npgsql10SelectValueFixture fixture)
	: DataReaderTestBase<Npgsql10SelectValueFixture>(fixture)
{
	[Fact(Skip = "Deliberately throws InvalidCastException")]
	public override void GetTextReader_returns_empty_for_null_String() { }
}
