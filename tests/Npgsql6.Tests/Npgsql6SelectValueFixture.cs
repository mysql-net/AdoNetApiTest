using System;
using System.Collections.Generic;
using System.Data;
using AdoNet.Databases;

namespace Npgsql6.Tests;

public sealed class Npgsql6SelectValueFixture : Npgsql6DbFactoryFixture, ISelectValueFixture, IDeleteFixture, IDisposable
{
	public Npgsql6SelectValueFixture() => PostgreSqlDatabase.CreateSelectValueTable(this);
	public void Dispose() => PostgreSqlDatabase.DropSelectValueTable(this);
	public string CreateSelectSql(DbType dbType, ValueKind kind) => PostgreSqlDatabase.CreateSelectSql(dbType, kind);
	public string CreateSelectSql(byte[] value) => PostgreSqlDatabase.CreateSelectSql(value);
	public string SelectNoRows => PostgreSqlDatabase.SelectNoRows;
	public IReadOnlyCollection<DbType> SupportedDbTypes => PostgreSqlDatabase.SupportedDbTypes;
	public Type NullValueExceptionType => PostgreSqlDatabase.NullValueExceptionType;
	public string DeleteNoRows => PostgreSqlDatabase.DeleteNoRows;
}
