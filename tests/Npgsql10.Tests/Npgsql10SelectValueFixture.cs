using System;
using System.Collections.Generic;
using System.Data;
using AdoNet.Databases;

namespace Npgsql10.Tests;

public sealed class Npgsql10SelectValueFixture : Npgsql10DbFactoryFixture, ISelectValueFixture, IDeleteFixture, IDisposable
{
	public Npgsql10SelectValueFixture() => PostgreSqlDatabase.CreateSelectValueTable(this);
	public void Dispose() => PostgreSqlDatabase.DropSelectValueTable(this);
	public string CreateSelectSql(DbType dbType, ValueKind kind) => PostgreSqlDatabase.CreateSelectSql(dbType, kind);
	public string CreateSelectSql(byte[] value) => PostgreSqlDatabase.CreateSelectSql(value);
	public string SelectNoRows => PostgreSqlDatabase.SelectNoRows;
	public IReadOnlyCollection<DbType> SupportedDbTypes => PostgreSqlDatabase.SupportedDbTypes;
	public Type NullValueExceptionType => PostgreSqlDatabase.NullValueExceptionType;
	public string DeleteNoRows => PostgreSqlDatabase.DeleteNoRows;
}
