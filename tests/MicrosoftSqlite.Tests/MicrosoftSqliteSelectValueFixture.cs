using System;
using System.Collections.Generic;
using System.Data;
using AdoNet.Databases;
using AdoNet.Specification.Tests;

namespace MicrosoftSqlite.Tests
{
	public class MicrosoftSqliteSelectValueFixture : MicrosoftSqliteDbFactoryFixture, ISelectValueFixture, IDisposable
	{
		public MicrosoftSqliteSelectValueFixture() => SqliteDatabase.CreateSelectValueTable(this);
		public void Dispose() => SqliteDatabase.DropSelectValueTable(this);
		public string CreateSelectSql(DbType dbType, ValueKind kind) => SqliteDatabase.CreateSelectSql(dbType, kind);
		public string CreateSelectSql(byte[] value) => SqliteDatabase.CreateSelectSql(value);
		public string SelectNoRows => SqliteDatabase.SelectNoRows;

		public IReadOnlyCollection<DbType> SupportedDbTypes { get; } = new[]
		{
			DbType.Binary,
			DbType.Double,
			DbType.Int64,
			DbType.String,
		};

		public Type NullValueExceptionType => SqliteDatabase.NullValueExceptionType;
	}
}
