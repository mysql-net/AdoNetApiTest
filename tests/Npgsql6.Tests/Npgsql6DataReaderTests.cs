namespace Npgsql6.Tests;

public sealed class Npgsql6DataReaderTests : DataReaderTestBase<Npgsql6SelectValueFixture>
{
	public Npgsql6DataReaderTests(Npgsql6SelectValueFixture fixture)
		: base(fixture)
	{
	}

	[Fact(Skip = "Deliberately throws InvalidCastException")]
	public override void GetTextReader_returns_empty_for_null_String() { }
}
