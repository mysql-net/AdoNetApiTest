using System;
using System.Collections.Generic;
using System.Data;
using AdoNet.Databases;
using AdoNet.Specification.Tests;

namespace DotConnectPostgres.Tests
{
	public class DotConnectPostgresSelectValueFixture : DotConnectPostgresDbFactoryFixture, ISelectValueFixture, IDisposable
	{
		public DotConnectPostgresSelectValueFixture() => PostgreSqlDatabase.CreateSelectValueTable(this);
		public void Dispose() => PostgreSqlDatabase.DropSelectValueTable(this);
		public string CreateSelectSql(DbType dbType, ValueKind kind) => PostgreSqlDatabase.CreateSelectSql(dbType, kind);
		public string CreateSelectSql(byte[] value) => PostgreSqlDatabase.CreateSelectSql(value);
		public string SelectNoRows => PostgreSqlDatabase.SelectNoRows;
		public IReadOnlyCollection<DbType> SupportedDbTypes => PostgreSqlDatabase.SupportedDbTypes;
		public Type NullValueExceptionType => PostgreSqlDatabase.NullValueExceptionType;
	}
}
