using AdoNet.Specification.Tests;

namespace MicrosoftSqlite7.Tests;

public sealed class MicrosoftSqlite7ParameterTests : ParameterTestBase<MicrosoftSqlite7DbFactoryFixture>
{
	public MicrosoftSqlite7ParameterTests(MicrosoftSqlite7DbFactoryFixture fixture)
		: base(fixture)
	{
	}
}
