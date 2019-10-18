using System;
using System.CodeDom.Compiler;
using System.Data;
using Xunit;

namespace AdoNet.Specification.Tests
{
	[GeneratedCode("https://gist.github.com/bgrainger/33c4f9d573d778c355aebfae3bcd4fc3", "1")]
	public abstract partial class GetValueConversionTestBase<TFixture>
	{
		[SkippableFact]
		public virtual void GetBoolean_throws_for_empty_Binary() => TestException(DbType.Binary, ValueKind.Empty, x => x.GetBoolean(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetBoolean_throws_for_empty_Binary_with_GetFieldValue() => TestException(DbType.Binary, ValueKind.Empty, x => x.GetFieldValue<bool>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetBoolean_throws_for_zero_Binary() => TestException(DbType.Binary, ValueKind.Zero, x => x.GetBoolean(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetBoolean_throws_for_zero_Binary_with_GetFieldValue() => TestException(DbType.Binary, ValueKind.Zero, x => x.GetFieldValue<bool>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetBoolean_throws_for_one_Binary() => TestException(DbType.Binary, ValueKind.One, x => x.GetBoolean(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetBoolean_throws_for_one_Binary_with_GetFieldValue() => TestException(DbType.Binary, ValueKind.One, x => x.GetFieldValue<bool>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetBoolean_throws_for_null_Boolean() => TestException(DbType.Boolean, ValueKind.Null, x => x.GetBoolean(0), Fixture.NullValueExceptionType);

		[SkippableFact]
		public virtual void GetBoolean_throws_for_null_Boolean_with_GetFieldValue() => TestException(DbType.Boolean, ValueKind.Null, x => x.GetFieldValue<bool>(0), Fixture.NullValueExceptionType);

		[SkippableFact]
		public virtual void GetBoolean_for_zero_Boolean() => TestGetValue(DbType.Boolean, ValueKind.Zero, x => x.GetBoolean(0), false);

		[SkippableFact]
		public virtual void GetBoolean_for_zero_Boolean_with_GetFieldValue() => TestGetValue(DbType.Boolean, ValueKind.Zero, x => x.GetFieldValue<bool>(0), false);

		[SkippableFact]
		public virtual void GetBoolean_for_one_Boolean() => TestGetValue(DbType.Boolean, ValueKind.One, x => x.GetBoolean(0), true);

		[SkippableFact]
		public virtual void GetBoolean_for_one_Boolean_with_GetFieldValue() => TestGetValue(DbType.Boolean, ValueKind.One, x => x.GetFieldValue<bool>(0), true);

		[SkippableFact]
		public virtual void GetBoolean_for_minimum_Boolean() => TestGetValue(DbType.Boolean, ValueKind.Minimum, x => x.GetBoolean(0), false);

		[SkippableFact]
		public virtual void GetBoolean_for_minimum_Boolean_with_GetFieldValue() => TestGetValue(DbType.Boolean, ValueKind.Minimum, x => x.GetFieldValue<bool>(0), false);

		[SkippableFact]
		public virtual void GetBoolean_for_maximum_Boolean() => TestGetValue(DbType.Boolean, ValueKind.Maximum, x => x.GetBoolean(0), true);

		[SkippableFact]
		public virtual void GetBoolean_for_maximum_Boolean_with_GetFieldValue() => TestGetValue(DbType.Boolean, ValueKind.Maximum, x => x.GetFieldValue<bool>(0), true);

		[SkippableFact]
		public virtual void GetBoolean_throws_for_zero_Byte() => TestException(DbType.Byte, ValueKind.Zero, x => x.GetBoolean(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetBoolean_throws_for_zero_Byte_with_GetFieldValue() => TestException(DbType.Byte, ValueKind.Zero, x => x.GetFieldValue<bool>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetBoolean_throws_for_one_Byte() => TestException(DbType.Byte, ValueKind.One, x => x.GetBoolean(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetBoolean_throws_for_one_Byte_with_GetFieldValue() => TestException(DbType.Byte, ValueKind.One, x => x.GetFieldValue<bool>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetBoolean_throws_for_minimum_Byte() => TestException(DbType.Byte, ValueKind.Minimum, x => x.GetBoolean(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetBoolean_throws_for_minimum_Byte_with_GetFieldValue() => TestException(DbType.Byte, ValueKind.Minimum, x => x.GetFieldValue<bool>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetBoolean_throws_for_maximum_Byte() => TestException(DbType.Byte, ValueKind.Maximum, x => x.GetBoolean(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetBoolean_throws_for_maximum_Byte_with_GetFieldValue() => TestException(DbType.Byte, ValueKind.Maximum, x => x.GetFieldValue<bool>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetBoolean_throws_for_null_Currency() => TestException(DbType.Currency, ValueKind.Null, x => x.GetBoolean(0), Fixture.NullValueExceptionType);

		[SkippableFact]
		public virtual void GetBoolean_throws_for_null_Currency_with_GetFieldValue() => TestException(DbType.Currency, ValueKind.Null, x => x.GetFieldValue<bool>(0), Fixture.NullValueExceptionType);

		[SkippableFact]
		public virtual void GetBoolean_throws_for_zero_Currency() => TestException(DbType.Currency, ValueKind.Zero, x => x.GetBoolean(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetBoolean_throws_for_zero_Currency_with_GetFieldValue() => TestException(DbType.Currency, ValueKind.Zero, x => x.GetFieldValue<bool>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetBoolean_throws_for_one_Currency() => TestException(DbType.Currency, ValueKind.One, x => x.GetBoolean(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetBoolean_throws_for_one_Currency_with_GetFieldValue() => TestException(DbType.Currency, ValueKind.One, x => x.GetFieldValue<bool>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetBoolean_throws_for_minimum_Currency() => TestException(DbType.Currency, ValueKind.Minimum, x => x.GetBoolean(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetBoolean_throws_for_minimum_Currency_with_GetFieldValue() => TestException(DbType.Currency, ValueKind.Minimum, x => x.GetFieldValue<bool>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetBoolean_throws_for_maximum_Currency() => TestException(DbType.Currency, ValueKind.Maximum, x => x.GetBoolean(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetBoolean_throws_for_maximum_Currency_with_GetFieldValue() => TestException(DbType.Currency, ValueKind.Maximum, x => x.GetFieldValue<bool>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetBoolean_throws_for_one_Date() => TestException(DbType.Date, ValueKind.One, x => x.GetBoolean(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetBoolean_throws_for_one_Date_with_GetFieldValue() => TestException(DbType.Date, ValueKind.One, x => x.GetFieldValue<bool>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetBoolean_throws_for_minimum_Date() => TestException(DbType.Date, ValueKind.Minimum, x => x.GetBoolean(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetBoolean_throws_for_minimum_Date_with_GetFieldValue() => TestException(DbType.Date, ValueKind.Minimum, x => x.GetFieldValue<bool>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetBoolean_throws_for_maximum_Date() => TestException(DbType.Date, ValueKind.Maximum, x => x.GetBoolean(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetBoolean_throws_for_maximum_Date_with_GetFieldValue() => TestException(DbType.Date, ValueKind.Maximum, x => x.GetFieldValue<bool>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetBoolean_throws_for_one_DateTime() => TestException(DbType.DateTime, ValueKind.One, x => x.GetBoolean(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetBoolean_throws_for_one_DateTime_with_GetFieldValue() => TestException(DbType.DateTime, ValueKind.One, x => x.GetFieldValue<bool>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetBoolean_throws_for_minimum_DateTime() => TestException(DbType.DateTime, ValueKind.Minimum, x => x.GetBoolean(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetBoolean_throws_for_minimum_DateTime_with_GetFieldValue() => TestException(DbType.DateTime, ValueKind.Minimum, x => x.GetFieldValue<bool>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetBoolean_throws_for_maximum_DateTime() => TestException(DbType.DateTime, ValueKind.Maximum, x => x.GetBoolean(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetBoolean_throws_for_maximum_DateTime_with_GetFieldValue() => TestException(DbType.DateTime, ValueKind.Maximum, x => x.GetFieldValue<bool>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetBoolean_throws_for_one_DateTimeOffset() => TestException(DbType.DateTimeOffset, ValueKind.One, x => x.GetBoolean(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetBoolean_throws_for_one_DateTimeOffset_with_GetFieldValue() => TestException(DbType.DateTimeOffset, ValueKind.One, x => x.GetFieldValue<bool>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetBoolean_throws_for_minimum_DateTimeOffset() => TestException(DbType.DateTimeOffset, ValueKind.Minimum, x => x.GetBoolean(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetBoolean_throws_for_minimum_DateTimeOffset_with_GetFieldValue() => TestException(DbType.DateTimeOffset, ValueKind.Minimum, x => x.GetFieldValue<bool>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetBoolean_throws_for_maximum_DateTimeOffset() => TestException(DbType.DateTimeOffset, ValueKind.Maximum, x => x.GetBoolean(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetBoolean_throws_for_maximum_DateTimeOffset_with_GetFieldValue() => TestException(DbType.DateTimeOffset, ValueKind.Maximum, x => x.GetFieldValue<bool>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetBoolean_throws_for_zero_Decimal() => TestException(DbType.Decimal, ValueKind.Zero, x => x.GetBoolean(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetBoolean_throws_for_zero_Decimal_with_GetFieldValue() => TestException(DbType.Decimal, ValueKind.Zero, x => x.GetFieldValue<bool>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetBoolean_throws_for_one_Decimal() => TestException(DbType.Decimal, ValueKind.One, x => x.GetBoolean(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetBoolean_throws_for_one_Decimal_with_GetFieldValue() => TestException(DbType.Decimal, ValueKind.One, x => x.GetFieldValue<bool>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetBoolean_throws_for_minimum_Decimal() => TestException(DbType.Decimal, ValueKind.Minimum, x => x.GetBoolean(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetBoolean_throws_for_minimum_Decimal_with_GetFieldValue() => TestException(DbType.Decimal, ValueKind.Minimum, x => x.GetFieldValue<bool>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetBoolean_throws_for_maximum_Decimal() => TestException(DbType.Decimal, ValueKind.Maximum, x => x.GetBoolean(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetBoolean_throws_for_maximum_Decimal_with_GetFieldValue() => TestException(DbType.Decimal, ValueKind.Maximum, x => x.GetFieldValue<bool>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetBoolean_throws_for_zero_Double() => TestException(DbType.Double, ValueKind.Zero, x => x.GetBoolean(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetBoolean_throws_for_zero_Double_with_GetFieldValue() => TestException(DbType.Double, ValueKind.Zero, x => x.GetFieldValue<bool>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetBoolean_throws_for_one_Double() => TestException(DbType.Double, ValueKind.One, x => x.GetBoolean(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetBoolean_throws_for_one_Double_with_GetFieldValue() => TestException(DbType.Double, ValueKind.One, x => x.GetFieldValue<bool>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetBoolean_throws_for_minimum_Double() => TestException(DbType.Double, ValueKind.Minimum, x => x.GetBoolean(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetBoolean_throws_for_minimum_Double_with_GetFieldValue() => TestException(DbType.Double, ValueKind.Minimum, x => x.GetFieldValue<bool>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetBoolean_throws_for_maximum_Double() => TestException(DbType.Double, ValueKind.Maximum, x => x.GetBoolean(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetBoolean_throws_for_maximum_Double_with_GetFieldValue() => TestException(DbType.Double, ValueKind.Maximum, x => x.GetFieldValue<bool>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetBoolean_throws_for_zero_Guid() => TestException(DbType.Guid, ValueKind.Zero, x => x.GetBoolean(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetBoolean_throws_for_zero_Guid_with_GetFieldValue() => TestException(DbType.Guid, ValueKind.Zero, x => x.GetFieldValue<bool>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetBoolean_throws_for_one_Guid() => TestException(DbType.Guid, ValueKind.One, x => x.GetBoolean(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetBoolean_throws_for_one_Guid_with_GetFieldValue() => TestException(DbType.Guid, ValueKind.One, x => x.GetFieldValue<bool>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetBoolean_throws_for_zero_Int16() => TestException(DbType.Int16, ValueKind.Zero, x => x.GetBoolean(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetBoolean_throws_for_zero_Int16_with_GetFieldValue() => TestException(DbType.Int16, ValueKind.Zero, x => x.GetFieldValue<bool>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetBoolean_throws_for_one_Int16() => TestException(DbType.Int16, ValueKind.One, x => x.GetBoolean(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetBoolean_throws_for_one_Int16_with_GetFieldValue() => TestException(DbType.Int16, ValueKind.One, x => x.GetFieldValue<bool>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetBoolean_throws_for_minimum_Int16() => TestException(DbType.Int16, ValueKind.Minimum, x => x.GetBoolean(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetBoolean_throws_for_minimum_Int16_with_GetFieldValue() => TestException(DbType.Int16, ValueKind.Minimum, x => x.GetFieldValue<bool>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetBoolean_throws_for_maximum_Int16() => TestException(DbType.Int16, ValueKind.Maximum, x => x.GetBoolean(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetBoolean_throws_for_maximum_Int16_with_GetFieldValue() => TestException(DbType.Int16, ValueKind.Maximum, x => x.GetFieldValue<bool>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetBoolean_throws_for_zero_Int32() => TestException(DbType.Int32, ValueKind.Zero, x => x.GetBoolean(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetBoolean_throws_for_zero_Int32_with_GetFieldValue() => TestException(DbType.Int32, ValueKind.Zero, x => x.GetFieldValue<bool>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetBoolean_throws_for_one_Int32() => TestException(DbType.Int32, ValueKind.One, x => x.GetBoolean(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetBoolean_throws_for_one_Int32_with_GetFieldValue() => TestException(DbType.Int32, ValueKind.One, x => x.GetFieldValue<bool>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetBoolean_throws_for_minimum_Int32() => TestException(DbType.Int32, ValueKind.Minimum, x => x.GetBoolean(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetBoolean_throws_for_minimum_Int32_with_GetFieldValue() => TestException(DbType.Int32, ValueKind.Minimum, x => x.GetFieldValue<bool>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetBoolean_throws_for_maximum_Int32() => TestException(DbType.Int32, ValueKind.Maximum, x => x.GetBoolean(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetBoolean_throws_for_maximum_Int32_with_GetFieldValue() => TestException(DbType.Int32, ValueKind.Maximum, x => x.GetFieldValue<bool>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetBoolean_throws_for_zero_Int64() => TestException(DbType.Int64, ValueKind.Zero, x => x.GetBoolean(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetBoolean_throws_for_zero_Int64_with_GetFieldValue() => TestException(DbType.Int64, ValueKind.Zero, x => x.GetFieldValue<bool>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetBoolean_throws_for_one_Int64() => TestException(DbType.Int64, ValueKind.One, x => x.GetBoolean(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetBoolean_throws_for_one_Int64_with_GetFieldValue() => TestException(DbType.Int64, ValueKind.One, x => x.GetFieldValue<bool>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetBoolean_throws_for_minimum_Int64() => TestException(DbType.Int64, ValueKind.Minimum, x => x.GetBoolean(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetBoolean_throws_for_minimum_Int64_with_GetFieldValue() => TestException(DbType.Int64, ValueKind.Minimum, x => x.GetFieldValue<bool>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetBoolean_throws_for_maximum_Int64() => TestException(DbType.Int64, ValueKind.Maximum, x => x.GetBoolean(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetBoolean_throws_for_maximum_Int64_with_GetFieldValue() => TestException(DbType.Int64, ValueKind.Maximum, x => x.GetFieldValue<bool>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetBoolean_throws_for_zero_SByte() => TestException(DbType.SByte, ValueKind.Zero, x => x.GetBoolean(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetBoolean_throws_for_zero_SByte_with_GetFieldValue() => TestException(DbType.SByte, ValueKind.Zero, x => x.GetFieldValue<bool>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetBoolean_throws_for_one_SByte() => TestException(DbType.SByte, ValueKind.One, x => x.GetBoolean(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetBoolean_throws_for_one_SByte_with_GetFieldValue() => TestException(DbType.SByte, ValueKind.One, x => x.GetFieldValue<bool>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetBoolean_throws_for_minimum_SByte() => TestException(DbType.SByte, ValueKind.Minimum, x => x.GetBoolean(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetBoolean_throws_for_minimum_SByte_with_GetFieldValue() => TestException(DbType.SByte, ValueKind.Minimum, x => x.GetFieldValue<bool>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetBoolean_throws_for_maximum_SByte() => TestException(DbType.SByte, ValueKind.Maximum, x => x.GetBoolean(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetBoolean_throws_for_maximum_SByte_with_GetFieldValue() => TestException(DbType.SByte, ValueKind.Maximum, x => x.GetFieldValue<bool>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetBoolean_throws_for_zero_Single() => TestException(DbType.Single, ValueKind.Zero, x => x.GetBoolean(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetBoolean_throws_for_zero_Single_with_GetFieldValue() => TestException(DbType.Single, ValueKind.Zero, x => x.GetFieldValue<bool>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetBoolean_throws_for_one_Single() => TestException(DbType.Single, ValueKind.One, x => x.GetBoolean(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetBoolean_throws_for_one_Single_with_GetFieldValue() => TestException(DbType.Single, ValueKind.One, x => x.GetFieldValue<bool>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetBoolean_throws_for_minimum_Single() => TestException(DbType.Single, ValueKind.Minimum, x => x.GetBoolean(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetBoolean_throws_for_minimum_Single_with_GetFieldValue() => TestException(DbType.Single, ValueKind.Minimum, x => x.GetFieldValue<bool>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetBoolean_throws_for_maximum_Single() => TestException(DbType.Single, ValueKind.Maximum, x => x.GetBoolean(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetBoolean_throws_for_maximum_Single_with_GetFieldValue() => TestException(DbType.Single, ValueKind.Maximum, x => x.GetFieldValue<bool>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetBoolean_throws_for_empty_String() => TestException(DbType.String, ValueKind.Empty, x => x.GetBoolean(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetBoolean_throws_for_empty_String_with_GetFieldValue() => TestException(DbType.String, ValueKind.Empty, x => x.GetFieldValue<bool>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetBoolean_throws_for_zero_String() => TestException(DbType.String, ValueKind.Zero, x => x.GetBoolean(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetBoolean_throws_for_zero_String_with_GetFieldValue() => TestException(DbType.String, ValueKind.Zero, x => x.GetFieldValue<bool>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetBoolean_throws_for_one_String() => TestException(DbType.String, ValueKind.One, x => x.GetBoolean(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetBoolean_throws_for_one_String_with_GetFieldValue() => TestException(DbType.String, ValueKind.One, x => x.GetFieldValue<bool>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetBoolean_throws_for_zero_Time() => TestException(DbType.Time, ValueKind.Zero, x => x.GetBoolean(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetBoolean_throws_for_zero_Time_with_GetFieldValue() => TestException(DbType.Time, ValueKind.Zero, x => x.GetFieldValue<bool>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetBoolean_throws_for_one_Time() => TestException(DbType.Time, ValueKind.One, x => x.GetBoolean(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetBoolean_throws_for_one_Time_with_GetFieldValue() => TestException(DbType.Time, ValueKind.One, x => x.GetFieldValue<bool>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetBoolean_throws_for_minimum_Time() => TestException(DbType.Time, ValueKind.Minimum, x => x.GetBoolean(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetBoolean_throws_for_minimum_Time_with_GetFieldValue() => TestException(DbType.Time, ValueKind.Minimum, x => x.GetFieldValue<bool>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetBoolean_throws_for_maximum_Time() => TestException(DbType.Time, ValueKind.Maximum, x => x.GetBoolean(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetBoolean_throws_for_maximum_Time_with_GetFieldValue() => TestException(DbType.Time, ValueKind.Maximum, x => x.GetFieldValue<bool>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetBoolean_throws_for_zero_UInt16() => TestException(DbType.UInt16, ValueKind.Zero, x => x.GetBoolean(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetBoolean_throws_for_zero_UInt16_with_GetFieldValue() => TestException(DbType.UInt16, ValueKind.Zero, x => x.GetFieldValue<bool>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetBoolean_throws_for_one_UInt16() => TestException(DbType.UInt16, ValueKind.One, x => x.GetBoolean(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetBoolean_throws_for_one_UInt16_with_GetFieldValue() => TestException(DbType.UInt16, ValueKind.One, x => x.GetFieldValue<bool>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetBoolean_throws_for_minimum_UInt16() => TestException(DbType.UInt16, ValueKind.Minimum, x => x.GetBoolean(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetBoolean_throws_for_minimum_UInt16_with_GetFieldValue() => TestException(DbType.UInt16, ValueKind.Minimum, x => x.GetFieldValue<bool>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetBoolean_throws_for_maximum_UInt16() => TestException(DbType.UInt16, ValueKind.Maximum, x => x.GetBoolean(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetBoolean_throws_for_maximum_UInt16_with_GetFieldValue() => TestException(DbType.UInt16, ValueKind.Maximum, x => x.GetFieldValue<bool>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetBoolean_throws_for_zero_UInt32() => TestException(DbType.UInt32, ValueKind.Zero, x => x.GetBoolean(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetBoolean_throws_for_zero_UInt32_with_GetFieldValue() => TestException(DbType.UInt32, ValueKind.Zero, x => x.GetFieldValue<bool>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetBoolean_throws_for_one_UInt32() => TestException(DbType.UInt32, ValueKind.One, x => x.GetBoolean(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetBoolean_throws_for_one_UInt32_with_GetFieldValue() => TestException(DbType.UInt32, ValueKind.One, x => x.GetFieldValue<bool>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetBoolean_throws_for_minimum_UInt32() => TestException(DbType.UInt32, ValueKind.Minimum, x => x.GetBoolean(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetBoolean_throws_for_minimum_UInt32_with_GetFieldValue() => TestException(DbType.UInt32, ValueKind.Minimum, x => x.GetFieldValue<bool>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetBoolean_throws_for_maximum_UInt32() => TestException(DbType.UInt32, ValueKind.Maximum, x => x.GetBoolean(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetBoolean_throws_for_maximum_UInt32_with_GetFieldValue() => TestException(DbType.UInt32, ValueKind.Maximum, x => x.GetFieldValue<bool>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetBoolean_throws_for_zero_UInt64() => TestException(DbType.UInt64, ValueKind.Zero, x => x.GetBoolean(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetBoolean_throws_for_zero_UInt64_with_GetFieldValue() => TestException(DbType.UInt64, ValueKind.Zero, x => x.GetFieldValue<bool>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetBoolean_throws_for_one_UInt64() => TestException(DbType.UInt64, ValueKind.One, x => x.GetBoolean(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetBoolean_throws_for_one_UInt64_with_GetFieldValue() => TestException(DbType.UInt64, ValueKind.One, x => x.GetFieldValue<bool>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetBoolean_throws_for_minimum_UInt64() => TestException(DbType.UInt64, ValueKind.Minimum, x => x.GetBoolean(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetBoolean_throws_for_minimum_UInt64_with_GetFieldValue() => TestException(DbType.UInt64, ValueKind.Minimum, x => x.GetFieldValue<bool>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetBoolean_throws_for_maximum_UInt64() => TestException(DbType.UInt64, ValueKind.Maximum, x => x.GetBoolean(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetBoolean_throws_for_maximum_UInt64_with_GetFieldValue() => TestException(DbType.UInt64, ValueKind.Maximum, x => x.GetFieldValue<bool>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetByte_throws_for_empty_Binary() => TestException(DbType.Binary, ValueKind.Empty, x => x.GetByte(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetByte_throws_for_empty_Binary_with_GetFieldValue() => TestException(DbType.Binary, ValueKind.Empty, x => x.GetFieldValue<byte>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetByte_throws_for_zero_Binary() => TestException(DbType.Binary, ValueKind.Zero, x => x.GetByte(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetByte_throws_for_zero_Binary_with_GetFieldValue() => TestException(DbType.Binary, ValueKind.Zero, x => x.GetFieldValue<byte>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetByte_throws_for_one_Binary() => TestException(DbType.Binary, ValueKind.One, x => x.GetByte(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetByte_throws_for_one_Binary_with_GetFieldValue() => TestException(DbType.Binary, ValueKind.One, x => x.GetFieldValue<byte>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetByte_throws_for_null_Byte() => TestException(DbType.Byte, ValueKind.Null, x => x.GetByte(0), Fixture.NullValueExceptionType);

		[SkippableFact]
		public virtual void GetByte_throws_for_null_Byte_with_GetFieldValue() => TestException(DbType.Byte, ValueKind.Null, x => x.GetFieldValue<byte>(0), Fixture.NullValueExceptionType);

		[SkippableFact]
		public virtual void GetByte_for_zero_Byte() => TestGetValue(DbType.Byte, ValueKind.Zero, x => x.GetByte(0), (byte) 0);

		[SkippableFact]
		public virtual void GetByte_for_zero_Byte_with_GetFieldValue() => TestGetValue(DbType.Byte, ValueKind.Zero, x => x.GetFieldValue<byte>(0), (byte) 0);

		[SkippableFact]
		public virtual void GetByte_for_one_Byte() => TestGetValue(DbType.Byte, ValueKind.One, x => x.GetByte(0), (byte) 1);

		[SkippableFact]
		public virtual void GetByte_for_one_Byte_with_GetFieldValue() => TestGetValue(DbType.Byte, ValueKind.One, x => x.GetFieldValue<byte>(0), (byte) 1);

		[SkippableFact]
		public virtual void GetByte_for_minimum_Byte() => TestGetValue(DbType.Byte, ValueKind.Minimum, x => x.GetByte(0), (byte) 0);

		[SkippableFact]
		public virtual void GetByte_for_minimum_Byte_with_GetFieldValue() => TestGetValue(DbType.Byte, ValueKind.Minimum, x => x.GetFieldValue<byte>(0), (byte) 0);

		[SkippableFact]
		public virtual void GetByte_for_maximum_Byte() => TestGetValue(DbType.Byte, ValueKind.Maximum, x => x.GetByte(0), (byte) 255);

		[SkippableFact]
		public virtual void GetByte_for_maximum_Byte_with_GetFieldValue() => TestGetValue(DbType.Byte, ValueKind.Maximum, x => x.GetFieldValue<byte>(0), (byte) 255);

		[SkippableFact]
		public virtual void GetByte_throws_for_null_Currency() => TestException(DbType.Currency, ValueKind.Null, x => x.GetByte(0), Fixture.NullValueExceptionType);

		[SkippableFact]
		public virtual void GetByte_throws_for_null_Currency_with_GetFieldValue() => TestException(DbType.Currency, ValueKind.Null, x => x.GetFieldValue<byte>(0), Fixture.NullValueExceptionType);

		[SkippableFact]
		public virtual void GetByte_throws_for_zero_Currency() => TestException(DbType.Currency, ValueKind.Zero, x => x.GetByte(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetByte_throws_for_zero_Currency_with_GetFieldValue() => TestException(DbType.Currency, ValueKind.Zero, x => x.GetFieldValue<byte>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetByte_throws_for_one_Currency() => TestException(DbType.Currency, ValueKind.One, x => x.GetByte(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetByte_throws_for_one_Currency_with_GetFieldValue() => TestException(DbType.Currency, ValueKind.One, x => x.GetFieldValue<byte>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetByte_throws_for_minimum_Currency() => TestException(DbType.Currency, ValueKind.Minimum, x => x.GetByte(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetByte_throws_for_minimum_Currency_with_GetFieldValue() => TestException(DbType.Currency, ValueKind.Minimum, x => x.GetFieldValue<byte>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetByte_throws_for_maximum_Currency() => TestException(DbType.Currency, ValueKind.Maximum, x => x.GetByte(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetByte_throws_for_maximum_Currency_with_GetFieldValue() => TestException(DbType.Currency, ValueKind.Maximum, x => x.GetFieldValue<byte>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetByte_throws_for_one_Date() => TestException(DbType.Date, ValueKind.One, x => x.GetByte(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetByte_throws_for_one_Date_with_GetFieldValue() => TestException(DbType.Date, ValueKind.One, x => x.GetFieldValue<byte>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetByte_throws_for_minimum_Date() => TestException(DbType.Date, ValueKind.Minimum, x => x.GetByte(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetByte_throws_for_minimum_Date_with_GetFieldValue() => TestException(DbType.Date, ValueKind.Minimum, x => x.GetFieldValue<byte>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetByte_throws_for_maximum_Date() => TestException(DbType.Date, ValueKind.Maximum, x => x.GetByte(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetByte_throws_for_maximum_Date_with_GetFieldValue() => TestException(DbType.Date, ValueKind.Maximum, x => x.GetFieldValue<byte>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetByte_throws_for_one_DateTime() => TestException(DbType.DateTime, ValueKind.One, x => x.GetByte(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetByte_throws_for_one_DateTime_with_GetFieldValue() => TestException(DbType.DateTime, ValueKind.One, x => x.GetFieldValue<byte>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetByte_throws_for_minimum_DateTime() => TestException(DbType.DateTime, ValueKind.Minimum, x => x.GetByte(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetByte_throws_for_minimum_DateTime_with_GetFieldValue() => TestException(DbType.DateTime, ValueKind.Minimum, x => x.GetFieldValue<byte>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetByte_throws_for_maximum_DateTime() => TestException(DbType.DateTime, ValueKind.Maximum, x => x.GetByte(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetByte_throws_for_maximum_DateTime_with_GetFieldValue() => TestException(DbType.DateTime, ValueKind.Maximum, x => x.GetFieldValue<byte>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetByte_throws_for_one_DateTimeOffset() => TestException(DbType.DateTimeOffset, ValueKind.One, x => x.GetByte(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetByte_throws_for_one_DateTimeOffset_with_GetFieldValue() => TestException(DbType.DateTimeOffset, ValueKind.One, x => x.GetFieldValue<byte>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetByte_throws_for_minimum_DateTimeOffset() => TestException(DbType.DateTimeOffset, ValueKind.Minimum, x => x.GetByte(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetByte_throws_for_minimum_DateTimeOffset_with_GetFieldValue() => TestException(DbType.DateTimeOffset, ValueKind.Minimum, x => x.GetFieldValue<byte>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetByte_throws_for_maximum_DateTimeOffset() => TestException(DbType.DateTimeOffset, ValueKind.Maximum, x => x.GetByte(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetByte_throws_for_maximum_DateTimeOffset_with_GetFieldValue() => TestException(DbType.DateTimeOffset, ValueKind.Maximum, x => x.GetFieldValue<byte>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetByte_throws_for_zero_Decimal() => TestException(DbType.Decimal, ValueKind.Zero, x => x.GetByte(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetByte_throws_for_zero_Decimal_with_GetFieldValue() => TestException(DbType.Decimal, ValueKind.Zero, x => x.GetFieldValue<byte>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetByte_throws_for_one_Decimal() => TestException(DbType.Decimal, ValueKind.One, x => x.GetByte(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetByte_throws_for_one_Decimal_with_GetFieldValue() => TestException(DbType.Decimal, ValueKind.One, x => x.GetFieldValue<byte>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetByte_throws_for_minimum_Decimal() => TestException(DbType.Decimal, ValueKind.Minimum, x => x.GetByte(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetByte_throws_for_minimum_Decimal_with_GetFieldValue() => TestException(DbType.Decimal, ValueKind.Minimum, x => x.GetFieldValue<byte>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetByte_throws_for_maximum_Decimal() => TestException(DbType.Decimal, ValueKind.Maximum, x => x.GetByte(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetByte_throws_for_maximum_Decimal_with_GetFieldValue() => TestException(DbType.Decimal, ValueKind.Maximum, x => x.GetFieldValue<byte>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetByte_throws_for_zero_Double() => TestException(DbType.Double, ValueKind.Zero, x => x.GetByte(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetByte_throws_for_zero_Double_with_GetFieldValue() => TestException(DbType.Double, ValueKind.Zero, x => x.GetFieldValue<byte>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetByte_throws_for_one_Double() => TestException(DbType.Double, ValueKind.One, x => x.GetByte(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetByte_throws_for_one_Double_with_GetFieldValue() => TestException(DbType.Double, ValueKind.One, x => x.GetFieldValue<byte>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetByte_throws_for_minimum_Double() => TestException(DbType.Double, ValueKind.Minimum, x => x.GetByte(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetByte_throws_for_minimum_Double_with_GetFieldValue() => TestException(DbType.Double, ValueKind.Minimum, x => x.GetFieldValue<byte>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetByte_throws_for_maximum_Double() => TestException(DbType.Double, ValueKind.Maximum, x => x.GetByte(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetByte_throws_for_maximum_Double_with_GetFieldValue() => TestException(DbType.Double, ValueKind.Maximum, x => x.GetFieldValue<byte>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetByte_throws_for_zero_Guid() => TestException(DbType.Guid, ValueKind.Zero, x => x.GetByte(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetByte_throws_for_zero_Guid_with_GetFieldValue() => TestException(DbType.Guid, ValueKind.Zero, x => x.GetFieldValue<byte>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetByte_throws_for_one_Guid() => TestException(DbType.Guid, ValueKind.One, x => x.GetByte(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetByte_throws_for_one_Guid_with_GetFieldValue() => TestException(DbType.Guid, ValueKind.One, x => x.GetFieldValue<byte>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetByte_throws_for_zero_Int16() => TestException(DbType.Int16, ValueKind.Zero, x => x.GetByte(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetByte_throws_for_zero_Int16_with_GetFieldValue() => TestException(DbType.Int16, ValueKind.Zero, x => x.GetFieldValue<byte>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetByte_throws_for_one_Int16() => TestException(DbType.Int16, ValueKind.One, x => x.GetByte(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetByte_throws_for_one_Int16_with_GetFieldValue() => TestException(DbType.Int16, ValueKind.One, x => x.GetFieldValue<byte>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetByte_throws_for_minimum_Int16() => TestException(DbType.Int16, ValueKind.Minimum, x => x.GetByte(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetByte_throws_for_minimum_Int16_with_GetFieldValue() => TestException(DbType.Int16, ValueKind.Minimum, x => x.GetFieldValue<byte>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetByte_throws_for_maximum_Int16() => TestException(DbType.Int16, ValueKind.Maximum, x => x.GetByte(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetByte_throws_for_maximum_Int16_with_GetFieldValue() => TestException(DbType.Int16, ValueKind.Maximum, x => x.GetFieldValue<byte>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetByte_throws_for_zero_Int32() => TestException(DbType.Int32, ValueKind.Zero, x => x.GetByte(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetByte_throws_for_zero_Int32_with_GetFieldValue() => TestException(DbType.Int32, ValueKind.Zero, x => x.GetFieldValue<byte>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetByte_throws_for_one_Int32() => TestException(DbType.Int32, ValueKind.One, x => x.GetByte(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetByte_throws_for_one_Int32_with_GetFieldValue() => TestException(DbType.Int32, ValueKind.One, x => x.GetFieldValue<byte>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetByte_throws_for_minimum_Int32() => TestException(DbType.Int32, ValueKind.Minimum, x => x.GetByte(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetByte_throws_for_minimum_Int32_with_GetFieldValue() => TestException(DbType.Int32, ValueKind.Minimum, x => x.GetFieldValue<byte>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetByte_throws_for_maximum_Int32() => TestException(DbType.Int32, ValueKind.Maximum, x => x.GetByte(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetByte_throws_for_maximum_Int32_with_GetFieldValue() => TestException(DbType.Int32, ValueKind.Maximum, x => x.GetFieldValue<byte>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetByte_throws_for_zero_Int64() => TestException(DbType.Int64, ValueKind.Zero, x => x.GetByte(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetByte_throws_for_zero_Int64_with_GetFieldValue() => TestException(DbType.Int64, ValueKind.Zero, x => x.GetFieldValue<byte>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetByte_throws_for_one_Int64() => TestException(DbType.Int64, ValueKind.One, x => x.GetByte(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetByte_throws_for_one_Int64_with_GetFieldValue() => TestException(DbType.Int64, ValueKind.One, x => x.GetFieldValue<byte>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetByte_throws_for_minimum_Int64() => TestException(DbType.Int64, ValueKind.Minimum, x => x.GetByte(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetByte_throws_for_minimum_Int64_with_GetFieldValue() => TestException(DbType.Int64, ValueKind.Minimum, x => x.GetFieldValue<byte>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetByte_throws_for_maximum_Int64() => TestException(DbType.Int64, ValueKind.Maximum, x => x.GetByte(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetByte_throws_for_maximum_Int64_with_GetFieldValue() => TestException(DbType.Int64, ValueKind.Maximum, x => x.GetFieldValue<byte>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetByte_throws_for_zero_SByte() => TestException(DbType.SByte, ValueKind.Zero, x => x.GetByte(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetByte_throws_for_zero_SByte_with_GetFieldValue() => TestException(DbType.SByte, ValueKind.Zero, x => x.GetFieldValue<byte>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetByte_throws_for_one_SByte() => TestException(DbType.SByte, ValueKind.One, x => x.GetByte(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetByte_throws_for_one_SByte_with_GetFieldValue() => TestException(DbType.SByte, ValueKind.One, x => x.GetFieldValue<byte>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetByte_throws_for_minimum_SByte() => TestException(DbType.SByte, ValueKind.Minimum, x => x.GetByte(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetByte_throws_for_minimum_SByte_with_GetFieldValue() => TestException(DbType.SByte, ValueKind.Minimum, x => x.GetFieldValue<byte>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetByte_throws_for_maximum_SByte() => TestException(DbType.SByte, ValueKind.Maximum, x => x.GetByte(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetByte_throws_for_maximum_SByte_with_GetFieldValue() => TestException(DbType.SByte, ValueKind.Maximum, x => x.GetFieldValue<byte>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetByte_throws_for_zero_Single() => TestException(DbType.Single, ValueKind.Zero, x => x.GetByte(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetByte_throws_for_zero_Single_with_GetFieldValue() => TestException(DbType.Single, ValueKind.Zero, x => x.GetFieldValue<byte>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetByte_throws_for_one_Single() => TestException(DbType.Single, ValueKind.One, x => x.GetByte(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetByte_throws_for_one_Single_with_GetFieldValue() => TestException(DbType.Single, ValueKind.One, x => x.GetFieldValue<byte>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetByte_throws_for_minimum_Single() => TestException(DbType.Single, ValueKind.Minimum, x => x.GetByte(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetByte_throws_for_minimum_Single_with_GetFieldValue() => TestException(DbType.Single, ValueKind.Minimum, x => x.GetFieldValue<byte>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetByte_throws_for_maximum_Single() => TestException(DbType.Single, ValueKind.Maximum, x => x.GetByte(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetByte_throws_for_maximum_Single_with_GetFieldValue() => TestException(DbType.Single, ValueKind.Maximum, x => x.GetFieldValue<byte>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetByte_throws_for_empty_String() => TestException(DbType.String, ValueKind.Empty, x => x.GetByte(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetByte_throws_for_empty_String_with_GetFieldValue() => TestException(DbType.String, ValueKind.Empty, x => x.GetFieldValue<byte>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetByte_throws_for_zero_String() => TestException(DbType.String, ValueKind.Zero, x => x.GetByte(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetByte_throws_for_zero_String_with_GetFieldValue() => TestException(DbType.String, ValueKind.Zero, x => x.GetFieldValue<byte>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetByte_throws_for_one_String() => TestException(DbType.String, ValueKind.One, x => x.GetByte(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetByte_throws_for_one_String_with_GetFieldValue() => TestException(DbType.String, ValueKind.One, x => x.GetFieldValue<byte>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetByte_throws_for_zero_Time() => TestException(DbType.Time, ValueKind.Zero, x => x.GetByte(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetByte_throws_for_zero_Time_with_GetFieldValue() => TestException(DbType.Time, ValueKind.Zero, x => x.GetFieldValue<byte>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetByte_throws_for_one_Time() => TestException(DbType.Time, ValueKind.One, x => x.GetByte(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetByte_throws_for_one_Time_with_GetFieldValue() => TestException(DbType.Time, ValueKind.One, x => x.GetFieldValue<byte>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetByte_throws_for_minimum_Time() => TestException(DbType.Time, ValueKind.Minimum, x => x.GetByte(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetByte_throws_for_minimum_Time_with_GetFieldValue() => TestException(DbType.Time, ValueKind.Minimum, x => x.GetFieldValue<byte>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetByte_throws_for_maximum_Time() => TestException(DbType.Time, ValueKind.Maximum, x => x.GetByte(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetByte_throws_for_maximum_Time_with_GetFieldValue() => TestException(DbType.Time, ValueKind.Maximum, x => x.GetFieldValue<byte>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetByte_throws_for_zero_UInt16() => TestException(DbType.UInt16, ValueKind.Zero, x => x.GetByte(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetByte_throws_for_zero_UInt16_with_GetFieldValue() => TestException(DbType.UInt16, ValueKind.Zero, x => x.GetFieldValue<byte>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetByte_throws_for_one_UInt16() => TestException(DbType.UInt16, ValueKind.One, x => x.GetByte(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetByte_throws_for_one_UInt16_with_GetFieldValue() => TestException(DbType.UInt16, ValueKind.One, x => x.GetFieldValue<byte>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetByte_throws_for_minimum_UInt16() => TestException(DbType.UInt16, ValueKind.Minimum, x => x.GetByte(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetByte_throws_for_minimum_UInt16_with_GetFieldValue() => TestException(DbType.UInt16, ValueKind.Minimum, x => x.GetFieldValue<byte>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetByte_throws_for_maximum_UInt16() => TestException(DbType.UInt16, ValueKind.Maximum, x => x.GetByte(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetByte_throws_for_maximum_UInt16_with_GetFieldValue() => TestException(DbType.UInt16, ValueKind.Maximum, x => x.GetFieldValue<byte>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetByte_throws_for_zero_UInt32() => TestException(DbType.UInt32, ValueKind.Zero, x => x.GetByte(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetByte_throws_for_zero_UInt32_with_GetFieldValue() => TestException(DbType.UInt32, ValueKind.Zero, x => x.GetFieldValue<byte>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetByte_throws_for_one_UInt32() => TestException(DbType.UInt32, ValueKind.One, x => x.GetByte(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetByte_throws_for_one_UInt32_with_GetFieldValue() => TestException(DbType.UInt32, ValueKind.One, x => x.GetFieldValue<byte>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetByte_throws_for_minimum_UInt32() => TestException(DbType.UInt32, ValueKind.Minimum, x => x.GetByte(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetByte_throws_for_minimum_UInt32_with_GetFieldValue() => TestException(DbType.UInt32, ValueKind.Minimum, x => x.GetFieldValue<byte>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetByte_throws_for_maximum_UInt32() => TestException(DbType.UInt32, ValueKind.Maximum, x => x.GetByte(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetByte_throws_for_maximum_UInt32_with_GetFieldValue() => TestException(DbType.UInt32, ValueKind.Maximum, x => x.GetFieldValue<byte>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetByte_throws_for_zero_UInt64() => TestException(DbType.UInt64, ValueKind.Zero, x => x.GetByte(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetByte_throws_for_zero_UInt64_with_GetFieldValue() => TestException(DbType.UInt64, ValueKind.Zero, x => x.GetFieldValue<byte>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetByte_throws_for_one_UInt64() => TestException(DbType.UInt64, ValueKind.One, x => x.GetByte(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetByte_throws_for_one_UInt64_with_GetFieldValue() => TestException(DbType.UInt64, ValueKind.One, x => x.GetFieldValue<byte>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetByte_throws_for_minimum_UInt64() => TestException(DbType.UInt64, ValueKind.Minimum, x => x.GetByte(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetByte_throws_for_minimum_UInt64_with_GetFieldValue() => TestException(DbType.UInt64, ValueKind.Minimum, x => x.GetFieldValue<byte>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetByte_throws_for_maximum_UInt64() => TestException(DbType.UInt64, ValueKind.Maximum, x => x.GetByte(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetByte_throws_for_maximum_UInt64_with_GetFieldValue() => TestException(DbType.UInt64, ValueKind.Maximum, x => x.GetFieldValue<byte>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetChar_throws_for_empty_Binary() => TestException(DbType.Binary, ValueKind.Empty, x => x.GetChar(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetChar_throws_for_empty_Binary_with_GetFieldValue() => TestException(DbType.Binary, ValueKind.Empty, x => x.GetFieldValue<char>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetChar_throws_for_zero_Binary() => TestException(DbType.Binary, ValueKind.Zero, x => x.GetChar(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetChar_throws_for_zero_Binary_with_GetFieldValue() => TestException(DbType.Binary, ValueKind.Zero, x => x.GetFieldValue<char>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetChar_throws_for_one_Binary() => TestException(DbType.Binary, ValueKind.One, x => x.GetChar(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetChar_throws_for_one_Binary_with_GetFieldValue() => TestException(DbType.Binary, ValueKind.One, x => x.GetFieldValue<char>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetChar_throws_for_zero_Boolean() => TestException(DbType.Boolean, ValueKind.Zero, x => x.GetChar(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetChar_throws_for_zero_Boolean_with_GetFieldValue() => TestException(DbType.Boolean, ValueKind.Zero, x => x.GetFieldValue<char>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetChar_throws_for_one_Boolean() => TestException(DbType.Boolean, ValueKind.One, x => x.GetChar(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetChar_throws_for_one_Boolean_with_GetFieldValue() => TestException(DbType.Boolean, ValueKind.One, x => x.GetFieldValue<char>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetChar_throws_for_minimum_Boolean() => TestException(DbType.Boolean, ValueKind.Minimum, x => x.GetChar(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetChar_throws_for_minimum_Boolean_with_GetFieldValue() => TestException(DbType.Boolean, ValueKind.Minimum, x => x.GetFieldValue<char>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetChar_throws_for_maximum_Boolean() => TestException(DbType.Boolean, ValueKind.Maximum, x => x.GetChar(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetChar_throws_for_maximum_Boolean_with_GetFieldValue() => TestException(DbType.Boolean, ValueKind.Maximum, x => x.GetFieldValue<char>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetChar_throws_for_zero_Byte() => TestException(DbType.Byte, ValueKind.Zero, x => x.GetChar(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetChar_throws_for_zero_Byte_with_GetFieldValue() => TestException(DbType.Byte, ValueKind.Zero, x => x.GetFieldValue<char>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetChar_throws_for_one_Byte() => TestException(DbType.Byte, ValueKind.One, x => x.GetChar(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetChar_throws_for_one_Byte_with_GetFieldValue() => TestException(DbType.Byte, ValueKind.One, x => x.GetFieldValue<char>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetChar_throws_for_minimum_Byte() => TestException(DbType.Byte, ValueKind.Minimum, x => x.GetChar(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetChar_throws_for_minimum_Byte_with_GetFieldValue() => TestException(DbType.Byte, ValueKind.Minimum, x => x.GetFieldValue<char>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetChar_throws_for_maximum_Byte() => TestException(DbType.Byte, ValueKind.Maximum, x => x.GetChar(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetChar_throws_for_maximum_Byte_with_GetFieldValue() => TestException(DbType.Byte, ValueKind.Maximum, x => x.GetFieldValue<char>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetChar_throws_for_null_Currency() => TestException(DbType.Currency, ValueKind.Null, x => x.GetChar(0), Fixture.NullValueExceptionType);

		[SkippableFact]
		public virtual void GetChar_throws_for_null_Currency_with_GetFieldValue() => TestException(DbType.Currency, ValueKind.Null, x => x.GetFieldValue<char>(0), Fixture.NullValueExceptionType);

		[SkippableFact]
		public virtual void GetChar_throws_for_zero_Currency() => TestException(DbType.Currency, ValueKind.Zero, x => x.GetChar(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetChar_throws_for_zero_Currency_with_GetFieldValue() => TestException(DbType.Currency, ValueKind.Zero, x => x.GetFieldValue<char>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetChar_throws_for_one_Currency() => TestException(DbType.Currency, ValueKind.One, x => x.GetChar(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetChar_throws_for_one_Currency_with_GetFieldValue() => TestException(DbType.Currency, ValueKind.One, x => x.GetFieldValue<char>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetChar_throws_for_minimum_Currency() => TestException(DbType.Currency, ValueKind.Minimum, x => x.GetChar(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetChar_throws_for_minimum_Currency_with_GetFieldValue() => TestException(DbType.Currency, ValueKind.Minimum, x => x.GetFieldValue<char>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetChar_throws_for_maximum_Currency() => TestException(DbType.Currency, ValueKind.Maximum, x => x.GetChar(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetChar_throws_for_maximum_Currency_with_GetFieldValue() => TestException(DbType.Currency, ValueKind.Maximum, x => x.GetFieldValue<char>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetChar_throws_for_one_Date() => TestException(DbType.Date, ValueKind.One, x => x.GetChar(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetChar_throws_for_one_Date_with_GetFieldValue() => TestException(DbType.Date, ValueKind.One, x => x.GetFieldValue<char>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetChar_throws_for_minimum_Date() => TestException(DbType.Date, ValueKind.Minimum, x => x.GetChar(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetChar_throws_for_minimum_Date_with_GetFieldValue() => TestException(DbType.Date, ValueKind.Minimum, x => x.GetFieldValue<char>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetChar_throws_for_maximum_Date() => TestException(DbType.Date, ValueKind.Maximum, x => x.GetChar(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetChar_throws_for_maximum_Date_with_GetFieldValue() => TestException(DbType.Date, ValueKind.Maximum, x => x.GetFieldValue<char>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetChar_throws_for_one_DateTime() => TestException(DbType.DateTime, ValueKind.One, x => x.GetChar(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetChar_throws_for_one_DateTime_with_GetFieldValue() => TestException(DbType.DateTime, ValueKind.One, x => x.GetFieldValue<char>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetChar_throws_for_minimum_DateTime() => TestException(DbType.DateTime, ValueKind.Minimum, x => x.GetChar(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetChar_throws_for_minimum_DateTime_with_GetFieldValue() => TestException(DbType.DateTime, ValueKind.Minimum, x => x.GetFieldValue<char>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetChar_throws_for_maximum_DateTime() => TestException(DbType.DateTime, ValueKind.Maximum, x => x.GetChar(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetChar_throws_for_maximum_DateTime_with_GetFieldValue() => TestException(DbType.DateTime, ValueKind.Maximum, x => x.GetFieldValue<char>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetChar_throws_for_one_DateTimeOffset() => TestException(DbType.DateTimeOffset, ValueKind.One, x => x.GetChar(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetChar_throws_for_one_DateTimeOffset_with_GetFieldValue() => TestException(DbType.DateTimeOffset, ValueKind.One, x => x.GetFieldValue<char>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetChar_throws_for_minimum_DateTimeOffset() => TestException(DbType.DateTimeOffset, ValueKind.Minimum, x => x.GetChar(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetChar_throws_for_minimum_DateTimeOffset_with_GetFieldValue() => TestException(DbType.DateTimeOffset, ValueKind.Minimum, x => x.GetFieldValue<char>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetChar_throws_for_maximum_DateTimeOffset() => TestException(DbType.DateTimeOffset, ValueKind.Maximum, x => x.GetChar(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetChar_throws_for_maximum_DateTimeOffset_with_GetFieldValue() => TestException(DbType.DateTimeOffset, ValueKind.Maximum, x => x.GetFieldValue<char>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetChar_throws_for_zero_Decimal() => TestException(DbType.Decimal, ValueKind.Zero, x => x.GetChar(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetChar_throws_for_zero_Decimal_with_GetFieldValue() => TestException(DbType.Decimal, ValueKind.Zero, x => x.GetFieldValue<char>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetChar_throws_for_one_Decimal() => TestException(DbType.Decimal, ValueKind.One, x => x.GetChar(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetChar_throws_for_one_Decimal_with_GetFieldValue() => TestException(DbType.Decimal, ValueKind.One, x => x.GetFieldValue<char>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetChar_throws_for_minimum_Decimal() => TestException(DbType.Decimal, ValueKind.Minimum, x => x.GetChar(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetChar_throws_for_minimum_Decimal_with_GetFieldValue() => TestException(DbType.Decimal, ValueKind.Minimum, x => x.GetFieldValue<char>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetChar_throws_for_maximum_Decimal() => TestException(DbType.Decimal, ValueKind.Maximum, x => x.GetChar(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetChar_throws_for_maximum_Decimal_with_GetFieldValue() => TestException(DbType.Decimal, ValueKind.Maximum, x => x.GetFieldValue<char>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetChar_throws_for_zero_Double() => TestException(DbType.Double, ValueKind.Zero, x => x.GetChar(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetChar_throws_for_zero_Double_with_GetFieldValue() => TestException(DbType.Double, ValueKind.Zero, x => x.GetFieldValue<char>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetChar_throws_for_one_Double() => TestException(DbType.Double, ValueKind.One, x => x.GetChar(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetChar_throws_for_one_Double_with_GetFieldValue() => TestException(DbType.Double, ValueKind.One, x => x.GetFieldValue<char>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetChar_throws_for_minimum_Double() => TestException(DbType.Double, ValueKind.Minimum, x => x.GetChar(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetChar_throws_for_minimum_Double_with_GetFieldValue() => TestException(DbType.Double, ValueKind.Minimum, x => x.GetFieldValue<char>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetChar_throws_for_maximum_Double() => TestException(DbType.Double, ValueKind.Maximum, x => x.GetChar(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetChar_throws_for_maximum_Double_with_GetFieldValue() => TestException(DbType.Double, ValueKind.Maximum, x => x.GetFieldValue<char>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetChar_throws_for_zero_Guid() => TestException(DbType.Guid, ValueKind.Zero, x => x.GetChar(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetChar_throws_for_zero_Guid_with_GetFieldValue() => TestException(DbType.Guid, ValueKind.Zero, x => x.GetFieldValue<char>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetChar_throws_for_one_Guid() => TestException(DbType.Guid, ValueKind.One, x => x.GetChar(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetChar_throws_for_one_Guid_with_GetFieldValue() => TestException(DbType.Guid, ValueKind.One, x => x.GetFieldValue<char>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetChar_throws_for_zero_Int16() => TestException(DbType.Int16, ValueKind.Zero, x => x.GetChar(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetChar_throws_for_zero_Int16_with_GetFieldValue() => TestException(DbType.Int16, ValueKind.Zero, x => x.GetFieldValue<char>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetChar_throws_for_one_Int16() => TestException(DbType.Int16, ValueKind.One, x => x.GetChar(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetChar_throws_for_one_Int16_with_GetFieldValue() => TestException(DbType.Int16, ValueKind.One, x => x.GetFieldValue<char>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetChar_throws_for_minimum_Int16() => TestException(DbType.Int16, ValueKind.Minimum, x => x.GetChar(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetChar_throws_for_minimum_Int16_with_GetFieldValue() => TestException(DbType.Int16, ValueKind.Minimum, x => x.GetFieldValue<char>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetChar_throws_for_maximum_Int16() => TestException(DbType.Int16, ValueKind.Maximum, x => x.GetChar(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetChar_throws_for_maximum_Int16_with_GetFieldValue() => TestException(DbType.Int16, ValueKind.Maximum, x => x.GetFieldValue<char>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetChar_throws_for_zero_Int32() => TestException(DbType.Int32, ValueKind.Zero, x => x.GetChar(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetChar_throws_for_zero_Int32_with_GetFieldValue() => TestException(DbType.Int32, ValueKind.Zero, x => x.GetFieldValue<char>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetChar_throws_for_one_Int32() => TestException(DbType.Int32, ValueKind.One, x => x.GetChar(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetChar_throws_for_one_Int32_with_GetFieldValue() => TestException(DbType.Int32, ValueKind.One, x => x.GetFieldValue<char>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetChar_throws_for_minimum_Int32() => TestException(DbType.Int32, ValueKind.Minimum, x => x.GetChar(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetChar_throws_for_minimum_Int32_with_GetFieldValue() => TestException(DbType.Int32, ValueKind.Minimum, x => x.GetFieldValue<char>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetChar_throws_for_maximum_Int32() => TestException(DbType.Int32, ValueKind.Maximum, x => x.GetChar(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetChar_throws_for_maximum_Int32_with_GetFieldValue() => TestException(DbType.Int32, ValueKind.Maximum, x => x.GetFieldValue<char>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetChar_throws_for_zero_Int64() => TestException(DbType.Int64, ValueKind.Zero, x => x.GetChar(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetChar_throws_for_zero_Int64_with_GetFieldValue() => TestException(DbType.Int64, ValueKind.Zero, x => x.GetFieldValue<char>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetChar_throws_for_one_Int64() => TestException(DbType.Int64, ValueKind.One, x => x.GetChar(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetChar_throws_for_one_Int64_with_GetFieldValue() => TestException(DbType.Int64, ValueKind.One, x => x.GetFieldValue<char>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetChar_throws_for_minimum_Int64() => TestException(DbType.Int64, ValueKind.Minimum, x => x.GetChar(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetChar_throws_for_minimum_Int64_with_GetFieldValue() => TestException(DbType.Int64, ValueKind.Minimum, x => x.GetFieldValue<char>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetChar_throws_for_maximum_Int64() => TestException(DbType.Int64, ValueKind.Maximum, x => x.GetChar(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetChar_throws_for_maximum_Int64_with_GetFieldValue() => TestException(DbType.Int64, ValueKind.Maximum, x => x.GetFieldValue<char>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetChar_throws_for_zero_SByte() => TestException(DbType.SByte, ValueKind.Zero, x => x.GetChar(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetChar_throws_for_zero_SByte_with_GetFieldValue() => TestException(DbType.SByte, ValueKind.Zero, x => x.GetFieldValue<char>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetChar_throws_for_one_SByte() => TestException(DbType.SByte, ValueKind.One, x => x.GetChar(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetChar_throws_for_one_SByte_with_GetFieldValue() => TestException(DbType.SByte, ValueKind.One, x => x.GetFieldValue<char>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetChar_throws_for_minimum_SByte() => TestException(DbType.SByte, ValueKind.Minimum, x => x.GetChar(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetChar_throws_for_minimum_SByte_with_GetFieldValue() => TestException(DbType.SByte, ValueKind.Minimum, x => x.GetFieldValue<char>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetChar_throws_for_maximum_SByte() => TestException(DbType.SByte, ValueKind.Maximum, x => x.GetChar(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetChar_throws_for_maximum_SByte_with_GetFieldValue() => TestException(DbType.SByte, ValueKind.Maximum, x => x.GetFieldValue<char>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetChar_throws_for_zero_Single() => TestException(DbType.Single, ValueKind.Zero, x => x.GetChar(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetChar_throws_for_zero_Single_with_GetFieldValue() => TestException(DbType.Single, ValueKind.Zero, x => x.GetFieldValue<char>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetChar_throws_for_one_Single() => TestException(DbType.Single, ValueKind.One, x => x.GetChar(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetChar_throws_for_one_Single_with_GetFieldValue() => TestException(DbType.Single, ValueKind.One, x => x.GetFieldValue<char>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetChar_throws_for_minimum_Single() => TestException(DbType.Single, ValueKind.Minimum, x => x.GetChar(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetChar_throws_for_minimum_Single_with_GetFieldValue() => TestException(DbType.Single, ValueKind.Minimum, x => x.GetFieldValue<char>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetChar_throws_for_maximum_Single() => TestException(DbType.Single, ValueKind.Maximum, x => x.GetChar(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetChar_throws_for_maximum_Single_with_GetFieldValue() => TestException(DbType.Single, ValueKind.Maximum, x => x.GetFieldValue<char>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetChar_throws_for_empty_String() => TestException(DbType.String, ValueKind.Empty, x => x.GetChar(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetChar_throws_for_empty_String_with_GetFieldValue() => TestException(DbType.String, ValueKind.Empty, x => x.GetFieldValue<char>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetChar_for_zero_String() => TestGetValue(DbType.String, ValueKind.Zero, x => x.GetChar(0), '0');

		[SkippableFact]
		public virtual void GetChar_for_zero_String_with_GetFieldValue() => TestGetValue(DbType.String, ValueKind.Zero, x => x.GetFieldValue<char>(0), '0');

		[SkippableFact]
		public virtual void GetChar_for_one_String() => TestGetValue(DbType.String, ValueKind.One, x => x.GetChar(0), '1');

		[SkippableFact]
		public virtual void GetChar_for_one_String_with_GetFieldValue() => TestGetValue(DbType.String, ValueKind.One, x => x.GetFieldValue<char>(0), '1');

		[SkippableFact]
		public virtual void GetChar_throws_for_zero_Time() => TestException(DbType.Time, ValueKind.Zero, x => x.GetChar(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetChar_throws_for_zero_Time_with_GetFieldValue() => TestException(DbType.Time, ValueKind.Zero, x => x.GetFieldValue<char>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetChar_throws_for_one_Time() => TestException(DbType.Time, ValueKind.One, x => x.GetChar(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetChar_throws_for_one_Time_with_GetFieldValue() => TestException(DbType.Time, ValueKind.One, x => x.GetFieldValue<char>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetChar_throws_for_minimum_Time() => TestException(DbType.Time, ValueKind.Minimum, x => x.GetChar(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetChar_throws_for_minimum_Time_with_GetFieldValue() => TestException(DbType.Time, ValueKind.Minimum, x => x.GetFieldValue<char>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetChar_throws_for_maximum_Time() => TestException(DbType.Time, ValueKind.Maximum, x => x.GetChar(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetChar_throws_for_maximum_Time_with_GetFieldValue() => TestException(DbType.Time, ValueKind.Maximum, x => x.GetFieldValue<char>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetChar_throws_for_zero_UInt16() => TestException(DbType.UInt16, ValueKind.Zero, x => x.GetChar(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetChar_throws_for_zero_UInt16_with_GetFieldValue() => TestException(DbType.UInt16, ValueKind.Zero, x => x.GetFieldValue<char>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetChar_throws_for_one_UInt16() => TestException(DbType.UInt16, ValueKind.One, x => x.GetChar(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetChar_throws_for_one_UInt16_with_GetFieldValue() => TestException(DbType.UInt16, ValueKind.One, x => x.GetFieldValue<char>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetChar_throws_for_minimum_UInt16() => TestException(DbType.UInt16, ValueKind.Minimum, x => x.GetChar(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetChar_throws_for_minimum_UInt16_with_GetFieldValue() => TestException(DbType.UInt16, ValueKind.Minimum, x => x.GetFieldValue<char>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetChar_throws_for_maximum_UInt16() => TestException(DbType.UInt16, ValueKind.Maximum, x => x.GetChar(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetChar_throws_for_maximum_UInt16_with_GetFieldValue() => TestException(DbType.UInt16, ValueKind.Maximum, x => x.GetFieldValue<char>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetChar_throws_for_zero_UInt32() => TestException(DbType.UInt32, ValueKind.Zero, x => x.GetChar(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetChar_throws_for_zero_UInt32_with_GetFieldValue() => TestException(DbType.UInt32, ValueKind.Zero, x => x.GetFieldValue<char>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetChar_throws_for_one_UInt32() => TestException(DbType.UInt32, ValueKind.One, x => x.GetChar(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetChar_throws_for_one_UInt32_with_GetFieldValue() => TestException(DbType.UInt32, ValueKind.One, x => x.GetFieldValue<char>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetChar_throws_for_minimum_UInt32() => TestException(DbType.UInt32, ValueKind.Minimum, x => x.GetChar(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetChar_throws_for_minimum_UInt32_with_GetFieldValue() => TestException(DbType.UInt32, ValueKind.Minimum, x => x.GetFieldValue<char>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetChar_throws_for_maximum_UInt32() => TestException(DbType.UInt32, ValueKind.Maximum, x => x.GetChar(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetChar_throws_for_maximum_UInt32_with_GetFieldValue() => TestException(DbType.UInt32, ValueKind.Maximum, x => x.GetFieldValue<char>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetChar_throws_for_zero_UInt64() => TestException(DbType.UInt64, ValueKind.Zero, x => x.GetChar(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetChar_throws_for_zero_UInt64_with_GetFieldValue() => TestException(DbType.UInt64, ValueKind.Zero, x => x.GetFieldValue<char>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetChar_throws_for_one_UInt64() => TestException(DbType.UInt64, ValueKind.One, x => x.GetChar(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetChar_throws_for_one_UInt64_with_GetFieldValue() => TestException(DbType.UInt64, ValueKind.One, x => x.GetFieldValue<char>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetChar_throws_for_minimum_UInt64() => TestException(DbType.UInt64, ValueKind.Minimum, x => x.GetChar(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetChar_throws_for_minimum_UInt64_with_GetFieldValue() => TestException(DbType.UInt64, ValueKind.Minimum, x => x.GetFieldValue<char>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetChar_throws_for_maximum_UInt64() => TestException(DbType.UInt64, ValueKind.Maximum, x => x.GetChar(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetChar_throws_for_maximum_UInt64_with_GetFieldValue() => TestException(DbType.UInt64, ValueKind.Maximum, x => x.GetFieldValue<char>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetDateTime_throws_for_zero_Byte() => TestException(DbType.Byte, ValueKind.Zero, x => x.GetDateTime(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetDateTime_throws_for_zero_Byte_with_GetFieldValue() => TestException(DbType.Byte, ValueKind.Zero, x => x.GetFieldValue<DateTime>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetDateTime_throws_for_one_Byte() => TestException(DbType.Byte, ValueKind.One, x => x.GetDateTime(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetDateTime_throws_for_one_Byte_with_GetFieldValue() => TestException(DbType.Byte, ValueKind.One, x => x.GetFieldValue<DateTime>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetDateTime_throws_for_minimum_Byte() => TestException(DbType.Byte, ValueKind.Minimum, x => x.GetDateTime(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetDateTime_throws_for_minimum_Byte_with_GetFieldValue() => TestException(DbType.Byte, ValueKind.Minimum, x => x.GetFieldValue<DateTime>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetDateTime_throws_for_maximum_Byte() => TestException(DbType.Byte, ValueKind.Maximum, x => x.GetDateTime(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetDateTime_throws_for_maximum_Byte_with_GetFieldValue() => TestException(DbType.Byte, ValueKind.Maximum, x => x.GetFieldValue<DateTime>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetDateTime_throws_for_null_Currency() => TestException(DbType.Currency, ValueKind.Null, x => x.GetDateTime(0), Fixture.NullValueExceptionType);

		[SkippableFact]
		public virtual void GetDateTime_throws_for_null_Currency_with_GetFieldValue() => TestException(DbType.Currency, ValueKind.Null, x => x.GetFieldValue<DateTime>(0), Fixture.NullValueExceptionType);

		[SkippableFact]
		public virtual void GetDateTime_throws_for_null_Date() => TestException(DbType.Date, ValueKind.Null, x => x.GetDateTime(0), Fixture.NullValueExceptionType);

		[SkippableFact]
		public virtual void GetDateTime_throws_for_null_Date_with_GetFieldValue() => TestException(DbType.Date, ValueKind.Null, x => x.GetFieldValue<DateTime>(0), Fixture.NullValueExceptionType);

		[SkippableFact]
		public virtual void GetDateTime_for_one_Date() => TestGetValue(DbType.Date, ValueKind.One, x => x.GetDateTime(0), new DateTime(1111, 11, 11));

		[SkippableFact]
		public virtual void GetDateTime_for_one_Date_with_GetFieldValue() => TestGetValue(DbType.Date, ValueKind.One, x => x.GetFieldValue<DateTime>(0), new DateTime(1111, 11, 11));

		[SkippableFact]
		public virtual void GetDateTime_for_minimum_Date() => TestGetValue(DbType.Date, ValueKind.Minimum, x => x.GetDateTime(0), new DateTime(1, 1, 1));

		[SkippableFact]
		public virtual void GetDateTime_for_minimum_Date_with_GetFieldValue() => TestGetValue(DbType.Date, ValueKind.Minimum, x => x.GetFieldValue<DateTime>(0), new DateTime(1, 1, 1));

		[SkippableFact]
		public virtual void GetDateTime_for_maximum_Date() => TestGetValue(DbType.Date, ValueKind.Maximum, x => x.GetDateTime(0), new DateTime(9999, 12, 31));

		[SkippableFact]
		public virtual void GetDateTime_for_maximum_Date_with_GetFieldValue() => TestGetValue(DbType.Date, ValueKind.Maximum, x => x.GetFieldValue<DateTime>(0), new DateTime(9999, 12, 31));

		[SkippableFact]
		public virtual void GetDateTime_throws_for_null_DateTime() => TestException(DbType.DateTime, ValueKind.Null, x => x.GetDateTime(0), Fixture.NullValueExceptionType);

		[SkippableFact]
		public virtual void GetDateTime_throws_for_null_DateTime_with_GetFieldValue() => TestException(DbType.DateTime, ValueKind.Null, x => x.GetFieldValue<DateTime>(0), Fixture.NullValueExceptionType);

		[SkippableFact]
		public virtual void GetDateTime_for_one_DateTime() => TestGetValue(DbType.DateTime, ValueKind.One, x => x.GetDateTime(0), new DateTime(1111, 11, 11, 11, 11, 11, 111));

		[SkippableFact]
		public virtual void GetDateTime_for_one_DateTime_with_GetFieldValue() => TestGetValue(DbType.DateTime, ValueKind.One, x => x.GetFieldValue<DateTime>(0), new DateTime(1111, 11, 11, 11, 11, 11, 111));

		[SkippableFact]
		public virtual void GetDateTime_for_minimum_DateTime() => TestGetValue(DbType.DateTime, ValueKind.Minimum, x => x.GetDateTime(0), new DateTime(1, 1, 1));

		[SkippableFact]
		public virtual void GetDateTime_for_minimum_DateTime_with_GetFieldValue() => TestGetValue(DbType.DateTime, ValueKind.Minimum, x => x.GetFieldValue<DateTime>(0), new DateTime(1, 1, 1));

		[SkippableFact]
		public virtual void GetDateTime_for_maximum_DateTime() => TestGetValue(DbType.DateTime, ValueKind.Maximum, x => x.GetDateTime(0), new DateTime(9999, 12, 31, 23, 59, 59, 999));

		[SkippableFact]
		public virtual void GetDateTime_for_maximum_DateTime_with_GetFieldValue() => TestGetValue(DbType.DateTime, ValueKind.Maximum, x => x.GetFieldValue<DateTime>(0), new DateTime(9999, 12, 31, 23, 59, 59, 999));

		[SkippableFact]
		public virtual void GetDateTime_throws_for_zero_Decimal() => TestException(DbType.Decimal, ValueKind.Zero, x => x.GetDateTime(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetDateTime_throws_for_zero_Decimal_with_GetFieldValue() => TestException(DbType.Decimal, ValueKind.Zero, x => x.GetFieldValue<DateTime>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetDateTime_throws_for_one_Decimal() => TestException(DbType.Decimal, ValueKind.One, x => x.GetDateTime(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetDateTime_throws_for_one_Decimal_with_GetFieldValue() => TestException(DbType.Decimal, ValueKind.One, x => x.GetFieldValue<DateTime>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetDateTime_throws_for_minimum_Decimal() => TestException(DbType.Decimal, ValueKind.Minimum, x => x.GetDateTime(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetDateTime_throws_for_minimum_Decimal_with_GetFieldValue() => TestException(DbType.Decimal, ValueKind.Minimum, x => x.GetFieldValue<DateTime>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetDateTime_throws_for_maximum_Decimal() => TestException(DbType.Decimal, ValueKind.Maximum, x => x.GetDateTime(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetDateTime_throws_for_maximum_Decimal_with_GetFieldValue() => TestException(DbType.Decimal, ValueKind.Maximum, x => x.GetFieldValue<DateTime>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetDateTime_throws_for_zero_Double() => TestException(DbType.Double, ValueKind.Zero, x => x.GetDateTime(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetDateTime_throws_for_zero_Double_with_GetFieldValue() => TestException(DbType.Double, ValueKind.Zero, x => x.GetFieldValue<DateTime>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetDateTime_throws_for_one_Double() => TestException(DbType.Double, ValueKind.One, x => x.GetDateTime(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetDateTime_throws_for_one_Double_with_GetFieldValue() => TestException(DbType.Double, ValueKind.One, x => x.GetFieldValue<DateTime>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetDateTime_throws_for_minimum_Double() => TestException(DbType.Double, ValueKind.Minimum, x => x.GetDateTime(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetDateTime_throws_for_minimum_Double_with_GetFieldValue() => TestException(DbType.Double, ValueKind.Minimum, x => x.GetFieldValue<DateTime>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetDateTime_throws_for_maximum_Double() => TestException(DbType.Double, ValueKind.Maximum, x => x.GetDateTime(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetDateTime_throws_for_maximum_Double_with_GetFieldValue() => TestException(DbType.Double, ValueKind.Maximum, x => x.GetFieldValue<DateTime>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetDateTime_throws_for_zero_Int16() => TestException(DbType.Int16, ValueKind.Zero, x => x.GetDateTime(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetDateTime_throws_for_zero_Int16_with_GetFieldValue() => TestException(DbType.Int16, ValueKind.Zero, x => x.GetFieldValue<DateTime>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetDateTime_throws_for_one_Int16() => TestException(DbType.Int16, ValueKind.One, x => x.GetDateTime(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetDateTime_throws_for_one_Int16_with_GetFieldValue() => TestException(DbType.Int16, ValueKind.One, x => x.GetFieldValue<DateTime>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetDateTime_throws_for_minimum_Int16() => TestException(DbType.Int16, ValueKind.Minimum, x => x.GetDateTime(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetDateTime_throws_for_minimum_Int16_with_GetFieldValue() => TestException(DbType.Int16, ValueKind.Minimum, x => x.GetFieldValue<DateTime>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetDateTime_throws_for_maximum_Int16() => TestException(DbType.Int16, ValueKind.Maximum, x => x.GetDateTime(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetDateTime_throws_for_maximum_Int16_with_GetFieldValue() => TestException(DbType.Int16, ValueKind.Maximum, x => x.GetFieldValue<DateTime>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetDateTime_throws_for_zero_Int32() => TestException(DbType.Int32, ValueKind.Zero, x => x.GetDateTime(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetDateTime_throws_for_zero_Int32_with_GetFieldValue() => TestException(DbType.Int32, ValueKind.Zero, x => x.GetFieldValue<DateTime>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetDateTime_throws_for_one_Int32() => TestException(DbType.Int32, ValueKind.One, x => x.GetDateTime(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetDateTime_throws_for_one_Int32_with_GetFieldValue() => TestException(DbType.Int32, ValueKind.One, x => x.GetFieldValue<DateTime>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetDateTime_throws_for_minimum_Int32() => TestException(DbType.Int32, ValueKind.Minimum, x => x.GetDateTime(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetDateTime_throws_for_minimum_Int32_with_GetFieldValue() => TestException(DbType.Int32, ValueKind.Minimum, x => x.GetFieldValue<DateTime>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetDateTime_throws_for_maximum_Int32() => TestException(DbType.Int32, ValueKind.Maximum, x => x.GetDateTime(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetDateTime_throws_for_maximum_Int32_with_GetFieldValue() => TestException(DbType.Int32, ValueKind.Maximum, x => x.GetFieldValue<DateTime>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetDateTime_throws_for_zero_Int64() => TestException(DbType.Int64, ValueKind.Zero, x => x.GetDateTime(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetDateTime_throws_for_zero_Int64_with_GetFieldValue() => TestException(DbType.Int64, ValueKind.Zero, x => x.GetFieldValue<DateTime>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetDateTime_throws_for_one_Int64() => TestException(DbType.Int64, ValueKind.One, x => x.GetDateTime(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetDateTime_throws_for_one_Int64_with_GetFieldValue() => TestException(DbType.Int64, ValueKind.One, x => x.GetFieldValue<DateTime>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetDateTime_throws_for_minimum_Int64() => TestException(DbType.Int64, ValueKind.Minimum, x => x.GetDateTime(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetDateTime_throws_for_minimum_Int64_with_GetFieldValue() => TestException(DbType.Int64, ValueKind.Minimum, x => x.GetFieldValue<DateTime>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetDateTime_throws_for_maximum_Int64() => TestException(DbType.Int64, ValueKind.Maximum, x => x.GetDateTime(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetDateTime_throws_for_maximum_Int64_with_GetFieldValue() => TestException(DbType.Int64, ValueKind.Maximum, x => x.GetFieldValue<DateTime>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetDateTime_throws_for_zero_Single() => TestException(DbType.Single, ValueKind.Zero, x => x.GetDateTime(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetDateTime_throws_for_zero_Single_with_GetFieldValue() => TestException(DbType.Single, ValueKind.Zero, x => x.GetFieldValue<DateTime>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetDateTime_throws_for_one_Single() => TestException(DbType.Single, ValueKind.One, x => x.GetDateTime(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetDateTime_throws_for_one_Single_with_GetFieldValue() => TestException(DbType.Single, ValueKind.One, x => x.GetFieldValue<DateTime>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetDateTime_throws_for_minimum_Single() => TestException(DbType.Single, ValueKind.Minimum, x => x.GetDateTime(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetDateTime_throws_for_minimum_Single_with_GetFieldValue() => TestException(DbType.Single, ValueKind.Minimum, x => x.GetFieldValue<DateTime>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetDateTime_throws_for_maximum_Single() => TestException(DbType.Single, ValueKind.Maximum, x => x.GetDateTime(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetDateTime_throws_for_maximum_Single_with_GetFieldValue() => TestException(DbType.Single, ValueKind.Maximum, x => x.GetFieldValue<DateTime>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetDateTime_throws_for_zero_Time() => TestException(DbType.Time, ValueKind.Zero, x => x.GetDateTime(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetDateTime_throws_for_zero_Time_with_GetFieldValue() => TestException(DbType.Time, ValueKind.Zero, x => x.GetFieldValue<DateTime>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetDateTime_throws_for_one_Time() => TestException(DbType.Time, ValueKind.One, x => x.GetDateTime(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetDateTime_throws_for_one_Time_with_GetFieldValue() => TestException(DbType.Time, ValueKind.One, x => x.GetFieldValue<DateTime>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetDateTime_throws_for_minimum_Time() => TestException(DbType.Time, ValueKind.Minimum, x => x.GetDateTime(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetDateTime_throws_for_minimum_Time_with_GetFieldValue() => TestException(DbType.Time, ValueKind.Minimum, x => x.GetFieldValue<DateTime>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetDateTime_throws_for_maximum_Time() => TestException(DbType.Time, ValueKind.Maximum, x => x.GetDateTime(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetDateTime_throws_for_maximum_Time_with_GetFieldValue() => TestException(DbType.Time, ValueKind.Maximum, x => x.GetFieldValue<DateTime>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetDecimal_throws_for_null_Currency() => TestException(DbType.Currency, ValueKind.Null, x => x.GetDecimal(0), Fixture.NullValueExceptionType);

		[SkippableFact]
		public virtual void GetDecimal_throws_for_null_Currency_with_GetFieldValue() => TestException(DbType.Currency, ValueKind.Null, x => x.GetFieldValue<decimal>(0), Fixture.NullValueExceptionType);

		[SkippableFact]
		public virtual void GetDecimal_for_zero_Currency() => TestGetValue(DbType.Currency, ValueKind.Zero, x => x.GetDecimal(0), 0m);

		[SkippableFact]
		public virtual void GetDecimal_for_zero_Currency_with_GetFieldValue() => TestGetValue(DbType.Currency, ValueKind.Zero, x => x.GetFieldValue<decimal>(0), 0m);

		[SkippableFact]
		public virtual void GetDecimal_for_one_Currency() => TestGetValue(DbType.Currency, ValueKind.One, x => x.GetDecimal(0), 1m);

		[SkippableFact]
		public virtual void GetDecimal_for_one_Currency_with_GetFieldValue() => TestGetValue(DbType.Currency, ValueKind.One, x => x.GetFieldValue<decimal>(0), 1m);

		[SkippableFact]
		public virtual void GetDecimal_for_minimum_Currency() => TestGetValue(DbType.Currency, ValueKind.Minimum, x => x.GetDecimal(0), -922337203685477.5808m);

		[SkippableFact]
		public virtual void GetDecimal_for_minimum_Currency_with_GetFieldValue() => TestGetValue(DbType.Currency, ValueKind.Minimum, x => x.GetFieldValue<decimal>(0), -922337203685477.5808m);

		[SkippableFact]
		public virtual void GetDecimal_for_maximum_Currency() => TestGetValue(DbType.Currency, ValueKind.Maximum, x => x.GetDecimal(0), 922337203685477.5807m);

		[SkippableFact]
		public virtual void GetDecimal_for_maximum_Currency_with_GetFieldValue() => TestGetValue(DbType.Currency, ValueKind.Maximum, x => x.GetFieldValue<decimal>(0), 922337203685477.5807m);

		[SkippableFact]
		public virtual void GetDecimal_throws_for_null_Decimal() => TestException(DbType.Decimal, ValueKind.Null, x => x.GetDecimal(0), Fixture.NullValueExceptionType);

		[SkippableFact]
		public virtual void GetDecimal_throws_for_null_Decimal_with_GetFieldValue() => TestException(DbType.Decimal, ValueKind.Null, x => x.GetFieldValue<decimal>(0), Fixture.NullValueExceptionType);

		[SkippableFact]
		public virtual void GetDecimal_for_zero_Decimal() => TestGetValue(DbType.Decimal, ValueKind.Zero, x => x.GetDecimal(0), 0m);

		[SkippableFact]
		public virtual void GetDecimal_for_zero_Decimal_with_GetFieldValue() => TestGetValue(DbType.Decimal, ValueKind.Zero, x => x.GetFieldValue<decimal>(0), 0m);

		[SkippableFact]
		public virtual void GetDecimal_for_one_Decimal() => TestGetValue(DbType.Decimal, ValueKind.One, x => x.GetDecimal(0), 1m);

		[SkippableFact]
		public virtual void GetDecimal_for_one_Decimal_with_GetFieldValue() => TestGetValue(DbType.Decimal, ValueKind.One, x => x.GetFieldValue<decimal>(0), 1m);

		[SkippableFact]
		public virtual void GetDecimal_for_minimum_Decimal() => TestGetValue(DbType.Decimal, ValueKind.Minimum, x => x.GetDecimal(0), 0.000000000000001m);

		[SkippableFact]
		public virtual void GetDecimal_for_minimum_Decimal_with_GetFieldValue() => TestGetValue(DbType.Decimal, ValueKind.Minimum, x => x.GetFieldValue<decimal>(0), 0.000000000000001m);

		[SkippableFact]
		public virtual void GetDecimal_for_maximum_Decimal() => TestGetValue(DbType.Decimal, ValueKind.Maximum, x => x.GetDecimal(0), 99999999999999999999.999999999999999m);

		[SkippableFact]
		public virtual void GetDecimal_for_maximum_Decimal_with_GetFieldValue() => TestGetValue(DbType.Decimal, ValueKind.Maximum, x => x.GetFieldValue<decimal>(0), 99999999999999999999.999999999999999m);

		[SkippableFact]
		public virtual void GetDecimal_throws_for_zero_Double() => TestException(DbType.Double, ValueKind.Zero, x => x.GetDecimal(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetDecimal_throws_for_zero_Double_with_GetFieldValue() => TestException(DbType.Double, ValueKind.Zero, x => x.GetFieldValue<decimal>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetDecimal_throws_for_one_Double() => TestException(DbType.Double, ValueKind.One, x => x.GetDecimal(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetDecimal_throws_for_one_Double_with_GetFieldValue() => TestException(DbType.Double, ValueKind.One, x => x.GetFieldValue<decimal>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetDecimal_throws_for_minimum_Double() => TestException(DbType.Double, ValueKind.Minimum, x => x.GetDecimal(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetDecimal_throws_for_minimum_Double_with_GetFieldValue() => TestException(DbType.Double, ValueKind.Minimum, x => x.GetFieldValue<decimal>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetDecimal_throws_for_maximum_Double() => TestException(DbType.Double, ValueKind.Maximum, x => x.GetDecimal(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetDecimal_throws_for_maximum_Double_with_GetFieldValue() => TestException(DbType.Double, ValueKind.Maximum, x => x.GetFieldValue<decimal>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetDecimal_throws_for_zero_Single() => TestException(DbType.Single, ValueKind.Zero, x => x.GetDecimal(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetDecimal_throws_for_zero_Single_with_GetFieldValue() => TestException(DbType.Single, ValueKind.Zero, x => x.GetFieldValue<decimal>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetDecimal_throws_for_one_Single() => TestException(DbType.Single, ValueKind.One, x => x.GetDecimal(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetDecimal_throws_for_one_Single_with_GetFieldValue() => TestException(DbType.Single, ValueKind.One, x => x.GetFieldValue<decimal>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetDecimal_throws_for_minimum_Single() => TestException(DbType.Single, ValueKind.Minimum, x => x.GetDecimal(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetDecimal_throws_for_minimum_Single_with_GetFieldValue() => TestException(DbType.Single, ValueKind.Minimum, x => x.GetFieldValue<decimal>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetDecimal_throws_for_maximum_Single() => TestException(DbType.Single, ValueKind.Maximum, x => x.GetDecimal(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetDecimal_throws_for_maximum_Single_with_GetFieldValue() => TestException(DbType.Single, ValueKind.Maximum, x => x.GetFieldValue<decimal>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetDecimal_throws_for_empty_String() => TestException(DbType.String, ValueKind.Empty, x => x.GetDecimal(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetDecimal_throws_for_empty_String_with_GetFieldValue() => TestException(DbType.String, ValueKind.Empty, x => x.GetFieldValue<decimal>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetDecimal_throws_for_zero_String() => TestException(DbType.String, ValueKind.Zero, x => x.GetDecimal(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetDecimal_throws_for_zero_String_with_GetFieldValue() => TestException(DbType.String, ValueKind.Zero, x => x.GetFieldValue<decimal>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetDecimal_throws_for_one_String() => TestException(DbType.String, ValueKind.One, x => x.GetDecimal(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetDecimal_throws_for_one_String_with_GetFieldValue() => TestException(DbType.String, ValueKind.One, x => x.GetFieldValue<decimal>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetDouble_throws_for_null_Currency() => TestException(DbType.Currency, ValueKind.Null, x => x.GetDouble(0), Fixture.NullValueExceptionType);

		[SkippableFact]
		public virtual void GetDouble_throws_for_null_Currency_with_GetFieldValue() => TestException(DbType.Currency, ValueKind.Null, x => x.GetFieldValue<double>(0), Fixture.NullValueExceptionType);

		[SkippableFact]
		public virtual void GetDouble_for_zero_Decimal() => TestGetValue(DbType.Decimal, ValueKind.Zero, x => x.GetDouble(0), 0.0);

		[SkippableFact]
		public virtual void GetDouble_for_zero_Decimal_with_GetFieldValue() => TestGetValue(DbType.Decimal, ValueKind.Zero, x => x.GetFieldValue<double>(0), 0.0);

		[SkippableFact]
		public virtual void GetDouble_for_one_Decimal() => TestGetValue(DbType.Decimal, ValueKind.One, x => x.GetDouble(0), 1.0);

		[SkippableFact]
		public virtual void GetDouble_for_one_Decimal_with_GetFieldValue() => TestGetValue(DbType.Decimal, ValueKind.One, x => x.GetFieldValue<double>(0), 1.0);

		[SkippableFact]
		public virtual void GetDouble_for_minimum_Decimal() => TestGetValue(DbType.Decimal, ValueKind.Minimum, x => x.GetDouble(0), 0.000000000000001);

		[SkippableFact]
		public virtual void GetDouble_for_minimum_Decimal_with_GetFieldValue() => TestGetValue(DbType.Decimal, ValueKind.Minimum, x => x.GetFieldValue<double>(0), 0.000000000000001);

		[SkippableFact]
		public virtual void GetDouble_for_maximum_Decimal() => TestGetValue(DbType.Decimal, ValueKind.Maximum, x => x.GetDouble(0), 1e20);

		[SkippableFact]
		public virtual void GetDouble_for_maximum_Decimal_with_GetFieldValue() => TestGetValue(DbType.Decimal, ValueKind.Maximum, x => x.GetFieldValue<double>(0), 1e20);

		[SkippableFact]
		public virtual void GetDouble_throws_for_null_Double() => TestException(DbType.Double, ValueKind.Null, x => x.GetDouble(0), Fixture.NullValueExceptionType);

		[SkippableFact]
		public virtual void GetDouble_throws_for_null_Double_with_GetFieldValue() => TestException(DbType.Double, ValueKind.Null, x => x.GetFieldValue<double>(0), Fixture.NullValueExceptionType);

		[SkippableFact]
		public virtual void GetDouble_for_zero_Double() => TestGetValue(DbType.Double, ValueKind.Zero, x => x.GetDouble(0), 0.0);

		[SkippableFact]
		public virtual void GetDouble_for_zero_Double_with_GetFieldValue() => TestGetValue(DbType.Double, ValueKind.Zero, x => x.GetFieldValue<double>(0), 0.0);

		[SkippableFact]
		public virtual void GetDouble_for_one_Double() => TestGetValue(DbType.Double, ValueKind.One, x => x.GetDouble(0), 1.0);

		[SkippableFact]
		public virtual void GetDouble_for_one_Double_with_GetFieldValue() => TestGetValue(DbType.Double, ValueKind.One, x => x.GetFieldValue<double>(0), 1.0);

		[SkippableFact]
		public virtual void GetDouble_for_minimum_Double() => TestGetValue(DbType.Double, ValueKind.Minimum, x => x.GetDouble(0), 2.23E-308);

		[SkippableFact]
		public virtual void GetDouble_for_minimum_Double_with_GetFieldValue() => TestGetValue(DbType.Double, ValueKind.Minimum, x => x.GetFieldValue<double>(0), 2.23E-308);

		[SkippableFact]
		public virtual void GetDouble_for_maximum_Double() => TestGetValue(DbType.Double, ValueKind.Maximum, x => x.GetDouble(0), 1.79e308);

		[SkippableFact]
		public virtual void GetDouble_for_maximum_Double_with_GetFieldValue() => TestGetValue(DbType.Double, ValueKind.Maximum, x => x.GetFieldValue<double>(0), 1.79e308);

		[SkippableFact]
		public virtual void GetDouble_for_zero_Single() => TestGetValue(DbType.Single, ValueKind.Zero, x => x.GetDouble(0), 0.0);

		[SkippableFact]
		public virtual void GetDouble_for_zero_Single_with_GetFieldValue() => TestGetValue(DbType.Single, ValueKind.Zero, x => x.GetFieldValue<double>(0), 0.0);

		[SkippableFact]
		public virtual void GetDouble_for_one_Single() => TestGetValue(DbType.Single, ValueKind.One, x => x.GetDouble(0), 1.0);

		[SkippableFact]
		public virtual void GetDouble_for_one_Single_with_GetFieldValue() => TestGetValue(DbType.Single, ValueKind.One, x => x.GetFieldValue<double>(0), 1.0);

		[SkippableFact]
		public virtual void GetDouble_for_minimum_Single() => TestGetValue(DbType.Single, ValueKind.Minimum, x => x.GetDouble(0), 1.1799999457746311E-38);

		[SkippableFact]
		public virtual void GetDouble_for_minimum_Single_with_GetFieldValue() => TestGetValue(DbType.Single, ValueKind.Minimum, x => x.GetFieldValue<double>(0), 1.1799999457746311E-38);

		[SkippableFact]
		public virtual void GetDouble_for_maximum_Single() => TestGetValue(DbType.Single, ValueKind.Maximum, x => x.GetDouble(0), 3.3999999521443642E+38);

		[SkippableFact]
		public virtual void GetDouble_for_maximum_Single_with_GetFieldValue() => TestGetValue(DbType.Single, ValueKind.Maximum, x => x.GetFieldValue<double>(0), 3.3999999521443642E+38);

		[SkippableFact]
		public virtual void GetDouble_throws_for_empty_String() => TestException(DbType.String, ValueKind.Empty, x => x.GetDouble(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetDouble_throws_for_empty_String_with_GetFieldValue() => TestException(DbType.String, ValueKind.Empty, x => x.GetFieldValue<double>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetDouble_throws_for_zero_String() => TestException(DbType.String, ValueKind.Zero, x => x.GetDouble(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetDouble_throws_for_zero_String_with_GetFieldValue() => TestException(DbType.String, ValueKind.Zero, x => x.GetFieldValue<double>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetDouble_throws_for_one_String() => TestException(DbType.String, ValueKind.One, x => x.GetDouble(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetDouble_throws_for_one_String_with_GetFieldValue() => TestException(DbType.String, ValueKind.One, x => x.GetFieldValue<double>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetFloat_throws_for_null_Currency() => TestException(DbType.Currency, ValueKind.Null, x => x.GetFloat(0), Fixture.NullValueExceptionType);

		[SkippableFact]
		public virtual void GetFloat_throws_for_null_Currency_with_GetFieldValue() => TestException(DbType.Currency, ValueKind.Null, x => x.GetFieldValue<float>(0), Fixture.NullValueExceptionType);

		[SkippableFact]
		public virtual void GetFloat_for_zero_Decimal() => TestGetValue(DbType.Decimal, ValueKind.Zero, x => x.GetFloat(0), 0f);

		[SkippableFact]
		public virtual void GetFloat_for_zero_Decimal_with_GetFieldValue() => TestGetValue(DbType.Decimal, ValueKind.Zero, x => x.GetFieldValue<float>(0), 0f);

		[SkippableFact]
		public virtual void GetFloat_for_one_Decimal() => TestGetValue(DbType.Decimal, ValueKind.One, x => x.GetFloat(0), 1f);

		[SkippableFact]
		public virtual void GetFloat_for_one_Decimal_with_GetFieldValue() => TestGetValue(DbType.Decimal, ValueKind.One, x => x.GetFieldValue<float>(0), 1f);

		[SkippableFact]
		public virtual void GetFloat_for_minimum_Decimal() => TestGetValue(DbType.Decimal, ValueKind.Minimum, x => x.GetFloat(0), 0.000000000000001f);

		[SkippableFact]
		public virtual void GetFloat_for_minimum_Decimal_with_GetFieldValue() => TestGetValue(DbType.Decimal, ValueKind.Minimum, x => x.GetFieldValue<float>(0), 0.000000000000001f);

		[SkippableFact]
		public virtual void GetFloat_for_maximum_Decimal() => TestGetValue(DbType.Decimal, ValueKind.Maximum, x => x.GetFloat(0), 1e20f);

		[SkippableFact]
		public virtual void GetFloat_for_maximum_Decimal_with_GetFieldValue() => TestGetValue(DbType.Decimal, ValueKind.Maximum, x => x.GetFieldValue<float>(0), 1e20f);

		[SkippableFact]
		public virtual void GetFloat_throws_for_zero_Double() => TestException(DbType.Double, ValueKind.Zero, x => x.GetFloat(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetFloat_throws_for_zero_Double_with_GetFieldValue() => TestException(DbType.Double, ValueKind.Zero, x => x.GetFieldValue<float>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetFloat_throws_for_one_Double() => TestException(DbType.Double, ValueKind.One, x => x.GetFloat(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetFloat_throws_for_one_Double_with_GetFieldValue() => TestException(DbType.Double, ValueKind.One, x => x.GetFieldValue<float>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetFloat_throws_for_minimum_Double() => TestException(DbType.Double, ValueKind.Minimum, x => x.GetFloat(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetFloat_throws_for_minimum_Double_with_GetFieldValue() => TestException(DbType.Double, ValueKind.Minimum, x => x.GetFieldValue<float>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetFloat_throws_for_maximum_Double() => TestException(DbType.Double, ValueKind.Maximum, x => x.GetFloat(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetFloat_throws_for_maximum_Double_with_GetFieldValue() => TestException(DbType.Double, ValueKind.Maximum, x => x.GetFieldValue<float>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetFloat_throws_for_null_Single() => TestException(DbType.Single, ValueKind.Null, x => x.GetFloat(0), Fixture.NullValueExceptionType);

		[SkippableFact]
		public virtual void GetFloat_throws_for_null_Single_with_GetFieldValue() => TestException(DbType.Single, ValueKind.Null, x => x.GetFieldValue<float>(0), Fixture.NullValueExceptionType);

		[SkippableFact]
		public virtual void GetFloat_for_zero_Single() => TestGetValue(DbType.Single, ValueKind.Zero, x => x.GetFloat(0), 0f);

		[SkippableFact]
		public virtual void GetFloat_for_zero_Single_with_GetFieldValue() => TestGetValue(DbType.Single, ValueKind.Zero, x => x.GetFieldValue<float>(0), 0f);

		[SkippableFact]
		public virtual void GetFloat_for_one_Single() => TestGetValue(DbType.Single, ValueKind.One, x => x.GetFloat(0), 1f);

		[SkippableFact]
		public virtual void GetFloat_for_one_Single_with_GetFieldValue() => TestGetValue(DbType.Single, ValueKind.One, x => x.GetFieldValue<float>(0), 1f);

		[SkippableFact]
		public virtual void GetFloat_for_minimum_Single() => TestGetValue(DbType.Single, ValueKind.Minimum, x => x.GetFloat(0), 1.18E-38f);

		[SkippableFact]
		public virtual void GetFloat_for_minimum_Single_with_GetFieldValue() => TestGetValue(DbType.Single, ValueKind.Minimum, x => x.GetFieldValue<float>(0), 1.18E-38f);

		[SkippableFact]
		public virtual void GetFloat_for_maximum_Single() => TestGetValue(DbType.Single, ValueKind.Maximum, x => x.GetFloat(0), 3.40e38f);

		[SkippableFact]
		public virtual void GetFloat_for_maximum_Single_with_GetFieldValue() => TestGetValue(DbType.Single, ValueKind.Maximum, x => x.GetFieldValue<float>(0), 3.40e38f);

		[SkippableFact]
		public virtual void GetFloat_throws_for_empty_String() => TestException(DbType.String, ValueKind.Empty, x => x.GetFloat(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetFloat_throws_for_empty_String_with_GetFieldValue() => TestException(DbType.String, ValueKind.Empty, x => x.GetFieldValue<float>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetFloat_throws_for_zero_String() => TestException(DbType.String, ValueKind.Zero, x => x.GetFloat(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetFloat_throws_for_zero_String_with_GetFieldValue() => TestException(DbType.String, ValueKind.Zero, x => x.GetFieldValue<float>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetFloat_throws_for_one_String() => TestException(DbType.String, ValueKind.One, x => x.GetFloat(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetFloat_throws_for_one_String_with_GetFieldValue() => TestException(DbType.String, ValueKind.One, x => x.GetFieldValue<float>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetGuid_throws_for_zero_Byte() => TestException(DbType.Byte, ValueKind.Zero, x => x.GetGuid(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetGuid_throws_for_zero_Byte_with_GetFieldValue() => TestException(DbType.Byte, ValueKind.Zero, x => x.GetFieldValue<Guid>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetGuid_throws_for_one_Byte() => TestException(DbType.Byte, ValueKind.One, x => x.GetGuid(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetGuid_throws_for_one_Byte_with_GetFieldValue() => TestException(DbType.Byte, ValueKind.One, x => x.GetFieldValue<Guid>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetGuid_throws_for_minimum_Byte() => TestException(DbType.Byte, ValueKind.Minimum, x => x.GetGuid(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetGuid_throws_for_minimum_Byte_with_GetFieldValue() => TestException(DbType.Byte, ValueKind.Minimum, x => x.GetFieldValue<Guid>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetGuid_throws_for_maximum_Byte() => TestException(DbType.Byte, ValueKind.Maximum, x => x.GetGuid(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetGuid_throws_for_maximum_Byte_with_GetFieldValue() => TestException(DbType.Byte, ValueKind.Maximum, x => x.GetFieldValue<Guid>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetGuid_throws_for_null_Currency() => TestException(DbType.Currency, ValueKind.Null, x => x.GetGuid(0), Fixture.NullValueExceptionType);

		[SkippableFact]
		public virtual void GetGuid_throws_for_null_Currency_with_GetFieldValue() => TestException(DbType.Currency, ValueKind.Null, x => x.GetFieldValue<Guid>(0), Fixture.NullValueExceptionType);

		[SkippableFact]
		public virtual void GetGuid_throws_for_one_Date() => TestException(DbType.Date, ValueKind.One, x => x.GetGuid(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetGuid_throws_for_one_Date_with_GetFieldValue() => TestException(DbType.Date, ValueKind.One, x => x.GetFieldValue<Guid>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetGuid_throws_for_minimum_Date() => TestException(DbType.Date, ValueKind.Minimum, x => x.GetGuid(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetGuid_throws_for_minimum_Date_with_GetFieldValue() => TestException(DbType.Date, ValueKind.Minimum, x => x.GetFieldValue<Guid>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetGuid_throws_for_maximum_Date() => TestException(DbType.Date, ValueKind.Maximum, x => x.GetGuid(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetGuid_throws_for_maximum_Date_with_GetFieldValue() => TestException(DbType.Date, ValueKind.Maximum, x => x.GetFieldValue<Guid>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetGuid_throws_for_one_DateTime() => TestException(DbType.DateTime, ValueKind.One, x => x.GetGuid(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetGuid_throws_for_one_DateTime_with_GetFieldValue() => TestException(DbType.DateTime, ValueKind.One, x => x.GetFieldValue<Guid>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetGuid_throws_for_minimum_DateTime() => TestException(DbType.DateTime, ValueKind.Minimum, x => x.GetGuid(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetGuid_throws_for_minimum_DateTime_with_GetFieldValue() => TestException(DbType.DateTime, ValueKind.Minimum, x => x.GetFieldValue<Guid>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetGuid_throws_for_maximum_DateTime() => TestException(DbType.DateTime, ValueKind.Maximum, x => x.GetGuid(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetGuid_throws_for_maximum_DateTime_with_GetFieldValue() => TestException(DbType.DateTime, ValueKind.Maximum, x => x.GetFieldValue<Guid>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetGuid_throws_for_one_DateTimeOffset() => TestException(DbType.DateTimeOffset, ValueKind.One, x => x.GetGuid(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetGuid_throws_for_one_DateTimeOffset_with_GetFieldValue() => TestException(DbType.DateTimeOffset, ValueKind.One, x => x.GetFieldValue<Guid>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetGuid_throws_for_minimum_DateTimeOffset() => TestException(DbType.DateTimeOffset, ValueKind.Minimum, x => x.GetGuid(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetGuid_throws_for_minimum_DateTimeOffset_with_GetFieldValue() => TestException(DbType.DateTimeOffset, ValueKind.Minimum, x => x.GetFieldValue<Guid>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetGuid_throws_for_maximum_DateTimeOffset() => TestException(DbType.DateTimeOffset, ValueKind.Maximum, x => x.GetGuid(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetGuid_throws_for_maximum_DateTimeOffset_with_GetFieldValue() => TestException(DbType.DateTimeOffset, ValueKind.Maximum, x => x.GetFieldValue<Guid>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetGuid_throws_for_zero_Decimal() => TestException(DbType.Decimal, ValueKind.Zero, x => x.GetGuid(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetGuid_throws_for_zero_Decimal_with_GetFieldValue() => TestException(DbType.Decimal, ValueKind.Zero, x => x.GetFieldValue<Guid>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetGuid_throws_for_one_Decimal() => TestException(DbType.Decimal, ValueKind.One, x => x.GetGuid(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetGuid_throws_for_one_Decimal_with_GetFieldValue() => TestException(DbType.Decimal, ValueKind.One, x => x.GetFieldValue<Guid>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetGuid_throws_for_minimum_Decimal() => TestException(DbType.Decimal, ValueKind.Minimum, x => x.GetGuid(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetGuid_throws_for_minimum_Decimal_with_GetFieldValue() => TestException(DbType.Decimal, ValueKind.Minimum, x => x.GetFieldValue<Guid>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetGuid_throws_for_maximum_Decimal() => TestException(DbType.Decimal, ValueKind.Maximum, x => x.GetGuid(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetGuid_throws_for_maximum_Decimal_with_GetFieldValue() => TestException(DbType.Decimal, ValueKind.Maximum, x => x.GetFieldValue<Guid>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetGuid_throws_for_zero_Double() => TestException(DbType.Double, ValueKind.Zero, x => x.GetGuid(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetGuid_throws_for_zero_Double_with_GetFieldValue() => TestException(DbType.Double, ValueKind.Zero, x => x.GetFieldValue<Guid>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetGuid_throws_for_one_Double() => TestException(DbType.Double, ValueKind.One, x => x.GetGuid(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetGuid_throws_for_one_Double_with_GetFieldValue() => TestException(DbType.Double, ValueKind.One, x => x.GetFieldValue<Guid>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetGuid_throws_for_minimum_Double() => TestException(DbType.Double, ValueKind.Minimum, x => x.GetGuid(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetGuid_throws_for_minimum_Double_with_GetFieldValue() => TestException(DbType.Double, ValueKind.Minimum, x => x.GetFieldValue<Guid>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetGuid_throws_for_maximum_Double() => TestException(DbType.Double, ValueKind.Maximum, x => x.GetGuid(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetGuid_throws_for_maximum_Double_with_GetFieldValue() => TestException(DbType.Double, ValueKind.Maximum, x => x.GetFieldValue<Guid>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetGuid_throws_for_null_Guid() => TestException(DbType.Guid, ValueKind.Null, x => x.GetGuid(0), Fixture.NullValueExceptionType);

		[SkippableFact]
		public virtual void GetGuid_throws_for_null_Guid_with_GetFieldValue() => TestException(DbType.Guid, ValueKind.Null, x => x.GetFieldValue<Guid>(0), Fixture.NullValueExceptionType);

		[SkippableFact]
		public virtual void GetGuid_for_zero_Guid() => TestGetValue(DbType.Guid, ValueKind.Zero, x => x.GetGuid(0), new Guid());

		[SkippableFact]
		public virtual void GetGuid_for_zero_Guid_with_GetFieldValue() => TestGetValue(DbType.Guid, ValueKind.Zero, x => x.GetFieldValue<Guid>(0), new Guid());

		[SkippableFact]
		public virtual void GetGuid_for_one_Guid() => TestGetValue(DbType.Guid, ValueKind.One, x => x.GetGuid(0), new Guid("11111111-1111-1111-1111-111111111111"));

		[SkippableFact]
		public virtual void GetGuid_for_one_Guid_with_GetFieldValue() => TestGetValue(DbType.Guid, ValueKind.One, x => x.GetFieldValue<Guid>(0), new Guid("11111111-1111-1111-1111-111111111111"));

		[SkippableFact]
		public virtual void GetGuid_for_minimum_Guid() => TestGetValue(DbType.Guid, ValueKind.Minimum, x => x.GetGuid(0), new Guid("33221100-5544-7766-9988-aabbccddeeff"));

		[SkippableFact]
		public virtual void GetGuid_for_minimum_Guid_with_GetFieldValue() => TestGetValue(DbType.Guid, ValueKind.Minimum, x => x.GetFieldValue<Guid>(0), new Guid("33221100-5544-7766-9988-aabbccddeeff"));

		[SkippableFact]
		public virtual void GetGuid_for_maximum_Guid() => TestGetValue(DbType.Guid, ValueKind.Maximum, x => x.GetGuid(0), new Guid("ccddeeff-aabb-8899-7766-554433221100"));

		[SkippableFact]
		public virtual void GetGuid_for_maximum_Guid_with_GetFieldValue() => TestGetValue(DbType.Guid, ValueKind.Maximum, x => x.GetFieldValue<Guid>(0), new Guid("ccddeeff-aabb-8899-7766-554433221100"));

		[SkippableFact]
		public virtual void GetGuid_throws_for_zero_Int16() => TestException(DbType.Int16, ValueKind.Zero, x => x.GetGuid(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetGuid_throws_for_zero_Int16_with_GetFieldValue() => TestException(DbType.Int16, ValueKind.Zero, x => x.GetFieldValue<Guid>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetGuid_throws_for_one_Int16() => TestException(DbType.Int16, ValueKind.One, x => x.GetGuid(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetGuid_throws_for_one_Int16_with_GetFieldValue() => TestException(DbType.Int16, ValueKind.One, x => x.GetFieldValue<Guid>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetGuid_throws_for_minimum_Int16() => TestException(DbType.Int16, ValueKind.Minimum, x => x.GetGuid(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetGuid_throws_for_minimum_Int16_with_GetFieldValue() => TestException(DbType.Int16, ValueKind.Minimum, x => x.GetFieldValue<Guid>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetGuid_throws_for_maximum_Int16() => TestException(DbType.Int16, ValueKind.Maximum, x => x.GetGuid(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetGuid_throws_for_maximum_Int16_with_GetFieldValue() => TestException(DbType.Int16, ValueKind.Maximum, x => x.GetFieldValue<Guid>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetGuid_throws_for_zero_Int32() => TestException(DbType.Int32, ValueKind.Zero, x => x.GetGuid(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetGuid_throws_for_zero_Int32_with_GetFieldValue() => TestException(DbType.Int32, ValueKind.Zero, x => x.GetFieldValue<Guid>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetGuid_throws_for_one_Int32() => TestException(DbType.Int32, ValueKind.One, x => x.GetGuid(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetGuid_throws_for_one_Int32_with_GetFieldValue() => TestException(DbType.Int32, ValueKind.One, x => x.GetFieldValue<Guid>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetGuid_throws_for_minimum_Int32() => TestException(DbType.Int32, ValueKind.Minimum, x => x.GetGuid(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetGuid_throws_for_minimum_Int32_with_GetFieldValue() => TestException(DbType.Int32, ValueKind.Minimum, x => x.GetFieldValue<Guid>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetGuid_throws_for_maximum_Int32() => TestException(DbType.Int32, ValueKind.Maximum, x => x.GetGuid(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetGuid_throws_for_maximum_Int32_with_GetFieldValue() => TestException(DbType.Int32, ValueKind.Maximum, x => x.GetFieldValue<Guid>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetGuid_throws_for_zero_Int64() => TestException(DbType.Int64, ValueKind.Zero, x => x.GetGuid(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetGuid_throws_for_zero_Int64_with_GetFieldValue() => TestException(DbType.Int64, ValueKind.Zero, x => x.GetFieldValue<Guid>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetGuid_throws_for_one_Int64() => TestException(DbType.Int64, ValueKind.One, x => x.GetGuid(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetGuid_throws_for_one_Int64_with_GetFieldValue() => TestException(DbType.Int64, ValueKind.One, x => x.GetFieldValue<Guid>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetGuid_throws_for_minimum_Int64() => TestException(DbType.Int64, ValueKind.Minimum, x => x.GetGuid(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetGuid_throws_for_minimum_Int64_with_GetFieldValue() => TestException(DbType.Int64, ValueKind.Minimum, x => x.GetFieldValue<Guid>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetGuid_throws_for_maximum_Int64() => TestException(DbType.Int64, ValueKind.Maximum, x => x.GetGuid(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetGuid_throws_for_maximum_Int64_with_GetFieldValue() => TestException(DbType.Int64, ValueKind.Maximum, x => x.GetFieldValue<Guid>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetGuid_throws_for_zero_Single() => TestException(DbType.Single, ValueKind.Zero, x => x.GetGuid(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetGuid_throws_for_zero_Single_with_GetFieldValue() => TestException(DbType.Single, ValueKind.Zero, x => x.GetFieldValue<Guid>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetGuid_throws_for_one_Single() => TestException(DbType.Single, ValueKind.One, x => x.GetGuid(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetGuid_throws_for_one_Single_with_GetFieldValue() => TestException(DbType.Single, ValueKind.One, x => x.GetFieldValue<Guid>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetGuid_throws_for_minimum_Single() => TestException(DbType.Single, ValueKind.Minimum, x => x.GetGuid(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetGuid_throws_for_minimum_Single_with_GetFieldValue() => TestException(DbType.Single, ValueKind.Minimum, x => x.GetFieldValue<Guid>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetGuid_throws_for_maximum_Single() => TestException(DbType.Single, ValueKind.Maximum, x => x.GetGuid(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetGuid_throws_for_maximum_Single_with_GetFieldValue() => TestException(DbType.Single, ValueKind.Maximum, x => x.GetFieldValue<Guid>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetGuid_throws_for_zero_Time() => TestException(DbType.Time, ValueKind.Zero, x => x.GetGuid(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetGuid_throws_for_zero_Time_with_GetFieldValue() => TestException(DbType.Time, ValueKind.Zero, x => x.GetFieldValue<Guid>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetGuid_throws_for_one_Time() => TestException(DbType.Time, ValueKind.One, x => x.GetGuid(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetGuid_throws_for_one_Time_with_GetFieldValue() => TestException(DbType.Time, ValueKind.One, x => x.GetFieldValue<Guid>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetGuid_throws_for_minimum_Time() => TestException(DbType.Time, ValueKind.Minimum, x => x.GetGuid(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetGuid_throws_for_minimum_Time_with_GetFieldValue() => TestException(DbType.Time, ValueKind.Minimum, x => x.GetFieldValue<Guid>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetGuid_throws_for_maximum_Time() => TestException(DbType.Time, ValueKind.Maximum, x => x.GetGuid(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetGuid_throws_for_maximum_Time_with_GetFieldValue() => TestException(DbType.Time, ValueKind.Maximum, x => x.GetFieldValue<Guid>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetInt16_throws_for_null_Currency() => TestException(DbType.Currency, ValueKind.Null, x => x.GetInt16(0), Fixture.NullValueExceptionType);

		[SkippableFact]
		public virtual void GetInt16_throws_for_null_Currency_with_GetFieldValue() => TestException(DbType.Currency, ValueKind.Null, x => x.GetFieldValue<short>(0), Fixture.NullValueExceptionType);

		[SkippableFact]
		public virtual void GetInt16_throws_for_null_Int16() => TestException(DbType.Int16, ValueKind.Null, x => x.GetInt16(0), Fixture.NullValueExceptionType);

		[SkippableFact]
		public virtual void GetInt16_throws_for_null_Int16_with_GetFieldValue() => TestException(DbType.Int16, ValueKind.Null, x => x.GetFieldValue<short>(0), Fixture.NullValueExceptionType);

		[SkippableFact]
		public virtual void GetInt16_for_zero_Int16() => TestGetValue(DbType.Int16, ValueKind.Zero, x => x.GetInt16(0), (short) 0);

		[SkippableFact]
		public virtual void GetInt16_for_zero_Int16_with_GetFieldValue() => TestGetValue(DbType.Int16, ValueKind.Zero, x => x.GetFieldValue<short>(0), (short) 0);

		[SkippableFact]
		public virtual void GetInt16_for_one_Int16() => TestGetValue(DbType.Int16, ValueKind.One, x => x.GetInt16(0), (short) 1);

		[SkippableFact]
		public virtual void GetInt16_for_one_Int16_with_GetFieldValue() => TestGetValue(DbType.Int16, ValueKind.One, x => x.GetFieldValue<short>(0), (short) 1);

		[SkippableFact]
		public virtual void GetInt16_for_minimum_Int16() => TestGetValue(DbType.Int16, ValueKind.Minimum, x => x.GetInt16(0), (short) -32768);

		[SkippableFact]
		public virtual void GetInt16_for_minimum_Int16_with_GetFieldValue() => TestGetValue(DbType.Int16, ValueKind.Minimum, x => x.GetFieldValue<short>(0), (short) -32768);

		[SkippableFact]
		public virtual void GetInt16_for_maximum_Int16() => TestGetValue(DbType.Int16, ValueKind.Maximum, x => x.GetInt16(0), (short) 32767);

		[SkippableFact]
		public virtual void GetInt16_for_maximum_Int16_with_GetFieldValue() => TestGetValue(DbType.Int16, ValueKind.Maximum, x => x.GetFieldValue<short>(0), (short) 32767);

		[SkippableFact]
		public virtual void GetInt16_for_zero_Int32() => TestGetValue(DbType.Int32, ValueKind.Zero, x => x.GetInt16(0), (short) 0);

		[SkippableFact]
		public virtual void GetInt16_for_zero_Int32_with_GetFieldValue() => TestGetValue(DbType.Int32, ValueKind.Zero, x => x.GetFieldValue<short>(0), (short) 0);

		[SkippableFact]
		public virtual void GetInt16_for_one_Int32() => TestGetValue(DbType.Int32, ValueKind.One, x => x.GetInt16(0), (short) 1);

		[SkippableFact]
		public virtual void GetInt16_for_one_Int32_with_GetFieldValue() => TestGetValue(DbType.Int32, ValueKind.One, x => x.GetFieldValue<short>(0), (short) 1);

		[SkippableFact]
		public virtual void GetInt16_throws_for_minimum_Int32() => TestException(DbType.Int32, ValueKind.Minimum, x => x.GetInt16(0), typeof(OverflowException));

		[SkippableFact]
		public virtual void GetInt16_throws_for_minimum_Int32_with_GetFieldValue() => TestException(DbType.Int32, ValueKind.Minimum, x => x.GetFieldValue<short>(0), typeof(OverflowException));

		[SkippableFact]
		public virtual void GetInt16_throws_for_maximum_Int32() => TestException(DbType.Int32, ValueKind.Maximum, x => x.GetInt16(0), typeof(OverflowException));

		[SkippableFact]
		public virtual void GetInt16_throws_for_maximum_Int32_with_GetFieldValue() => TestException(DbType.Int32, ValueKind.Maximum, x => x.GetFieldValue<short>(0), typeof(OverflowException));

		[SkippableFact]
		public virtual void GetInt16_for_zero_Int64() => TestGetValue(DbType.Int64, ValueKind.Zero, x => x.GetInt16(0), (short) 0);

		[SkippableFact]
		public virtual void GetInt16_for_zero_Int64_with_GetFieldValue() => TestGetValue(DbType.Int64, ValueKind.Zero, x => x.GetFieldValue<short>(0), (short) 0);

		[SkippableFact]
		public virtual void GetInt16_for_one_Int64() => TestGetValue(DbType.Int64, ValueKind.One, x => x.GetInt16(0), (short) 1);

		[SkippableFact]
		public virtual void GetInt16_for_one_Int64_with_GetFieldValue() => TestGetValue(DbType.Int64, ValueKind.One, x => x.GetFieldValue<short>(0), (short) 1);

		[SkippableFact]
		public virtual void GetInt16_throws_for_minimum_Int64() => TestException(DbType.Int64, ValueKind.Minimum, x => x.GetInt16(0), typeof(OverflowException));

		[SkippableFact]
		public virtual void GetInt16_throws_for_minimum_Int64_with_GetFieldValue() => TestException(DbType.Int64, ValueKind.Minimum, x => x.GetFieldValue<short>(0), typeof(OverflowException));

		[SkippableFact]
		public virtual void GetInt16_throws_for_maximum_Int64() => TestException(DbType.Int64, ValueKind.Maximum, x => x.GetInt16(0), typeof(OverflowException));

		[SkippableFact]
		public virtual void GetInt16_throws_for_maximum_Int64_with_GetFieldValue() => TestException(DbType.Int64, ValueKind.Maximum, x => x.GetFieldValue<short>(0), typeof(OverflowException));

		[SkippableFact]
		public virtual void GetInt16_throws_for_empty_String() => TestException(DbType.String, ValueKind.Empty, x => x.GetInt16(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetInt16_throws_for_empty_String_with_GetFieldValue() => TestException(DbType.String, ValueKind.Empty, x => x.GetFieldValue<short>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetInt16_throws_for_zero_String() => TestException(DbType.String, ValueKind.Zero, x => x.GetInt16(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetInt16_throws_for_zero_String_with_GetFieldValue() => TestException(DbType.String, ValueKind.Zero, x => x.GetFieldValue<short>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetInt16_throws_for_one_String() => TestException(DbType.String, ValueKind.One, x => x.GetInt16(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetInt16_throws_for_one_String_with_GetFieldValue() => TestException(DbType.String, ValueKind.One, x => x.GetFieldValue<short>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetInt16_for_zero_UInt16() => TestGetValue(DbType.UInt16, ValueKind.Zero, x => x.GetInt16(0), 0);

		[SkippableFact]
		public virtual void GetInt16_for_zero_UInt16_with_GetFieldValue() => TestGetValue(DbType.UInt16, ValueKind.Zero, x => x.GetFieldValue<short>(0), 0);

		[SkippableFact]
		public virtual void GetInt16_for_one_UInt16() => TestGetValue(DbType.UInt16, ValueKind.One, x => x.GetInt16(0), 1);

		[SkippableFact]
		public virtual void GetInt16_for_one_UInt16_with_GetFieldValue() => TestGetValue(DbType.UInt16, ValueKind.One, x => x.GetFieldValue<short>(0), 1);

		[SkippableFact]
		public virtual void GetInt16_for_minimum_UInt16() => TestGetValue(DbType.UInt16, ValueKind.Minimum, x => x.GetInt16(0), 0);

		[SkippableFact]
		public virtual void GetInt16_for_minimum_UInt16_with_GetFieldValue() => TestGetValue(DbType.UInt16, ValueKind.Minimum, x => x.GetFieldValue<short>(0), 0);

		[SkippableFact]
		public virtual void GetInt16_throws_for_maximum_UInt16() => TestException(DbType.UInt16, ValueKind.Maximum, x => x.GetInt16(0), typeof(OverflowException));

		[SkippableFact]
		public virtual void GetInt16_throws_for_maximum_UInt16_with_GetFieldValue() => TestException(DbType.UInt16, ValueKind.Maximum, x => x.GetFieldValue<short>(0), typeof(OverflowException));

		[SkippableFact]
		public virtual void GetInt32_throws_for_null_Currency() => TestException(DbType.Currency, ValueKind.Null, x => x.GetInt32(0), Fixture.NullValueExceptionType);

		[SkippableFact]
		public virtual void GetInt32_throws_for_null_Currency_with_GetFieldValue() => TestException(DbType.Currency, ValueKind.Null, x => x.GetFieldValue<int>(0), Fixture.NullValueExceptionType);

		[SkippableFact]
		public virtual void GetInt32_for_zero_Int16() => TestGetValue(DbType.Int16, ValueKind.Zero, x => x.GetInt32(0), 0);

		[SkippableFact]
		public virtual void GetInt32_for_zero_Int16_with_GetFieldValue() => TestGetValue(DbType.Int16, ValueKind.Zero, x => x.GetFieldValue<int>(0), 0);

		[SkippableFact]
		public virtual void GetInt32_for_one_Int16() => TestGetValue(DbType.Int16, ValueKind.One, x => x.GetInt32(0), 1);

		[SkippableFact]
		public virtual void GetInt32_for_one_Int16_with_GetFieldValue() => TestGetValue(DbType.Int16, ValueKind.One, x => x.GetFieldValue<int>(0), 1);

		[SkippableFact]
		public virtual void GetInt32_for_minimum_Int16() => TestGetValue(DbType.Int16, ValueKind.Minimum, x => x.GetInt32(0), -32768);

		[SkippableFact]
		public virtual void GetInt32_for_minimum_Int16_with_GetFieldValue() => TestGetValue(DbType.Int16, ValueKind.Minimum, x => x.GetFieldValue<int>(0), -32768);

		[SkippableFact]
		public virtual void GetInt32_for_maximum_Int16() => TestGetValue(DbType.Int16, ValueKind.Maximum, x => x.GetInt32(0), 32767);

		[SkippableFact]
		public virtual void GetInt32_for_maximum_Int16_with_GetFieldValue() => TestGetValue(DbType.Int16, ValueKind.Maximum, x => x.GetFieldValue<int>(0), 32767);

		[SkippableFact]
		public virtual void GetInt32_throws_for_null_Int32() => TestException(DbType.Int32, ValueKind.Null, x => x.GetInt32(0), Fixture.NullValueExceptionType);

		[SkippableFact]
		public virtual void GetInt32_throws_for_null_Int32_with_GetFieldValue() => TestException(DbType.Int32, ValueKind.Null, x => x.GetFieldValue<int>(0), Fixture.NullValueExceptionType);

		[SkippableFact]
		public virtual void GetInt32_for_zero_Int32() => TestGetValue(DbType.Int32, ValueKind.Zero, x => x.GetInt32(0), 0);

		[SkippableFact]
		public virtual void GetInt32_for_zero_Int32_with_GetFieldValue() => TestGetValue(DbType.Int32, ValueKind.Zero, x => x.GetFieldValue<int>(0), 0);

		[SkippableFact]
		public virtual void GetInt32_for_one_Int32() => TestGetValue(DbType.Int32, ValueKind.One, x => x.GetInt32(0), 1);

		[SkippableFact]
		public virtual void GetInt32_for_one_Int32_with_GetFieldValue() => TestGetValue(DbType.Int32, ValueKind.One, x => x.GetFieldValue<int>(0), 1);

		[SkippableFact]
		public virtual void GetInt32_for_minimum_Int32() => TestGetValue(DbType.Int32, ValueKind.Minimum, x => x.GetInt32(0), -2147483648);

		[SkippableFact]
		public virtual void GetInt32_for_minimum_Int32_with_GetFieldValue() => TestGetValue(DbType.Int32, ValueKind.Minimum, x => x.GetFieldValue<int>(0), -2147483648);

		[SkippableFact]
		public virtual void GetInt32_for_maximum_Int32() => TestGetValue(DbType.Int32, ValueKind.Maximum, x => x.GetInt32(0), 2147483647);

		[SkippableFact]
		public virtual void GetInt32_for_maximum_Int32_with_GetFieldValue() => TestGetValue(DbType.Int32, ValueKind.Maximum, x => x.GetFieldValue<int>(0), 2147483647);

		[SkippableFact]
		public virtual void GetInt32_for_zero_Int64() => TestGetValue(DbType.Int64, ValueKind.Zero, x => x.GetInt32(0), 0);

		[SkippableFact]
		public virtual void GetInt32_for_zero_Int64_with_GetFieldValue() => TestGetValue(DbType.Int64, ValueKind.Zero, x => x.GetFieldValue<int>(0), 0);

		[SkippableFact]
		public virtual void GetInt32_for_one_Int64() => TestGetValue(DbType.Int64, ValueKind.One, x => x.GetInt32(0), 1);

		[SkippableFact]
		public virtual void GetInt32_for_one_Int64_with_GetFieldValue() => TestGetValue(DbType.Int64, ValueKind.One, x => x.GetFieldValue<int>(0), 1);

		[SkippableFact]
		public virtual void GetInt32_throws_for_minimum_Int64() => TestException(DbType.Int64, ValueKind.Minimum, x => x.GetInt32(0), typeof(OverflowException));

		[SkippableFact]
		public virtual void GetInt32_throws_for_minimum_Int64_with_GetFieldValue() => TestException(DbType.Int64, ValueKind.Minimum, x => x.GetFieldValue<int>(0), typeof(OverflowException));

		[SkippableFact]
		public virtual void GetInt32_throws_for_maximum_Int64() => TestException(DbType.Int64, ValueKind.Maximum, x => x.GetInt32(0), typeof(OverflowException));

		[SkippableFact]
		public virtual void GetInt32_throws_for_maximum_Int64_with_GetFieldValue() => TestException(DbType.Int64, ValueKind.Maximum, x => x.GetFieldValue<int>(0), typeof(OverflowException));

		[SkippableFact]
		public virtual void GetInt32_throws_for_empty_String() => TestException(DbType.String, ValueKind.Empty, x => x.GetInt32(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetInt32_throws_for_empty_String_with_GetFieldValue() => TestException(DbType.String, ValueKind.Empty, x => x.GetFieldValue<int>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetInt32_throws_for_zero_String() => TestException(DbType.String, ValueKind.Zero, x => x.GetInt32(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetInt32_throws_for_zero_String_with_GetFieldValue() => TestException(DbType.String, ValueKind.Zero, x => x.GetFieldValue<int>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetInt32_throws_for_one_String() => TestException(DbType.String, ValueKind.One, x => x.GetInt32(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetInt32_throws_for_one_String_with_GetFieldValue() => TestException(DbType.String, ValueKind.One, x => x.GetFieldValue<int>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetInt32_for_zero_UInt16() => TestGetValue(DbType.UInt16, ValueKind.Zero, x => x.GetInt32(0), 0);

		[SkippableFact]
		public virtual void GetInt32_for_zero_UInt16_with_GetFieldValue() => TestGetValue(DbType.UInt16, ValueKind.Zero, x => x.GetFieldValue<int>(0), 0);

		[SkippableFact]
		public virtual void GetInt32_for_one_UInt16() => TestGetValue(DbType.UInt16, ValueKind.One, x => x.GetInt32(0), 1);

		[SkippableFact]
		public virtual void GetInt32_for_one_UInt16_with_GetFieldValue() => TestGetValue(DbType.UInt16, ValueKind.One, x => x.GetFieldValue<int>(0), 1);

		[SkippableFact]
		public virtual void GetInt32_for_minimum_UInt16() => TestGetValue(DbType.UInt16, ValueKind.Minimum, x => x.GetInt32(0), 0);

		[SkippableFact]
		public virtual void GetInt32_for_minimum_UInt16_with_GetFieldValue() => TestGetValue(DbType.UInt16, ValueKind.Minimum, x => x.GetFieldValue<int>(0), 0);

		[SkippableFact]
		public virtual void GetInt32_for_maximum_UInt16() => TestGetValue(DbType.UInt16, ValueKind.Maximum, x => x.GetInt32(0), 65535);

		[SkippableFact]
		public virtual void GetInt32_for_maximum_UInt16_with_GetFieldValue() => TestGetValue(DbType.UInt16, ValueKind.Maximum, x => x.GetFieldValue<int>(0), 65535);

		[SkippableFact]
		public virtual void GetInt32_for_zero_UInt32() => TestGetValue(DbType.UInt32, ValueKind.Zero, x => x.GetInt32(0), 0);

		[SkippableFact]
		public virtual void GetInt32_for_zero_UInt32_with_GetFieldValue() => TestGetValue(DbType.UInt32, ValueKind.Zero, x => x.GetFieldValue<int>(0), 0);

		[SkippableFact]
		public virtual void GetInt32_for_one_UInt32() => TestGetValue(DbType.UInt32, ValueKind.One, x => x.GetInt32(0), 1);

		[SkippableFact]
		public virtual void GetInt32_for_one_UInt32_with_GetFieldValue() => TestGetValue(DbType.UInt32, ValueKind.One, x => x.GetFieldValue<int>(0), 1);

		[SkippableFact]
		public virtual void GetInt32_for_minimum_UInt32() => TestGetValue(DbType.UInt32, ValueKind.Minimum, x => x.GetInt32(0), 0);

		[SkippableFact]
		public virtual void GetInt32_for_minimum_UInt32_with_GetFieldValue() => TestGetValue(DbType.UInt32, ValueKind.Minimum, x => x.GetFieldValue<int>(0), 0);

		[SkippableFact]
		public virtual void GetInt32_throws_for_maximum_UInt32() => TestException(DbType.UInt32, ValueKind.Maximum, x => x.GetInt32(0), typeof(OverflowException));

		[SkippableFact]
		public virtual void GetInt32_throws_for_maximum_UInt32_with_GetFieldValue() => TestException(DbType.UInt32, ValueKind.Maximum, x => x.GetFieldValue<int>(0), typeof(OverflowException));

		[SkippableFact]
		public virtual void GetInt64_throws_for_null_Currency() => TestException(DbType.Currency, ValueKind.Null, x => x.GetInt64(0), Fixture.NullValueExceptionType);

		[SkippableFact]
		public virtual void GetInt64_throws_for_null_Currency_with_GetFieldValue() => TestException(DbType.Currency, ValueKind.Null, x => x.GetFieldValue<long>(0), Fixture.NullValueExceptionType);

		[SkippableFact]
		public virtual void GetInt64_for_zero_Int16() => TestGetValue(DbType.Int16, ValueKind.Zero, x => x.GetInt64(0), 0L);

		[SkippableFact]
		public virtual void GetInt64_for_zero_Int16_with_GetFieldValue() => TestGetValue(DbType.Int16, ValueKind.Zero, x => x.GetFieldValue<long>(0), 0L);

		[SkippableFact]
		public virtual void GetInt64_for_one_Int16() => TestGetValue(DbType.Int16, ValueKind.One, x => x.GetInt64(0), 1L);

		[SkippableFact]
		public virtual void GetInt64_for_one_Int16_with_GetFieldValue() => TestGetValue(DbType.Int16, ValueKind.One, x => x.GetFieldValue<long>(0), 1L);

		[SkippableFact]
		public virtual void GetInt64_for_minimum_Int16() => TestGetValue(DbType.Int16, ValueKind.Minimum, x => x.GetInt64(0), -32768L);

		[SkippableFact]
		public virtual void GetInt64_for_minimum_Int16_with_GetFieldValue() => TestGetValue(DbType.Int16, ValueKind.Minimum, x => x.GetFieldValue<long>(0), -32768L);

		[SkippableFact]
		public virtual void GetInt64_for_maximum_Int16() => TestGetValue(DbType.Int16, ValueKind.Maximum, x => x.GetInt64(0), 32767L);

		[SkippableFact]
		public virtual void GetInt64_for_maximum_Int16_with_GetFieldValue() => TestGetValue(DbType.Int16, ValueKind.Maximum, x => x.GetFieldValue<long>(0), 32767L);

		[SkippableFact]
		public virtual void GetInt64_for_zero_Int32() => TestGetValue(DbType.Int32, ValueKind.Zero, x => x.GetInt64(0), 0L);

		[SkippableFact]
		public virtual void GetInt64_for_zero_Int32_with_GetFieldValue() => TestGetValue(DbType.Int32, ValueKind.Zero, x => x.GetFieldValue<long>(0), 0L);

		[SkippableFact]
		public virtual void GetInt64_for_one_Int32() => TestGetValue(DbType.Int32, ValueKind.One, x => x.GetInt64(0), 1L);

		[SkippableFact]
		public virtual void GetInt64_for_one_Int32_with_GetFieldValue() => TestGetValue(DbType.Int32, ValueKind.One, x => x.GetFieldValue<long>(0), 1L);

		[SkippableFact]
		public virtual void GetInt64_for_minimum_Int32() => TestGetValue(DbType.Int32, ValueKind.Minimum, x => x.GetInt64(0), -2147483648L);

		[SkippableFact]
		public virtual void GetInt64_for_minimum_Int32_with_GetFieldValue() => TestGetValue(DbType.Int32, ValueKind.Minimum, x => x.GetFieldValue<long>(0), -2147483648L);

		[SkippableFact]
		public virtual void GetInt64_for_maximum_Int32() => TestGetValue(DbType.Int32, ValueKind.Maximum, x => x.GetInt64(0), 2147483647L);

		[SkippableFact]
		public virtual void GetInt64_for_maximum_Int32_with_GetFieldValue() => TestGetValue(DbType.Int32, ValueKind.Maximum, x => x.GetFieldValue<long>(0), 2147483647L);

		[SkippableFact]
		public virtual void GetInt64_throws_for_null_Int64() => TestException(DbType.Int64, ValueKind.Null, x => x.GetInt64(0), Fixture.NullValueExceptionType);

		[SkippableFact]
		public virtual void GetInt64_throws_for_null_Int64_with_GetFieldValue() => TestException(DbType.Int64, ValueKind.Null, x => x.GetFieldValue<long>(0), Fixture.NullValueExceptionType);

		[SkippableFact]
		public virtual void GetInt64_for_zero_Int64() => TestGetValue(DbType.Int64, ValueKind.Zero, x => x.GetInt64(0), 0L);

		[SkippableFact]
		public virtual void GetInt64_for_zero_Int64_with_GetFieldValue() => TestGetValue(DbType.Int64, ValueKind.Zero, x => x.GetFieldValue<long>(0), 0L);

		[SkippableFact]
		public virtual void GetInt64_for_one_Int64() => TestGetValue(DbType.Int64, ValueKind.One, x => x.GetInt64(0), 1L);

		[SkippableFact]
		public virtual void GetInt64_for_one_Int64_with_GetFieldValue() => TestGetValue(DbType.Int64, ValueKind.One, x => x.GetFieldValue<long>(0), 1L);

		[SkippableFact]
		public virtual void GetInt64_for_minimum_Int64() => TestGetValue(DbType.Int64, ValueKind.Minimum, x => x.GetInt64(0), -9223372036854775808L);

		[SkippableFact]
		public virtual void GetInt64_for_minimum_Int64_with_GetFieldValue() => TestGetValue(DbType.Int64, ValueKind.Minimum, x => x.GetFieldValue<long>(0), -9223372036854775808L);

		[SkippableFact]
		public virtual void GetInt64_for_maximum_Int64() => TestGetValue(DbType.Int64, ValueKind.Maximum, x => x.GetInt64(0), 9223372036854775807L);

		[SkippableFact]
		public virtual void GetInt64_for_maximum_Int64_with_GetFieldValue() => TestGetValue(DbType.Int64, ValueKind.Maximum, x => x.GetFieldValue<long>(0), 9223372036854775807L);

		[SkippableFact]
		public virtual void GetInt64_throws_for_empty_String() => TestException(DbType.String, ValueKind.Empty, x => x.GetInt64(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetInt64_throws_for_empty_String_with_GetFieldValue() => TestException(DbType.String, ValueKind.Empty, x => x.GetFieldValue<long>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetInt64_throws_for_zero_String() => TestException(DbType.String, ValueKind.Zero, x => x.GetInt64(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetInt64_throws_for_zero_String_with_GetFieldValue() => TestException(DbType.String, ValueKind.Zero, x => x.GetFieldValue<long>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetInt64_throws_for_one_String() => TestException(DbType.String, ValueKind.One, x => x.GetInt64(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetInt64_throws_for_one_String_with_GetFieldValue() => TestException(DbType.String, ValueKind.One, x => x.GetFieldValue<long>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetInt64_for_zero_UInt16() => TestGetValue(DbType.UInt16, ValueKind.Zero, x => x.GetInt64(0), 0L);

		[SkippableFact]
		public virtual void GetInt64_for_zero_UInt16_with_GetFieldValue() => TestGetValue(DbType.UInt16, ValueKind.Zero, x => x.GetFieldValue<long>(0), 0L);

		[SkippableFact]
		public virtual void GetInt64_for_one_UInt16() => TestGetValue(DbType.UInt16, ValueKind.One, x => x.GetInt64(0), 1L);

		[SkippableFact]
		public virtual void GetInt64_for_one_UInt16_with_GetFieldValue() => TestGetValue(DbType.UInt16, ValueKind.One, x => x.GetFieldValue<long>(0), 1L);

		[SkippableFact]
		public virtual void GetInt64_for_minimum_UInt16() => TestGetValue(DbType.UInt16, ValueKind.Minimum, x => x.GetInt64(0), 0L);

		[SkippableFact]
		public virtual void GetInt64_for_minimum_UInt16_with_GetFieldValue() => TestGetValue(DbType.UInt16, ValueKind.Minimum, x => x.GetFieldValue<long>(0), 0L);

		[SkippableFact]
		public virtual void GetInt64_for_maximum_UInt16() => TestGetValue(DbType.UInt16, ValueKind.Maximum, x => x.GetInt64(0), 65535L);

		[SkippableFact]
		public virtual void GetInt64_for_maximum_UInt16_with_GetFieldValue() => TestGetValue(DbType.UInt16, ValueKind.Maximum, x => x.GetFieldValue<long>(0), 65535L);

		[SkippableFact]
		public virtual void GetInt64_for_zero_UInt64() => TestGetValue(DbType.UInt64, ValueKind.Zero, x => x.GetInt64(0), 0L);

		[SkippableFact]
		public virtual void GetInt64_for_zero_UInt64_with_GetFieldValue() => TestGetValue(DbType.UInt64, ValueKind.Zero, x => x.GetFieldValue<long>(0), 0L);

		[SkippableFact]
		public virtual void GetInt64_for_one_UInt64() => TestGetValue(DbType.UInt64, ValueKind.One, x => x.GetInt64(0), 1L);

		[SkippableFact]
		public virtual void GetInt64_for_one_UInt64_with_GetFieldValue() => TestGetValue(DbType.UInt64, ValueKind.One, x => x.GetFieldValue<long>(0), 1L);

		[SkippableFact]
		public virtual void GetInt64_for_minimum_UInt64() => TestGetValue(DbType.UInt64, ValueKind.Minimum, x => x.GetInt64(0), 0L);

		[SkippableFact]
		public virtual void GetInt64_for_minimum_UInt64_with_GetFieldValue() => TestGetValue(DbType.UInt64, ValueKind.Minimum, x => x.GetFieldValue<long>(0), 0L);

		[SkippableFact]
		public virtual void GetInt64_throws_for_maximum_UInt64() => TestException(DbType.UInt64, ValueKind.Maximum, x => x.GetInt64(0), typeof(OverflowException));

		[SkippableFact]
		public virtual void GetInt64_throws_for_maximum_UInt64_with_GetFieldValue() => TestException(DbType.UInt64, ValueKind.Maximum, x => x.GetFieldValue<long>(0), typeof(OverflowException));

		[SkippableFact]
		public virtual void GetString_throws_for_zero_Boolean() => TestException(DbType.Boolean, ValueKind.Zero, x => x.GetString(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetString_throws_for_zero_Boolean_with_GetFieldValue() => TestException(DbType.Boolean, ValueKind.Zero, x => x.GetFieldValue<string>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetString_throws_for_one_Boolean() => TestException(DbType.Boolean, ValueKind.One, x => x.GetString(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetString_throws_for_one_Boolean_with_GetFieldValue() => TestException(DbType.Boolean, ValueKind.One, x => x.GetFieldValue<string>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetString_throws_for_minimum_Boolean() => TestException(DbType.Boolean, ValueKind.Minimum, x => x.GetString(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetString_throws_for_minimum_Boolean_with_GetFieldValue() => TestException(DbType.Boolean, ValueKind.Minimum, x => x.GetFieldValue<string>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetString_throws_for_maximum_Boolean() => TestException(DbType.Boolean, ValueKind.Maximum, x => x.GetString(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetString_throws_for_maximum_Boolean_with_GetFieldValue() => TestException(DbType.Boolean, ValueKind.Maximum, x => x.GetFieldValue<string>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetString_throws_for_zero_Byte() => TestException(DbType.Byte, ValueKind.Zero, x => x.GetString(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetString_throws_for_zero_Byte_with_GetFieldValue() => TestException(DbType.Byte, ValueKind.Zero, x => x.GetFieldValue<string>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetString_throws_for_one_Byte() => TestException(DbType.Byte, ValueKind.One, x => x.GetString(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetString_throws_for_one_Byte_with_GetFieldValue() => TestException(DbType.Byte, ValueKind.One, x => x.GetFieldValue<string>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetString_throws_for_minimum_Byte() => TestException(DbType.Byte, ValueKind.Minimum, x => x.GetString(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetString_throws_for_minimum_Byte_with_GetFieldValue() => TestException(DbType.Byte, ValueKind.Minimum, x => x.GetFieldValue<string>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetString_throws_for_maximum_Byte() => TestException(DbType.Byte, ValueKind.Maximum, x => x.GetString(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetString_throws_for_maximum_Byte_with_GetFieldValue() => TestException(DbType.Byte, ValueKind.Maximum, x => x.GetFieldValue<string>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetString_throws_for_null_Currency() => TestException(DbType.Currency, ValueKind.Null, x => x.GetString(0), Fixture.NullValueExceptionType);

		[SkippableFact]
		public virtual void GetString_throws_for_null_Currency_with_GetFieldValue() => TestException(DbType.Currency, ValueKind.Null, x => x.GetFieldValue<string>(0), Fixture.NullValueExceptionType);

		[SkippableFact]
		public virtual void GetString_throws_for_zero_Currency() => TestException(DbType.Currency, ValueKind.Zero, x => x.GetString(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetString_throws_for_zero_Currency_with_GetFieldValue() => TestException(DbType.Currency, ValueKind.Zero, x => x.GetFieldValue<string>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetString_throws_for_one_Currency() => TestException(DbType.Currency, ValueKind.One, x => x.GetString(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetString_throws_for_one_Currency_with_GetFieldValue() => TestException(DbType.Currency, ValueKind.One, x => x.GetFieldValue<string>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetString_throws_for_minimum_Currency() => TestException(DbType.Currency, ValueKind.Minimum, x => x.GetString(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetString_throws_for_minimum_Currency_with_GetFieldValue() => TestException(DbType.Currency, ValueKind.Minimum, x => x.GetFieldValue<string>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetString_throws_for_maximum_Currency() => TestException(DbType.Currency, ValueKind.Maximum, x => x.GetString(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetString_throws_for_maximum_Currency_with_GetFieldValue() => TestException(DbType.Currency, ValueKind.Maximum, x => x.GetFieldValue<string>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetString_throws_for_zero_Decimal() => TestException(DbType.Decimal, ValueKind.Zero, x => x.GetString(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetString_throws_for_zero_Decimal_with_GetFieldValue() => TestException(DbType.Decimal, ValueKind.Zero, x => x.GetFieldValue<string>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetString_throws_for_one_Decimal() => TestException(DbType.Decimal, ValueKind.One, x => x.GetString(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetString_throws_for_one_Decimal_with_GetFieldValue() => TestException(DbType.Decimal, ValueKind.One, x => x.GetFieldValue<string>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetString_throws_for_minimum_Decimal() => TestException(DbType.Decimal, ValueKind.Minimum, x => x.GetString(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetString_throws_for_minimum_Decimal_with_GetFieldValue() => TestException(DbType.Decimal, ValueKind.Minimum, x => x.GetFieldValue<string>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetString_throws_for_maximum_Decimal() => TestException(DbType.Decimal, ValueKind.Maximum, x => x.GetString(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetString_throws_for_maximum_Decimal_with_GetFieldValue() => TestException(DbType.Decimal, ValueKind.Maximum, x => x.GetFieldValue<string>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetString_throws_for_zero_Double() => TestException(DbType.Double, ValueKind.Zero, x => x.GetString(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetString_throws_for_zero_Double_with_GetFieldValue() => TestException(DbType.Double, ValueKind.Zero, x => x.GetFieldValue<string>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetString_throws_for_one_Double() => TestException(DbType.Double, ValueKind.One, x => x.GetString(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetString_throws_for_one_Double_with_GetFieldValue() => TestException(DbType.Double, ValueKind.One, x => x.GetFieldValue<string>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetString_throws_for_minimum_Double() => TestException(DbType.Double, ValueKind.Minimum, x => x.GetString(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetString_throws_for_minimum_Double_with_GetFieldValue() => TestException(DbType.Double, ValueKind.Minimum, x => x.GetFieldValue<string>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetString_throws_for_maximum_Double() => TestException(DbType.Double, ValueKind.Maximum, x => x.GetString(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetString_throws_for_maximum_Double_with_GetFieldValue() => TestException(DbType.Double, ValueKind.Maximum, x => x.GetFieldValue<string>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetString_throws_for_zero_Guid() => TestException(DbType.Guid, ValueKind.Zero, x => x.GetString(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetString_throws_for_zero_Guid_with_GetFieldValue() => TestException(DbType.Guid, ValueKind.Zero, x => x.GetFieldValue<string>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetString_throws_for_one_Guid() => TestException(DbType.Guid, ValueKind.One, x => x.GetString(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetString_throws_for_one_Guid_with_GetFieldValue() => TestException(DbType.Guid, ValueKind.One, x => x.GetFieldValue<string>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetString_throws_for_zero_Int16() => TestException(DbType.Int16, ValueKind.Zero, x => x.GetString(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetString_throws_for_zero_Int16_with_GetFieldValue() => TestException(DbType.Int16, ValueKind.Zero, x => x.GetFieldValue<string>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetString_throws_for_one_Int16() => TestException(DbType.Int16, ValueKind.One, x => x.GetString(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetString_throws_for_one_Int16_with_GetFieldValue() => TestException(DbType.Int16, ValueKind.One, x => x.GetFieldValue<string>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetString_throws_for_minimum_Int16() => TestException(DbType.Int16, ValueKind.Minimum, x => x.GetString(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetString_throws_for_minimum_Int16_with_GetFieldValue() => TestException(DbType.Int16, ValueKind.Minimum, x => x.GetFieldValue<string>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetString_throws_for_maximum_Int16() => TestException(DbType.Int16, ValueKind.Maximum, x => x.GetString(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetString_throws_for_maximum_Int16_with_GetFieldValue() => TestException(DbType.Int16, ValueKind.Maximum, x => x.GetFieldValue<string>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetString_throws_for_zero_Int32() => TestException(DbType.Int32, ValueKind.Zero, x => x.GetString(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetString_throws_for_zero_Int32_with_GetFieldValue() => TestException(DbType.Int32, ValueKind.Zero, x => x.GetFieldValue<string>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetString_throws_for_one_Int32() => TestException(DbType.Int32, ValueKind.One, x => x.GetString(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetString_throws_for_one_Int32_with_GetFieldValue() => TestException(DbType.Int32, ValueKind.One, x => x.GetFieldValue<string>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetString_throws_for_minimum_Int32() => TestException(DbType.Int32, ValueKind.Minimum, x => x.GetString(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetString_throws_for_minimum_Int32_with_GetFieldValue() => TestException(DbType.Int32, ValueKind.Minimum, x => x.GetFieldValue<string>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetString_throws_for_maximum_Int32() => TestException(DbType.Int32, ValueKind.Maximum, x => x.GetString(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetString_throws_for_maximum_Int32_with_GetFieldValue() => TestException(DbType.Int32, ValueKind.Maximum, x => x.GetFieldValue<string>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetString_throws_for_zero_Int64() => TestException(DbType.Int64, ValueKind.Zero, x => x.GetString(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetString_throws_for_zero_Int64_with_GetFieldValue() => TestException(DbType.Int64, ValueKind.Zero, x => x.GetFieldValue<string>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetString_throws_for_one_Int64() => TestException(DbType.Int64, ValueKind.One, x => x.GetString(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetString_throws_for_one_Int64_with_GetFieldValue() => TestException(DbType.Int64, ValueKind.One, x => x.GetFieldValue<string>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetString_throws_for_minimum_Int64() => TestException(DbType.Int64, ValueKind.Minimum, x => x.GetString(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetString_throws_for_minimum_Int64_with_GetFieldValue() => TestException(DbType.Int64, ValueKind.Minimum, x => x.GetFieldValue<string>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetString_throws_for_maximum_Int64() => TestException(DbType.Int64, ValueKind.Maximum, x => x.GetString(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetString_throws_for_maximum_Int64_with_GetFieldValue() => TestException(DbType.Int64, ValueKind.Maximum, x => x.GetFieldValue<string>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetString_throws_for_zero_SByte() => TestException(DbType.SByte, ValueKind.Zero, x => x.GetString(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetString_throws_for_zero_SByte_with_GetFieldValue() => TestException(DbType.SByte, ValueKind.Zero, x => x.GetFieldValue<string>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetString_throws_for_one_SByte() => TestException(DbType.SByte, ValueKind.One, x => x.GetString(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetString_throws_for_one_SByte_with_GetFieldValue() => TestException(DbType.SByte, ValueKind.One, x => x.GetFieldValue<string>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetString_throws_for_minimum_SByte() => TestException(DbType.SByte, ValueKind.Minimum, x => x.GetString(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetString_throws_for_minimum_SByte_with_GetFieldValue() => TestException(DbType.SByte, ValueKind.Minimum, x => x.GetFieldValue<string>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetString_throws_for_maximum_SByte() => TestException(DbType.SByte, ValueKind.Maximum, x => x.GetString(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetString_throws_for_maximum_SByte_with_GetFieldValue() => TestException(DbType.SByte, ValueKind.Maximum, x => x.GetFieldValue<string>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetString_throws_for_zero_Single() => TestException(DbType.Single, ValueKind.Zero, x => x.GetString(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetString_throws_for_zero_Single_with_GetFieldValue() => TestException(DbType.Single, ValueKind.Zero, x => x.GetFieldValue<string>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetString_throws_for_one_Single() => TestException(DbType.Single, ValueKind.One, x => x.GetString(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetString_throws_for_one_Single_with_GetFieldValue() => TestException(DbType.Single, ValueKind.One, x => x.GetFieldValue<string>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetString_throws_for_minimum_Single() => TestException(DbType.Single, ValueKind.Minimum, x => x.GetString(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetString_throws_for_minimum_Single_with_GetFieldValue() => TestException(DbType.Single, ValueKind.Minimum, x => x.GetFieldValue<string>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetString_throws_for_maximum_Single() => TestException(DbType.Single, ValueKind.Maximum, x => x.GetString(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetString_throws_for_maximum_Single_with_GetFieldValue() => TestException(DbType.Single, ValueKind.Maximum, x => x.GetFieldValue<string>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetString_throws_for_null_String() => TestException(DbType.String, ValueKind.Null, x => x.GetString(0), Fixture.NullValueExceptionType);

		[SkippableFact]
		public virtual void GetString_throws_for_null_String_with_GetFieldValue() => TestException(DbType.String, ValueKind.Null, x => x.GetFieldValue<string>(0), Fixture.NullValueExceptionType);

		[SkippableFact]
		public virtual void GetString_for_empty_String() => TestGetValue(DbType.String, ValueKind.Empty, x => x.GetString(0), "");

		[SkippableFact]
		public virtual void GetString_for_empty_String_with_GetFieldValue() => TestGetValue(DbType.String, ValueKind.Empty, x => x.GetFieldValue<string>(0), "");

		[SkippableFact]
		public virtual void GetString_for_zero_String() => TestGetValue(DbType.String, ValueKind.Zero, x => x.GetString(0), "0");

		[SkippableFact]
		public virtual void GetString_for_zero_String_with_GetFieldValue() => TestGetValue(DbType.String, ValueKind.Zero, x => x.GetFieldValue<string>(0), "0");

		[SkippableFact]
		public virtual void GetString_for_one_String() => TestGetValue(DbType.String, ValueKind.One, x => x.GetString(0), "1");

		[SkippableFact]
		public virtual void GetString_for_one_String_with_GetFieldValue() => TestGetValue(DbType.String, ValueKind.One, x => x.GetFieldValue<string>(0), "1");

		[SkippableFact]
		public virtual void GetString_throws_for_zero_UInt16() => TestException(DbType.UInt16, ValueKind.Zero, x => x.GetString(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetString_throws_for_zero_UInt16_with_GetFieldValue() => TestException(DbType.UInt16, ValueKind.Zero, x => x.GetFieldValue<string>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetString_throws_for_one_UInt16() => TestException(DbType.UInt16, ValueKind.One, x => x.GetString(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetString_throws_for_one_UInt16_with_GetFieldValue() => TestException(DbType.UInt16, ValueKind.One, x => x.GetFieldValue<string>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetString_throws_for_minimum_UInt16() => TestException(DbType.UInt16, ValueKind.Minimum, x => x.GetString(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetString_throws_for_minimum_UInt16_with_GetFieldValue() => TestException(DbType.UInt16, ValueKind.Minimum, x => x.GetFieldValue<string>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetString_throws_for_maximum_UInt16() => TestException(DbType.UInt16, ValueKind.Maximum, x => x.GetString(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetString_throws_for_maximum_UInt16_with_GetFieldValue() => TestException(DbType.UInt16, ValueKind.Maximum, x => x.GetFieldValue<string>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetString_throws_for_zero_UInt32() => TestException(DbType.UInt32, ValueKind.Zero, x => x.GetString(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetString_throws_for_zero_UInt32_with_GetFieldValue() => TestException(DbType.UInt32, ValueKind.Zero, x => x.GetFieldValue<string>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetString_throws_for_one_UInt32() => TestException(DbType.UInt32, ValueKind.One, x => x.GetString(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetString_throws_for_one_UInt32_with_GetFieldValue() => TestException(DbType.UInt32, ValueKind.One, x => x.GetFieldValue<string>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetString_throws_for_minimum_UInt32() => TestException(DbType.UInt32, ValueKind.Minimum, x => x.GetString(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetString_throws_for_minimum_UInt32_with_GetFieldValue() => TestException(DbType.UInt32, ValueKind.Minimum, x => x.GetFieldValue<string>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetString_throws_for_maximum_UInt32() => TestException(DbType.UInt32, ValueKind.Maximum, x => x.GetString(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetString_throws_for_maximum_UInt32_with_GetFieldValue() => TestException(DbType.UInt32, ValueKind.Maximum, x => x.GetFieldValue<string>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetString_throws_for_zero_UInt64() => TestException(DbType.UInt64, ValueKind.Zero, x => x.GetString(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetString_throws_for_zero_UInt64_with_GetFieldValue() => TestException(DbType.UInt64, ValueKind.Zero, x => x.GetFieldValue<string>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetString_throws_for_one_UInt64() => TestException(DbType.UInt64, ValueKind.One, x => x.GetString(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetString_throws_for_one_UInt64_with_GetFieldValue() => TestException(DbType.UInt64, ValueKind.One, x => x.GetFieldValue<string>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetString_throws_for_minimum_UInt64() => TestException(DbType.UInt64, ValueKind.Minimum, x => x.GetString(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetString_throws_for_minimum_UInt64_with_GetFieldValue() => TestException(DbType.UInt64, ValueKind.Minimum, x => x.GetFieldValue<string>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetString_throws_for_maximum_UInt64() => TestException(DbType.UInt64, ValueKind.Maximum, x => x.GetString(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetString_throws_for_maximum_UInt64_with_GetFieldValue() => TestException(DbType.UInt64, ValueKind.Maximum, x => x.GetFieldValue<string>(0), typeof(InvalidCastException));

		[SkippableFact]
		public virtual void GetFieldType_for_Binary() => TestGetFieldType(DbType.Binary, ValueKind.One, typeof(byte[]));

		[SkippableFact]
		public virtual void GetFieldType_for_Boolean() => TestGetFieldType(DbType.Boolean, ValueKind.One, typeof(bool));

		[SkippableFact]
		public virtual void GetFieldType_for_Byte() => TestGetFieldType(DbType.Byte, ValueKind.One, typeof(byte));

		[SkippableFact]
		public virtual void GetFieldType_for_Currency() => TestGetFieldType(DbType.Currency, ValueKind.One, typeof(decimal));

		[SkippableFact]
		public virtual void GetFieldType_for_Date() => TestGetFieldType(DbType.Date, ValueKind.One, typeof(DateTime));

		[SkippableFact]
		public virtual void GetFieldType_for_DateTime() => TestGetFieldType(DbType.DateTime, ValueKind.One, typeof(DateTime));

		[SkippableFact]
		public virtual void GetFieldType_for_DateTimeOffset() => TestGetFieldType(DbType.DateTimeOffset, ValueKind.One, typeof(DateTimeOffset));

		[SkippableFact]
		public virtual void GetFieldType_for_Decimal() => TestGetFieldType(DbType.Decimal, ValueKind.One, typeof(decimal));

		[SkippableFact]
		public virtual void GetFieldType_for_Double() => TestGetFieldType(DbType.Double, ValueKind.One, typeof(double));

		[SkippableFact]
		public virtual void GetFieldType_for_Guid() => TestGetFieldType(DbType.Guid, ValueKind.One, typeof(Guid));

		[SkippableFact]
		public virtual void GetFieldType_for_Int16() => TestGetFieldType(DbType.Int16, ValueKind.One, typeof(short));

		[SkippableFact]
		public virtual void GetFieldType_for_Int32() => TestGetFieldType(DbType.Int32, ValueKind.One, typeof(int));

		[SkippableFact]
		public virtual void GetFieldType_for_Int64() => TestGetFieldType(DbType.Int64, ValueKind.One, typeof(long));

		[SkippableFact]
		public virtual void GetFieldType_for_SByte() => TestGetFieldType(DbType.SByte, ValueKind.One, typeof(sbyte));

		[SkippableFact]
		public virtual void GetFieldType_for_Single() => TestGetFieldType(DbType.Single, ValueKind.One, typeof(float));

		[SkippableFact]
		public virtual void GetFieldType_for_String() => TestGetFieldType(DbType.String, ValueKind.One, typeof(string));

		[SkippableFact]
		public virtual void GetFieldType_for_Time() => TestGetFieldType(DbType.Time, ValueKind.One, typeof(TimeSpan));

		[SkippableFact]
		public virtual void GetFieldType_for_UInt16() => TestGetFieldType(DbType.UInt16, ValueKind.One, typeof(ushort));

		[SkippableFact]
		public virtual void GetFieldType_for_UInt32() => TestGetFieldType(DbType.UInt32, ValueKind.One, typeof(uint));

		[SkippableFact]
		public virtual void GetFieldType_for_UInt64() => TestGetFieldType(DbType.UInt64, ValueKind.One, typeof(ulong));

		[SkippableFact]
		public virtual void GetFieldValue_for_Binary() => TestGetFieldValue(DbType.Binary, ValueKind.One, new byte[] { 0x11 });

		[SkippableFact]
		public virtual void GetFieldValue_for_Boolean() => TestGetFieldValue(DbType.Boolean, ValueKind.One, true);

		[SkippableFact]
		public virtual void GetFieldValue_for_Byte() => TestGetFieldValue(DbType.Byte, ValueKind.One, (byte) 1);

		[SkippableFact]
		public virtual void GetFieldValue_for_Currency() => TestGetFieldValue(DbType.Currency, ValueKind.One, 1m);

		[SkippableFact]
		public virtual void GetFieldValue_for_Date() => TestGetFieldValue(DbType.Date, ValueKind.One, new DateTime(1111, 11, 11));

		[SkippableFact]
		public virtual void GetFieldValue_for_DateTime() => TestGetFieldValue(DbType.DateTime, ValueKind.One, new DateTime(1111, 11, 11, 11, 11, 11, 111));

		[SkippableFact]
		public virtual void GetFieldValue_for_DateTimeOffset() => TestGetFieldValue(DbType.DateTimeOffset, ValueKind.One, new DateTimeOffset(1111, 11, 11, 11, 11, 11, 111, new TimeSpan(11, 11, 0)));

		[SkippableFact]
		public virtual void GetFieldValue_for_Decimal() => TestGetFieldValue(DbType.Decimal, ValueKind.One, 1m);

		[SkippableFact]
		public virtual void GetFieldValue_for_Double() => TestGetFieldValue(DbType.Double, ValueKind.One, 1.0);

		[SkippableFact]
		public virtual void GetFieldValue_for_Guid() => TestGetFieldValue(DbType.Guid, ValueKind.One, new Guid("11111111111111111111111111111111"));

		[SkippableFact]
		public virtual void GetFieldValue_for_Int16() => TestGetFieldValue(DbType.Int16, ValueKind.One, (short) 1);

		[SkippableFact]
		public virtual void GetFieldValue_for_Int32() => TestGetFieldValue(DbType.Int32, ValueKind.One, 1);

		[SkippableFact]
		public virtual void GetFieldValue_for_Int64() => TestGetFieldValue(DbType.Int64, ValueKind.One, 1L);

		[SkippableFact]
		public virtual void GetFieldValue_for_SByte() => TestGetFieldValue(DbType.SByte, ValueKind.One, (sbyte) 1);

		[SkippableFact]
		public virtual void GetFieldValue_for_Single() => TestGetFieldValue(DbType.Single, ValueKind.One, 1f);

		[SkippableFact]
		public virtual void GetFieldValue_for_String() => TestGetFieldValue(DbType.String, ValueKind.One, "1");

		[SkippableFact]
		public virtual void GetFieldValue_for_Time() => TestGetFieldValue(DbType.Time, ValueKind.One, new TimeSpan(0, 11, 11, 11, 111));

		[SkippableFact]
		public virtual void GetFieldValue_for_UInt16() => TestGetFieldValue(DbType.UInt16, ValueKind.One, (ushort) 1);

		[SkippableFact]
		public virtual void GetFieldValue_for_UInt32() => TestGetFieldValue(DbType.UInt32, ValueKind.One, 1u);

		[SkippableFact]
		public virtual void GetFieldValue_for_UInt64() => TestGetFieldValue(DbType.UInt64, ValueKind.One, 1ul);

		[SkippableFact]
		public virtual void GetFieldValue_for_null() => TestGetFieldValue(DbType.String, ValueKind.Null, DBNull.Value);

		[SkippableFact]
		public virtual void GetValue_for_Binary() => TestGetValue(DbType.Binary, ValueKind.One, new byte[] { 0x11 });

		[SkippableFact]
		public virtual void GetValue_for_Boolean() => TestGetValue(DbType.Boolean, ValueKind.One, true);

		[SkippableFact]
		public virtual void GetValue_for_Byte() => TestGetValue(DbType.Byte, ValueKind.One, (byte) 1);

		[SkippableFact]
		public virtual void GetValue_for_Currency() => TestGetValue(DbType.Currency, ValueKind.One, 1m);

		[SkippableFact]
		public virtual void GetValue_for_Date() => TestGetValue(DbType.Date, ValueKind.One, new DateTime(1111, 11, 11));

		[SkippableFact]
		public virtual void GetValue_for_DateTime() => TestGetValue(DbType.DateTime, ValueKind.One, new DateTime(1111, 11, 11, 11, 11, 11, 111));

		[SkippableFact]
		public virtual void GetValue_for_DateTimeOffset() => TestGetValue(DbType.DateTimeOffset, ValueKind.One, new DateTimeOffset(1111, 11, 11, 11, 11, 11, 111, new TimeSpan(11, 11, 0)));

		[SkippableFact]
		public virtual void GetValue_for_Decimal() => TestGetValue(DbType.Decimal, ValueKind.One, 1m);

		[SkippableFact]
		public virtual void GetValue_for_Double() => TestGetValue(DbType.Double, ValueKind.One, 1.0);

		[SkippableFact]
		public virtual void GetValue_for_Guid() => TestGetValue(DbType.Guid, ValueKind.One, new Guid("11111111111111111111111111111111"));

		[SkippableFact]
		public virtual void GetValue_for_Int16() => TestGetValue(DbType.Int16, ValueKind.One, (short) 1);

		[SkippableFact]
		public virtual void GetValue_for_Int32() => TestGetValue(DbType.Int32, ValueKind.One, 1);

		[SkippableFact]
		public virtual void GetValue_for_Int64() => TestGetValue(DbType.Int64, ValueKind.One, 1L);

		[SkippableFact]
		public virtual void GetValue_for_SByte() => TestGetValue(DbType.SByte, ValueKind.One, (sbyte) 1);

		[SkippableFact]
		public virtual void GetValue_for_Single() => TestGetValue(DbType.Single, ValueKind.One, 1f);

		[SkippableFact]
		public virtual void GetValue_for_String() => TestGetValue(DbType.String, ValueKind.One, "1");

		[SkippableFact]
		public virtual void GetValue_for_Time() => TestGetValue(DbType.Time, ValueKind.One, new TimeSpan(0, 11, 11, 11, 111));

		[SkippableFact]
		public virtual void GetValue_for_UInt16() => TestGetValue(DbType.UInt16, ValueKind.One, (ushort) 1);

		[SkippableFact]
		public virtual void GetValue_for_UInt32() => TestGetValue(DbType.UInt32, ValueKind.One, 1u);

		[SkippableFact]
		public virtual void GetValue_for_UInt64() => TestGetValue(DbType.UInt64, ValueKind.One, 1ul);

		[SkippableFact]
		public virtual void GetValue_for_null() => TestGetValue(DbType.String, ValueKind.Null, DBNull.Value);
	}
}
