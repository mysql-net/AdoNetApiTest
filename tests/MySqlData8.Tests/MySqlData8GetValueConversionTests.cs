using System;
using System.Data;
using AdoNet.Specification.Tests;

namespace MySqlData8.Tests;

public class MySqlData8GetValueConversionTests : GetValueConversionTestBase<MySqlData8SelectValueFixture>
{
	public MySqlData8GetValueConversionTests(MySqlData8SelectValueFixture fixture)
		: base(fixture)
	{
	}

	public override void GetDateTime_for_minimum_Date() => TestGetValue(DbType.Date, ValueKind.Minimum, x => x.GetDateTime(0), new DateTime(1000, 1, 1));
	public override void GetDateTime_for_minimum_DateTime() => TestGetValue(DbType.Date, ValueKind.Minimum, x => x.GetDateTime(0), new DateTime(1000, 1, 1));
}
