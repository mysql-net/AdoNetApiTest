using AdoNet.Specification.Tests;
using Xunit;

namespace MicrosoftSqlite.Tests;

public sealed class MicrosoftSqliteParameterTests : ParameterTestBase<MicrosoftSqliteDbFactoryFixture>
{
	public MicrosoftSqliteParameterTests(MicrosoftSqliteDbFactoryFixture fixture)
		: base(fixture)
	{
	}

	[Fact(Skip = "Unordered parameters are not supported")]
	public override void ParameterName_can_be_set_to_null() => base.ParameterName_can_be_set_to_null();
}
