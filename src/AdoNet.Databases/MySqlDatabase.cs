using System;
using System.Collections.Generic;
using System.Data;
using AdoNet.Specification.Tests;

namespace AdoNet.Databases
{
	public static class MySqlDatabase
	{
		public static void CreateSelectValueTable(IDbFactoryFixture factoryFixture)
		{
			Utility.ExecuteNonQuery(factoryFixture, @"drop table if exists select_value;
create table select_value
(
	Id int not null primary key,
	`Binary` blob,
	Boolean bool,
	Byte tinyint unsigned,
	SByte tinyint,
	Int16 smallint,
	UInt16 smallint unsigned,
	Int32 int,
	UInt32 int unsigned,
	Int64 bigint,
	UInt64 bigint unsigned,
	Single float,
	`Double` double,
	`Decimal` decimal(57,28),
	String text,
	Guid char(36),
	`Date` date,
	`DateTime` datetime(3),
	`Time` time(3)
);
insert into select_value values
(0, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null),
(1, X'', null, null, null, null, null, null, null, null, null, null, null, null, '', '', null, null, null),
(2, X'00', 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, '0', '00000000-0000-0000-0000-000000000000', null, null, '00:00:00'),
(3, X'11', 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, '1', '11111111-1111-1111-1111-111111111111', '1111-11-11', '1111-11-11 11:11:11.111', '11:11:11.111'),
(4, null, false, 0, -128, -32768, 0, -2147483648, 0, -9223372036854775808, 0, 1.18e-38, 2.23e-308, 0.000000000000001, null, null, '1000-01-01', '1000-01-01 00:00:00', '-838:59:59'),
(5, null, true, 255, 127, 32767, 65535, 2147483647, 4294967295, 9223372036854775807, 18446744073709551615, 3.40e38, 1.79e308, 99999999999999999999.999999999999999, null, null, '9999-12-31', '9999-12-31 23:59:59.999', '838:59:59');
");
		}

		public static void DropSelectValueTable(IDbFactoryFixture factoryFixture) => Utility.ExecuteNonQuery(factoryFixture, "drop table if exists select_value;");

		public static string CreateSelectSql(DbType dbType, ValueKind kind) => $"SELECT `{dbType.ToString()}` from select_value WHERE Id = {(int) kind};";

		public static string CreateSelectSql(byte[] value) => $"SELECT X'{BitConverter.ToString(value).Replace("-", "")}'";

		public static string SelectNoRows => "SELECT * FROM mysql.user WHERE 0 = 1;";

		public static IReadOnlyCollection<DbType> SupportedDbTypes { get; } = new[]
		{
			DbType.Binary,
			DbType.Boolean,
			DbType.Byte,
			DbType.Date,
			DbType.DateTime,
			DbType.Decimal,
			DbType.Double,
			DbType.Guid,
			DbType.Int16,
			DbType.Int32,
			DbType.Int64,
			DbType.SByte,
			DbType.Single,
			DbType.String,
			DbType.Time,
			DbType.UInt16,
			DbType.UInt32,
			DbType.UInt64,
		};
	}
}
