using System;
using System.Data.SqlTypes;
using AdoNet.Specification.Tests;

namespace SqlClient.Tests
{
	public sealed class SqlClientGetValueConversionTests : GetValueConversionTestBase<SqlClientGetValueFixture>
	{
		public SqlClientGetValueConversionTests(SqlClientGetValueFixture fixture)
			: base(fixture)
		{
		}

		protected override Type GetNullExceptionType() => typeof(SqlNullValueException);
	}
}
