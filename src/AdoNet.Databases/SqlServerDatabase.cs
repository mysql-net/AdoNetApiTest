using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlTypes;
using AdoNet.Specification.Tests;

namespace AdoNet.Databases;

public static class SqlServerDatabase
{
	public static void CreateSelectValueTable(IDbFactoryFixture factoryFixture)
	{
		Utility.ExecuteNonQuery(factoryFixture, @"drop table if exists select_value;
create table select_value
(
	Id int not null primary key,
	[Binary] varbinary(max),
	Boolean bit,
	Byte tinyint,
	Currency money,
	[Date] date,
	[DateTime] datetime2,
	[DateTimeOffset] datetimeoffset,
	[Decimal] decimal(38,18),
	[Double] float,
	Guid uniqueidentifier,
	Int16 smallint,
	Int32 int,
	Int64 bigint,
	Single real,
	String nvarchar(max),
	[Time] time
);
insert into select_value values
(0, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null),
(1, 0x, null, null, null, null, null, null, null, null, null, null, null, null, null, '', null),
(2, 0x00, 0, 0, 0, null, null, null, 0, 0, '00000000-0000-0000-0000-000000000000', 0, 0, 0, 0, '0', '00:00:00'),
(3, 0x11, 1, 1, 1, '1111-11-11', '1111-11-11 11:11:11.111', '1111-11-11 11:11:11.111 +11:11', 1, 1, '11111111-1111-1111-1111-111111111111', 1, 1, 1, 1, '1', '11:11:11.111'),
(4, null, 0, 0, -922337203685477.5808, '0001-01-1', '0001-01-01', '0001-01-01', 0.000000000000001, 2.23e-308, '33221100-5544-7766-9988-aabbccddeeff', -32768, -2147483648, -9223372036854775808, 1.18e-38, null, '00:00:00'),
(5, null, 1, 255, 922337203685477.5807, '9999-12-31', '9999-12-31 23:59:59.999', '9999-12-31 23:59:59.999 +14:00', 99999999999999999999.999999999999999, 1.79e308, 'ccddeeff-aabb-8899-7766-554433221100', 32767, 2147483647, 9223372036854775807, 3.40e38, null, '23:59:59.999');
");
	}

	public static void DropSelectValueTable(IDbFactoryFixture factoryFixture) => Utility.ExecuteNonQuery(factoryFixture, "drop table if exists select_value;");

	public static string CreateSelectSql(DbType dbType, ValueKind kind) => $"SELECT [{dbType.ToString()}] from select_value WHERE Id = {(int) kind};";

	public static string CreateSelectSql(byte[] value) => $"SELECT 0x{BitConverter.ToString(value).Replace("-", "")}";

	public static string SelectNoRows => "SELECT 1 WHERE 0 = 1;";

	public static string DeleteNoRows => "DELETE FROM select_value WHERE 0 = 1;";

	public static IReadOnlyCollection<DbType> SupportedDbTypes { get; } = new ReadOnlyCollection<DbType>(new[]
	{
		DbType.Binary,
		DbType.Boolean,
		DbType.Byte,
		DbType.Currency,
		DbType.Date,
		DbType.DateTime,
		DbType.DateTimeOffset,
		DbType.Decimal,
		DbType.Double,
		DbType.Guid,
		DbType.Int16,
		DbType.Int32,
		DbType.Int64,
		DbType.Single,
		DbType.String,
		DbType.Time,
	});

	public static Type NullValueExceptionType => typeof(SqlNullValueException);
}
