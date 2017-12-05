using System;
using System.CodeDom.Compiler;
using System.Data;

namespace AdoNet.Specification.Tests
{
	[GeneratedCode("https://gist.github.com/bgrainger/33c4f9d573d778c355aebfae3bcd4fc3", "1")]
	public abstract partial class GetValueConversionTestBase<TFixture>
	{
		[SkippableFact]
		public virtual void GetBoolean_throws_for_empty_Binary() => TestException(DbType.Binary, ValueKind.Empty, x => x.GetBoolean(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetBoolean_throws_for_zero_Binary() => TestException(DbType.Binary, ValueKind.Zero, x => x.GetBoolean(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetBoolean_throws_for_one_Binary() => TestException(DbType.Binary, ValueKind.One, x => x.GetBoolean(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetBoolean_throws_for_null_Boolean() => TestException(DbType.Boolean, ValueKind.Null, x => x.GetBoolean(0), GetNullExceptionType());

		[SkippableFact]
		public virtual void GetBoolean_for_zero_Boolean() => TestGetValue(DbType.Boolean, ValueKind.Zero, x => x.GetBoolean(0), false);

		[SkippableFact]
		public virtual void GetBoolean_for_one_Boolean() => TestGetValue(DbType.Boolean, ValueKind.One, x => x.GetBoolean(0), true);

		[SkippableFact]
		public virtual void GetBoolean_for_minimum_Boolean() => TestGetValue(DbType.Boolean, ValueKind.Minimum, x => x.GetBoolean(0), false);

		[SkippableFact]
		public virtual void GetBoolean_for_maximum_Boolean() => TestGetValue(DbType.Boolean, ValueKind.Maximum, x => x.GetBoolean(0), true);

		[SkippableFact]
		public virtual void GetBoolean_throws_for_zero_Byte() => TestException(DbType.Byte, ValueKind.Zero, x => x.GetBoolean(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetBoolean_throws_for_one_Byte() => TestException(DbType.Byte, ValueKind.One, x => x.GetBoolean(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetBoolean_throws_for_minimum_Byte() => TestException(DbType.Byte, ValueKind.Minimum, x => x.GetBoolean(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetBoolean_throws_for_maximum_Byte() => TestException(DbType.Byte, ValueKind.Maximum, x => x.GetBoolean(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetBoolean_throws_for_null_Currency() => TestException(DbType.Currency, ValueKind.Null, x => x.GetBoolean(0), GetNullExceptionType());

		[SkippableFact]
		public virtual void GetBoolean_throws_for_one_Date() => TestException(DbType.Date, ValueKind.One, x => x.GetBoolean(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetBoolean_throws_for_minimum_Date() => TestException(DbType.Date, ValueKind.Minimum, x => x.GetBoolean(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetBoolean_throws_for_maximum_Date() => TestException(DbType.Date, ValueKind.Maximum, x => x.GetBoolean(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetBoolean_throws_for_one_DateTime() => TestException(DbType.DateTime, ValueKind.One, x => x.GetBoolean(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetBoolean_throws_for_minimum_DateTime() => TestException(DbType.DateTime, ValueKind.Minimum, x => x.GetBoolean(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetBoolean_throws_for_maximum_DateTime() => TestException(DbType.DateTime, ValueKind.Maximum, x => x.GetBoolean(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetBoolean_throws_for_one_DateTimeOffset() => TestException(DbType.DateTimeOffset, ValueKind.One, x => x.GetBoolean(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetBoolean_throws_for_minimum_DateTimeOffset() => TestException(DbType.DateTimeOffset, ValueKind.Minimum, x => x.GetBoolean(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetBoolean_throws_for_maximum_DateTimeOffset() => TestException(DbType.DateTimeOffset, ValueKind.Maximum, x => x.GetBoolean(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetBoolean_throws_for_zero_Decimal() => TestException(DbType.Decimal, ValueKind.Zero, x => x.GetBoolean(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetBoolean_throws_for_one_Decimal() => TestException(DbType.Decimal, ValueKind.One, x => x.GetBoolean(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetBoolean_throws_for_minimum_Decimal() => TestException(DbType.Decimal, ValueKind.Minimum, x => x.GetBoolean(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetBoolean_throws_for_maximum_Decimal() => TestException(DbType.Decimal, ValueKind.Maximum, x => x.GetBoolean(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetBoolean_throws_for_zero_Time() => TestException(DbType.Time, ValueKind.Zero, x => x.GetBoolean(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetBoolean_throws_for_one_Time() => TestException(DbType.Time, ValueKind.One, x => x.GetBoolean(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetBoolean_throws_for_minimum_Time() => TestException(DbType.Time, ValueKind.Minimum, x => x.GetBoolean(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetBoolean_throws_for_maximum_Time() => TestException(DbType.Time, ValueKind.Maximum, x => x.GetBoolean(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetByte_throws_for_null_Byte() => TestException(DbType.Byte, ValueKind.Null, x => x.GetByte(0), GetNullExceptionType());

		[SkippableFact]
		public virtual void GetByte_for_zero_Byte() => TestGetValue(DbType.Byte, ValueKind.Zero, x => x.GetByte(0), (byte) 0);

		[SkippableFact]
		public virtual void GetByte_for_one_Byte() => TestGetValue(DbType.Byte, ValueKind.One, x => x.GetByte(0), (byte) 1);

		[SkippableFact]
		public virtual void GetByte_for_minimum_Byte() => TestGetValue(DbType.Byte, ValueKind.Minimum, x => x.GetByte(0), (byte) 0);

		[SkippableFact]
		public virtual void GetByte_for_maximum_Byte() => TestGetValue(DbType.Byte, ValueKind.Maximum, x => x.GetByte(0), (byte) 255);

		[SkippableFact]
		public virtual void GetByte_throws_for_null_Currency() => TestException(DbType.Currency, ValueKind.Null, x => x.GetByte(0), GetNullExceptionType());

		[SkippableFact]
		public virtual void GetChar_throws_for_null_Currency() => TestException(DbType.Currency, ValueKind.Null, x => x.GetChar(0), GetNullExceptionType());

		[SkippableFact]
		public virtual void GetDateTime_throws_for_zero_Byte() => TestException(DbType.Byte, ValueKind.Zero, x => x.GetDateTime(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetDateTime_throws_for_one_Byte() => TestException(DbType.Byte, ValueKind.One, x => x.GetDateTime(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetDateTime_throws_for_minimum_Byte() => TestException(DbType.Byte, ValueKind.Minimum, x => x.GetDateTime(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetDateTime_throws_for_maximum_Byte() => TestException(DbType.Byte, ValueKind.Maximum, x => x.GetDateTime(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetDateTime_throws_for_null_Currency() => TestException(DbType.Currency, ValueKind.Null, x => x.GetDateTime(0), GetNullExceptionType());

		[SkippableFact]
		public virtual void GetDateTime_throws_for_null_Date() => TestException(DbType.Date, ValueKind.Null, x => x.GetDateTime(0), GetNullExceptionType());

		[SkippableFact]
		public virtual void GetDateTime_for_one_Date() => TestGetValue(DbType.Date, ValueKind.One, x => x.GetDateTime(0), new DateTime(1111, 11, 11));

		[SkippableFact]
		public virtual void GetDateTime_for_minimum_Date() => TestGetValue(DbType.Date, ValueKind.Minimum, x => x.GetDateTime(0), new DateTime(1, 1, 1));

		[SkippableFact]
		public virtual void GetDateTime_for_maximum_Date() => TestGetValue(DbType.Date, ValueKind.Maximum, x => x.GetDateTime(0), new DateTime(9999, 12, 31));

		[SkippableFact]
		public virtual void GetDateTime_throws_for_null_DateTime() => TestException(DbType.DateTime, ValueKind.Null, x => x.GetDateTime(0), GetNullExceptionType());

		[SkippableFact]
		public virtual void GetDateTime_for_one_DateTime() => TestGetValue(DbType.DateTime, ValueKind.One, x => x.GetDateTime(0), new DateTime(1111, 11, 11, 11, 11, 11, 111));

		[SkippableFact]
		public virtual void GetDateTime_for_minimum_DateTime() => TestGetValue(DbType.DateTime, ValueKind.Minimum, x => x.GetDateTime(0), new DateTime(1, 1, 1));

		[SkippableFact]
		public virtual void GetDateTime_for_maximum_DateTime() => TestGetValue(DbType.DateTime, ValueKind.Maximum, x => x.GetDateTime(0), new DateTime(9999, 12, 31, 23, 59, 59, 999));

		[SkippableFact]
		public virtual void GetDateTime_throws_for_zero_Decimal() => TestException(DbType.Decimal, ValueKind.Zero, x => x.GetDateTime(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetDateTime_throws_for_one_Decimal() => TestException(DbType.Decimal, ValueKind.One, x => x.GetDateTime(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetDateTime_throws_for_minimum_Decimal() => TestException(DbType.Decimal, ValueKind.Minimum, x => x.GetDateTime(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetDateTime_throws_for_maximum_Decimal() => TestException(DbType.Decimal, ValueKind.Maximum, x => x.GetDateTime(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetDateTime_throws_for_zero_Double() => TestException(DbType.Double, ValueKind.Zero, x => x.GetDateTime(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetDateTime_throws_for_one_Double() => TestException(DbType.Double, ValueKind.One, x => x.GetDateTime(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetDateTime_throws_for_minimum_Double() => TestException(DbType.Double, ValueKind.Minimum, x => x.GetDateTime(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetDateTime_throws_for_maximum_Double() => TestException(DbType.Double, ValueKind.Maximum, x => x.GetDateTime(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetDateTime_throws_for_zero_Int16() => TestException(DbType.Int16, ValueKind.Zero, x => x.GetDateTime(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetDateTime_throws_for_one_Int16() => TestException(DbType.Int16, ValueKind.One, x => x.GetDateTime(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetDateTime_throws_for_minimum_Int16() => TestException(DbType.Int16, ValueKind.Minimum, x => x.GetDateTime(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetDateTime_throws_for_maximum_Int16() => TestException(DbType.Int16, ValueKind.Maximum, x => x.GetDateTime(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetDateTime_throws_for_zero_Int32() => TestException(DbType.Int32, ValueKind.Zero, x => x.GetDateTime(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetDateTime_throws_for_one_Int32() => TestException(DbType.Int32, ValueKind.One, x => x.GetDateTime(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetDateTime_throws_for_minimum_Int32() => TestException(DbType.Int32, ValueKind.Minimum, x => x.GetDateTime(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetDateTime_throws_for_maximum_Int32() => TestException(DbType.Int32, ValueKind.Maximum, x => x.GetDateTime(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetDateTime_throws_for_zero_Int64() => TestException(DbType.Int64, ValueKind.Zero, x => x.GetDateTime(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetDateTime_throws_for_one_Int64() => TestException(DbType.Int64, ValueKind.One, x => x.GetDateTime(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetDateTime_throws_for_minimum_Int64() => TestException(DbType.Int64, ValueKind.Minimum, x => x.GetDateTime(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetDateTime_throws_for_maximum_Int64() => TestException(DbType.Int64, ValueKind.Maximum, x => x.GetDateTime(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetDateTime_throws_for_zero_Single() => TestException(DbType.Single, ValueKind.Zero, x => x.GetDateTime(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetDateTime_throws_for_one_Single() => TestException(DbType.Single, ValueKind.One, x => x.GetDateTime(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetDateTime_throws_for_minimum_Single() => TestException(DbType.Single, ValueKind.Minimum, x => x.GetDateTime(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetDateTime_throws_for_maximum_Single() => TestException(DbType.Single, ValueKind.Maximum, x => x.GetDateTime(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetDateTime_throws_for_zero_Time() => TestException(DbType.Time, ValueKind.Zero, x => x.GetDateTime(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetDateTime_throws_for_one_Time() => TestException(DbType.Time, ValueKind.One, x => x.GetDateTime(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetDateTime_throws_for_minimum_Time() => TestException(DbType.Time, ValueKind.Minimum, x => x.GetDateTime(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetDateTime_throws_for_maximum_Time() => TestException(DbType.Time, ValueKind.Maximum, x => x.GetDateTime(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetDecimal_throws_for_null_Currency() => TestException(DbType.Currency, ValueKind.Null, x => x.GetDecimal(0), GetNullExceptionType());

		[SkippableFact]
		public virtual void GetDecimal_throws_for_null_Decimal() => TestException(DbType.Decimal, ValueKind.Null, x => x.GetDecimal(0), GetNullExceptionType());

		[SkippableFact]
		public virtual void GetDecimal_for_zero_Decimal() => TestGetValue(DbType.Decimal, ValueKind.Zero, x => x.GetDecimal(0), 0m);

		[SkippableFact]
		public virtual void GetDecimal_for_one_Decimal() => TestGetValue(DbType.Decimal, ValueKind.One, x => x.GetDecimal(0), 1m);

		[SkippableFact]
		public virtual void GetDecimal_for_minimum_Decimal() => TestGetValue(DbType.Decimal, ValueKind.Minimum, x => x.GetDecimal(0), 0.000000000000001m);

		[SkippableFact]
		public virtual void GetDecimal_for_maximum_Decimal() => TestGetValue(DbType.Decimal, ValueKind.Maximum, x => x.GetDecimal(0), 99999999999999999999.999999999999999m);

		[SkippableFact]
		public virtual void GetDouble_throws_for_null_Currency() => TestException(DbType.Currency, ValueKind.Null, x => x.GetDouble(0), GetNullExceptionType());

		[SkippableFact]
		public virtual void GetDouble_throws_for_null_Double() => TestException(DbType.Double, ValueKind.Null, x => x.GetDouble(0), GetNullExceptionType());

		[SkippableFact]
		public virtual void GetDouble_for_zero_Double() => TestGetValue(DbType.Double, ValueKind.Zero, x => x.GetDouble(0), 0.0);

		[SkippableFact]
		public virtual void GetDouble_for_one_Double() => TestGetValue(DbType.Double, ValueKind.One, x => x.GetDouble(0), 1.0);

		[SkippableFact]
		public virtual void GetDouble_for_minimum_Double() => TestGetValue(DbType.Double, ValueKind.Minimum, x => x.GetDouble(0), 2.23E-308);

		[SkippableFact]
		public virtual void GetFloat_throws_for_null_Currency() => TestException(DbType.Currency, ValueKind.Null, x => x.GetFloat(0), GetNullExceptionType());

		[SkippableFact]
		public virtual void GetFloat_throws_for_null_Single() => TestException(DbType.Single, ValueKind.Null, x => x.GetFloat(0), GetNullExceptionType());

		[SkippableFact]
		public virtual void GetFloat_for_zero_Single() => TestGetValue(DbType.Single, ValueKind.Zero, x => x.GetFloat(0), 0f);

		[SkippableFact]
		public virtual void GetFloat_for_one_Single() => TestGetValue(DbType.Single, ValueKind.One, x => x.GetFloat(0), 1f);

		[SkippableFact]
		public virtual void GetFloat_for_minimum_Single() => TestGetValue(DbType.Single, ValueKind.Minimum, x => x.GetFloat(0), 1.18E-38f);

		[SkippableFact]
		public virtual void GetGuid_throws_for_zero_Byte() => TestException(DbType.Byte, ValueKind.Zero, x => x.GetGuid(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetGuid_throws_for_one_Byte() => TestException(DbType.Byte, ValueKind.One, x => x.GetGuid(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetGuid_throws_for_minimum_Byte() => TestException(DbType.Byte, ValueKind.Minimum, x => x.GetGuid(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetGuid_throws_for_maximum_Byte() => TestException(DbType.Byte, ValueKind.Maximum, x => x.GetGuid(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetGuid_throws_for_null_Currency() => TestException(DbType.Currency, ValueKind.Null, x => x.GetGuid(0), GetNullExceptionType());

		[SkippableFact]
		public virtual void GetGuid_throws_for_one_Date() => TestException(DbType.Date, ValueKind.One, x => x.GetGuid(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetGuid_throws_for_minimum_Date() => TestException(DbType.Date, ValueKind.Minimum, x => x.GetGuid(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetGuid_throws_for_maximum_Date() => TestException(DbType.Date, ValueKind.Maximum, x => x.GetGuid(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetGuid_throws_for_one_DateTime() => TestException(DbType.DateTime, ValueKind.One, x => x.GetGuid(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetGuid_throws_for_minimum_DateTime() => TestException(DbType.DateTime, ValueKind.Minimum, x => x.GetGuid(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetGuid_throws_for_maximum_DateTime() => TestException(DbType.DateTime, ValueKind.Maximum, x => x.GetGuid(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetGuid_throws_for_one_DateTimeOffset() => TestException(DbType.DateTimeOffset, ValueKind.One, x => x.GetGuid(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetGuid_throws_for_minimum_DateTimeOffset() => TestException(DbType.DateTimeOffset, ValueKind.Minimum, x => x.GetGuid(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetGuid_throws_for_maximum_DateTimeOffset() => TestException(DbType.DateTimeOffset, ValueKind.Maximum, x => x.GetGuid(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetGuid_throws_for_zero_Decimal() => TestException(DbType.Decimal, ValueKind.Zero, x => x.GetGuid(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetGuid_throws_for_one_Decimal() => TestException(DbType.Decimal, ValueKind.One, x => x.GetGuid(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetGuid_throws_for_minimum_Decimal() => TestException(DbType.Decimal, ValueKind.Minimum, x => x.GetGuid(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetGuid_throws_for_maximum_Decimal() => TestException(DbType.Decimal, ValueKind.Maximum, x => x.GetGuid(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetGuid_throws_for_zero_Double() => TestException(DbType.Double, ValueKind.Zero, x => x.GetGuid(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetGuid_throws_for_one_Double() => TestException(DbType.Double, ValueKind.One, x => x.GetGuid(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetGuid_throws_for_minimum_Double() => TestException(DbType.Double, ValueKind.Minimum, x => x.GetGuid(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetGuid_throws_for_maximum_Double() => TestException(DbType.Double, ValueKind.Maximum, x => x.GetGuid(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetGuid_throws_for_null_Guid() => TestException(DbType.Guid, ValueKind.Null, x => x.GetGuid(0), GetNullExceptionType());

		[SkippableFact]
		public virtual void GetGuid_throws_for_zero_Int16() => TestException(DbType.Int16, ValueKind.Zero, x => x.GetGuid(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetGuid_throws_for_one_Int16() => TestException(DbType.Int16, ValueKind.One, x => x.GetGuid(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetGuid_throws_for_minimum_Int16() => TestException(DbType.Int16, ValueKind.Minimum, x => x.GetGuid(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetGuid_throws_for_maximum_Int16() => TestException(DbType.Int16, ValueKind.Maximum, x => x.GetGuid(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetGuid_throws_for_zero_Int32() => TestException(DbType.Int32, ValueKind.Zero, x => x.GetGuid(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetGuid_throws_for_one_Int32() => TestException(DbType.Int32, ValueKind.One, x => x.GetGuid(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetGuid_throws_for_minimum_Int32() => TestException(DbType.Int32, ValueKind.Minimum, x => x.GetGuid(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetGuid_throws_for_maximum_Int32() => TestException(DbType.Int32, ValueKind.Maximum, x => x.GetGuid(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetGuid_throws_for_zero_Int64() => TestException(DbType.Int64, ValueKind.Zero, x => x.GetGuid(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetGuid_throws_for_one_Int64() => TestException(DbType.Int64, ValueKind.One, x => x.GetGuid(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetGuid_throws_for_minimum_Int64() => TestException(DbType.Int64, ValueKind.Minimum, x => x.GetGuid(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetGuid_throws_for_maximum_Int64() => TestException(DbType.Int64, ValueKind.Maximum, x => x.GetGuid(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetGuid_throws_for_zero_Single() => TestException(DbType.Single, ValueKind.Zero, x => x.GetGuid(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetGuid_throws_for_one_Single() => TestException(DbType.Single, ValueKind.One, x => x.GetGuid(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetGuid_throws_for_minimum_Single() => TestException(DbType.Single, ValueKind.Minimum, x => x.GetGuid(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetGuid_throws_for_maximum_Single() => TestException(DbType.Single, ValueKind.Maximum, x => x.GetGuid(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetGuid_throws_for_zero_Time() => TestException(DbType.Time, ValueKind.Zero, x => x.GetGuid(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetGuid_throws_for_one_Time() => TestException(DbType.Time, ValueKind.One, x => x.GetGuid(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetGuid_throws_for_minimum_Time() => TestException(DbType.Time, ValueKind.Minimum, x => x.GetGuid(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetGuid_throws_for_maximum_Time() => TestException(DbType.Time, ValueKind.Maximum, x => x.GetGuid(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetInt16_throws_for_null_Currency() => TestException(DbType.Currency, ValueKind.Null, x => x.GetInt16(0), GetNullExceptionType());

		[SkippableFact]
		public virtual void GetInt16_throws_for_null_Int16() => TestException(DbType.Int16, ValueKind.Null, x => x.GetInt16(0), GetNullExceptionType());

		[SkippableFact]
		public virtual void GetInt16_for_zero_Int16() => TestGetValue(DbType.Int16, ValueKind.Zero, x => x.GetInt16(0), (short) 0);

		[SkippableFact]
		public virtual void GetInt16_for_one_Int16() => TestGetValue(DbType.Int16, ValueKind.One, x => x.GetInt16(0), (short) 1);

		[SkippableFact]
		public virtual void GetInt16_for_minimum_Int16() => TestGetValue(DbType.Int16, ValueKind.Minimum, x => x.GetInt16(0), (short) -32768);

		[SkippableFact]
		public virtual void GetInt16_for_maximum_Int16() => TestGetValue(DbType.Int16, ValueKind.Maximum, x => x.GetInt16(0), (short) 32767);

		[SkippableFact]
		public virtual void GetInt32_throws_for_null_Currency() => TestException(DbType.Currency, ValueKind.Null, x => x.GetInt32(0), GetNullExceptionType());

		[SkippableFact]
		public virtual void GetInt32_throws_for_null_Int32() => TestException(DbType.Int32, ValueKind.Null, x => x.GetInt32(0), GetNullExceptionType());

		[SkippableFact]
		public virtual void GetInt32_for_zero_Int32() => TestGetValue(DbType.Int32, ValueKind.Zero, x => x.GetInt32(0), 0);

		[SkippableFact]
		public virtual void GetInt32_for_one_Int32() => TestGetValue(DbType.Int32, ValueKind.One, x => x.GetInt32(0), 1);

		[SkippableFact]
		public virtual void GetInt32_for_minimum_Int32() => TestGetValue(DbType.Int32, ValueKind.Minimum, x => x.GetInt32(0), -2147483648);

		[SkippableFact]
		public virtual void GetInt32_for_maximum_Int32() => TestGetValue(DbType.Int32, ValueKind.Maximum, x => x.GetInt32(0), 2147483647);

		[SkippableFact]
		public virtual void GetInt32_for_zero_UInt32() => TestGetValue(DbType.UInt32, ValueKind.Zero, x => x.GetInt32(0), 0);

		[SkippableFact]
		public virtual void GetInt32_for_one_UInt32() => TestGetValue(DbType.UInt32, ValueKind.One, x => x.GetInt32(0), 1);

		[SkippableFact]
		public virtual void GetInt32_for_minimum_UInt32() => TestGetValue(DbType.UInt32, ValueKind.Minimum, x => x.GetInt32(0), 0);

		[SkippableFact]
		public virtual void GetInt32_throws_for_maximum_UInt32() => TestException(DbType.UInt32, ValueKind.Maximum, x => x.GetInt32(0), typeof(OverflowException));

		[SkippableFact]
		public virtual void GetInt64_throws_for_null_Currency() => TestException(DbType.Currency, ValueKind.Null, x => x.GetInt64(0), GetNullExceptionType());

		[SkippableFact]
		public virtual void GetInt64_throws_for_null_Int64() => TestException(DbType.Int64, ValueKind.Null, x => x.GetInt64(0), GetNullExceptionType());

		[SkippableFact]
		public virtual void GetInt64_for_zero_Int64() => TestGetValue(DbType.Int64, ValueKind.Zero, x => x.GetInt64(0), 0L);

		[SkippableFact]
		public virtual void GetInt64_for_one_Int64() => TestGetValue(DbType.Int64, ValueKind.One, x => x.GetInt64(0), 1L);

		[SkippableFact]
		public virtual void GetInt64_for_minimum_Int64() => TestGetValue(DbType.Int64, ValueKind.Minimum, x => x.GetInt64(0), -9223372036854775808L);

		[SkippableFact]
		public virtual void GetInt64_for_maximum_Int64() => TestGetValue(DbType.Int64, ValueKind.Maximum, x => x.GetInt64(0), 9223372036854775807L);

		[SkippableFact]
		public virtual void GetInt64_for_zero_UInt64() => TestGetValue(DbType.UInt64, ValueKind.Zero, x => x.GetInt64(0), 0);

		[SkippableFact]
		public virtual void GetInt64_for_one_UInt64() => TestGetValue(DbType.UInt64, ValueKind.One, x => x.GetInt64(0), 1);

		[SkippableFact]
		public virtual void GetInt64_for_minimum_UInt64() => TestGetValue(DbType.UInt64, ValueKind.Minimum, x => x.GetInt64(0), 0);

		[SkippableFact]
		public virtual void GetInt64_throws_for_maximum_UInt64() => TestException(DbType.UInt64, ValueKind.Maximum, x => x.GetInt64(0), typeof(OverflowException));

		[SkippableFact]
		public virtual void GetString_throws_for_null_Currency() => TestException(DbType.Currency, ValueKind.Null, x => x.GetString(0), GetNullExceptionType());

		[SkippableFact]
		public virtual void GetString_throws_for_null_String() => TestException(DbType.String, ValueKind.Null, x => x.GetString(0), GetNullExceptionType());

		[SkippableFact]
		public virtual void GetString_for_empty_String() => TestGetValue(DbType.String, ValueKind.Empty, x => x.GetString(0), "");

		[SkippableFact]
		public virtual void GetString_for_zero_String() => TestGetValue(DbType.String, ValueKind.Zero, x => x.GetString(0), "0");

		[SkippableFact]
		public virtual void GetString_for_one_String() => TestGetValue(DbType.String, ValueKind.One, x => x.GetString(0), "1");

	}
}
