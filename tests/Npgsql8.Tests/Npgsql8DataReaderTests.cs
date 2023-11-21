namespace Npgsql8.Tests;

public sealed class Npgsql8DataReaderTests(Npgsql8SelectValueFixture fixture)
	: DataReaderTestBase<Npgsql8SelectValueFixture>(fixture)
{
	[Fact(Skip = "Deliberately throws InvalidCastException")]
	public override void GetTextReader_returns_empty_for_null_String() { }
}
