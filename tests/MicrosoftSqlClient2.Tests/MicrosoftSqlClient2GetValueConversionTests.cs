using System;
using AdoNet.Specification.Tests;

namespace MicrosoftSqlClient2.Tests
{
	public sealed class MicrosoftSqlClient2GetValueConversionTests : GetValueConversionTestBase<MicrosoftSqlClient2SelectValueFixture>
	{
		public MicrosoftSqlClient2GetValueConversionTests(MicrosoftSqlClient2SelectValueFixture fixture)
			: base(fixture)
		{
		}
	}
}
