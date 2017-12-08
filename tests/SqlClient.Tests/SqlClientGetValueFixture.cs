using System;
using System.Collections.Generic;
using System.Data;
using AdoNet.Specification.Tests;

namespace SqlClient.Tests
{
	public class SqlClientGetValueFixture : SqlClientDbFactoryFixture, IGetValueFixture, IDisposable
	{
		public SqlClientGetValueFixture()
		{
			using (var connection = Factory.CreateConnection())
			{
				connection.ConnectionString = ConnectionString;
				connection.Open();

				using (var command = connection.CreateCommand())
				{
					command.CommandText = @"drop table if exists get_value_tests;
create table get_value_tests
(
	Id int not null primary key,
	[Binary] varbinary(max),
	Boolean bit,
	Byte tinyint,
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
insert into get_value_tests values
(0, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null),
(1, 0x, null, null, null, null, null, null, null, null, null, null, null, null, '', null),
(2, 0x00, 0, 0, null, null, null, 0, 0, '00000000-0000-0000-0000-000000000000', 0, 0, 0, 0, '0', '00:00:00'),
(3, 0x11, 1, 1, '1111-11-11', '1111-11-11 11:11:11.111', '1111-11-11 11:11:11.111 +11:11', 1, 1, '11111111-1111-1111-1111-111111111111', 1, 1, 1, 1, '1', '11:11:11.111'),
(4, null, 0, 0, '0001-01-1', '0001-01-01', '0001-01-01', 0.000000000000001, 2.23e-308, null, -32768, -2147483648, -9223372036854775808, 1.18e-38, null, '00:00:00'),
(5, null, 1, 255, '9999-12-31', '9999-12-31 23:59:59.999', '9999-12-31 23:59:59.999 +14:00', 99999999999999999999.999999999999999, 1.79e308, null, 32767, 2147483647, 9223372036854775807, 3.40e38, null, '23:59:59.999');
";
					command.ExecuteNonQuery();
				}
			}
		}

		public void Dispose()
		{
			using (var connection = Factory.CreateConnection())
			{
				connection.ConnectionString = ConnectionString;
				connection.Open();

				using (var command = connection.CreateCommand())
				{
					command.CommandText = @"drop table if exists get_value_tests;";
					command.ExecuteNonQuery();
				}
			}
		}

		public string CreateSelectSql(DbType dbType, ValueKind kind) => $"SELECT [{dbType.ToString()}] from get_value_tests WHERE Id = {(int) kind};";

		public IReadOnlyCollection<DbType> SupportedDbTypes { get; } = new[]
		{
			DbType.Binary,
			DbType.Boolean,
			DbType.Byte,
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
		};
	}
}
