using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using AdoNet.Specification.Tests;

namespace AdoNet.Databases
{
	public static class SqliteDatabase
	{
		public static void CreateSelectValueTable(IDbFactoryFixture factoryFixture)
		{
			Utility.ExecuteNonQuery(factoryFixture, @"drop table if exists select_value;
create table select_value
(
	Id integer not null primary key,
	Binary blob,
	Boolean bool,
	Byte tinyint,
	""DateTime"" datetime,
	""Decimal"" decimal,
	Double real,
	""Guid"" guid,
	Int16 smallint,
	Int32 int,
	Int64 integer,
	""Single"" single,
	String text
);
insert into select_value values
(0, null, null, null, null, null, null, null, null, null, null, null, null),
(1, X'', null, null, null, null, null, null, null, null, null, null, ''),
(2, X'00', 0, 0, null, 0, 0, '00000000-0000-0000-0000-000000000000', 0, 0, 0, 0, '0'),
(3, X'11', 1, 1, '1111-11-11 11:11:11.111', 1, 1, '11111111-1111-1111-1111-111111111111', 1, 1, 1, 1, '1'),
(4, null, 0, 0, '0001-01-01', 0.000000000000001, 2.23e-308, null, -32768, -2147483648, -9223372036854775808, 1.18e-38, null),
(5, null, 1, 255, '9999-12-31 23:59:59.999', 99999999999999999999.999999999999999, 1.79e308, null, 32767, 2147483647, 9223372036854775807, 3.40e38, null);
");
		}

		public static void DropSelectValueTable(IDbFactoryFixture factoryFixture) => Utility.ExecuteNonQuery(factoryFixture, "drop table if exists select_value;");

		public static string CreateSelectSql(DbType dbType, ValueKind kind) => $"SELECT `{dbType.ToString()}` from select_value WHERE Id = {(int) kind};";

		public static string CreateSelectSql(byte[] value) => $"SELECT X'{BitConverter.ToString(value).Replace("-", "")}'";

		public static string SelectNoRows => "SELECT 1 WHERE 0 = 1;";

		public static IReadOnlyCollection<DbType> SupportedDbTypes { get; } = new ReadOnlyCollection<DbType>(new[]
		{
			DbType.Binary,
			DbType.Boolean,
			DbType.Byte,
			DbType.DateTime,
			DbType.Decimal,
			DbType.Double,
			DbType.Guid,
			DbType.Int16,
			DbType.Int32,
			DbType.Int64,
			DbType.Single,
			DbType.String,
		});
	}
}
