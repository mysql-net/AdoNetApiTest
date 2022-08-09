using System;
using System.Data;
using AdoNet.Specification.Tests;

namespace DotConnectMySql.Tests;

public class DotConnectMySqlGetValueConversionTests : GetValueConversionTestBase<DotConnectMySqlSelectValueFixture>
{
	public DotConnectMySqlGetValueConversionTests(DotConnectMySqlSelectValueFixture fixture)
		: base(fixture)
	{
	}

	public override void GetDateTime_for_minimum_Date() => TestGetValue(DbType.Date, ValueKind.Minimum, x => x.GetDateTime(0), new DateTime(1000, 1, 1));
	public override void GetDateTime_for_minimum_DateTime() => TestGetValue(DbType.Date, ValueKind.Minimum, x => x.GetDateTime(0), new DateTime(1000, 1, 1));
}
