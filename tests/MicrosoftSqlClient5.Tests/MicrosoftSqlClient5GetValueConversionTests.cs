using System;
using AdoNet.Specification.Tests;

namespace MicrosoftSqlClient5.Tests
{
	public sealed class MicrosoftSqlClient5GetValueConversionTests : GetValueConversionTestBase<MicrosoftSqlClient5SelectValueFixture>
	{
		public MicrosoftSqlClient5GetValueConversionTests(MicrosoftSqlClient5SelectValueFixture fixture)
			: base(fixture)
		{
		}
	}
}
