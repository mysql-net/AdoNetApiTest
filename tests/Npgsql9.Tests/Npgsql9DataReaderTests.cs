namespace Npgsql9.Tests;

public sealed class Npgsql9DataReaderTests(Npgsql9SelectValueFixture fixture)
	: DataReaderTestBase<Npgsql9SelectValueFixture>(fixture)
{
	[Fact(Skip = "Deliberately throws InvalidCastException")]
	public override void GetTextReader_returns_empty_for_null_String() { }
}
