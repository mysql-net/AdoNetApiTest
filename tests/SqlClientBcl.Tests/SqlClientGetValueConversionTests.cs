using System;
using System.Data.SqlTypes;
using AdoNet.Specification.Tests;

namespace SqlClientBcl.Tests
{
	public sealed class SqlClientGetValueConversionTests : GetValueConversionTestBase<SqlClientSelectValueFixture>
	{
		public SqlClientGetValueConversionTests(SqlClientSelectValueFixture fixture)
			: base(fixture)
		{
		}

		protected override Type GetNullExceptionType() => typeof(SqlNullValueException);
	}
}
