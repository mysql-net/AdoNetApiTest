using System;
using System.Collections.Generic;
using System.Data;
using AdoNet.Databases;

namespace Npgsql7.Tests;

public sealed class Npgsql7SelectValueFixture : Npgsql7DbFactoryFixture, ISelectValueFixture, IDeleteFixture, IDisposable
{
	public Npgsql7SelectValueFixture() => PostgreSqlDatabase.CreateSelectValueTable(this);
	public void Dispose() => PostgreSqlDatabase.DropSelectValueTable(this);
	public string CreateSelectSql(DbType dbType, ValueKind kind) => PostgreSqlDatabase.CreateSelectSql(dbType, kind);
	public string CreateSelectSql(byte[] value) => PostgreSqlDatabase.CreateSelectSql(value);
	public string SelectNoRows => PostgreSqlDatabase.SelectNoRows;
	public IReadOnlyCollection<DbType> SupportedDbTypes => PostgreSqlDatabase.SupportedDbTypes;
	public Type NullValueExceptionType => PostgreSqlDatabase.NullValueExceptionType;
	public string DeleteNoRows => PostgreSqlDatabase.DeleteNoRows;
}
