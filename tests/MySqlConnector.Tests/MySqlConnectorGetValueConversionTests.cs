using System;
using System.Data;
using AdoNet.Specification.Tests;

namespace MySqlConnector.Tests
{
	public sealed class MySqlConnectorGetValueConversionTests : GetValueConversionTestBase<MySqlConnectorSelectValueFixture>
	{
		public MySqlConnectorGetValueConversionTests(MySqlConnectorSelectValueFixture fixture)
			: base(fixture)
		{
		}

		// the minimum date permitted by MySQL is 1000-01-01; override the minimum value for DateTime tests
		public override void GetDateTime_for_minimum_Date() => TestGetValue(DbType.Date, ValueKind.Minimum, x => x.GetDateTime(0), new DateTime(1000, 1, 1));
		public override void GetDateTime_for_minimum_Date_with_GetFieldValue() => TestGetValue(DbType.Date, ValueKind.Minimum, x => x.GetDateTime(0), new DateTime(1000, 1, 1));
		public override void GetDateTime_for_minimum_DateTime() => TestGetValue(DbType.Date, ValueKind.Minimum, x => x.GetDateTime(0), new DateTime(1000, 1, 1));
		public override void GetDateTime_for_minimum_DateTime_with_GetFieldValue() => TestGetValue(DbType.Date, ValueKind.Minimum, x => x.GetDateTime(0), new DateTime(1000, 1, 1));
	}
}
