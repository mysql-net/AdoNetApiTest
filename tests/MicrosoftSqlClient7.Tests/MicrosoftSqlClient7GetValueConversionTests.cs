using System;
using AdoNet.Specification.Tests;

namespace MicrosoftSqlClient7.Tests;

public sealed class MicrosoftSqlClient7GetValueConversionTests : GetValueConversionTestBase<MicrosoftSqlClient7SelectValueFixture>
{
	public MicrosoftSqlClient7GetValueConversionTests(MicrosoftSqlClient7SelectValueFixture fixture)
		: base(fixture)
	{
	}
}
