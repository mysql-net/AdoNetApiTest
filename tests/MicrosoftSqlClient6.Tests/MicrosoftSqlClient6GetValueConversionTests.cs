using System;
using AdoNet.Specification.Tests;

namespace MicrosoftSqlClient6.Tests;

public sealed class MicrosoftSqlClient6GetValueConversionTests : GetValueConversionTestBase<MicrosoftSqlClient6SelectValueFixture>
{
	public MicrosoftSqlClient6GetValueConversionTests(MicrosoftSqlClient6SelectValueFixture fixture)
		: base(fixture)
	{
	}
}
