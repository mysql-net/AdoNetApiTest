using System;
using AdoNet.Specification.Tests;

namespace MicrosoftSqlClient.Tests
{
	public sealed class MicrosoftSqlClientGetValueConversionTests : GetValueConversionTestBase<MicrosoftSqlClientSelectValueFixture>
	{
		public MicrosoftSqlClientGetValueConversionTests(MicrosoftSqlClientSelectValueFixture fixture)
			: base(fixture)
		{
		}
	}
}
