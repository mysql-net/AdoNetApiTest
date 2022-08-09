using System;
using AdoNet.Specification.Tests;

namespace MicrosoftSqlClient3.Tests;

public sealed class MicrosoftSqlClient3GetValueConversionTests : GetValueConversionTestBase<MicrosoftSqlClient3SelectValueFixture>
{
	public MicrosoftSqlClient3GetValueConversionTests(MicrosoftSqlClient3SelectValueFixture fixture)
		: base(fixture)
	{
	}
}
