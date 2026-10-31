using System;
using System.Collections.Generic;
using System.Data;
using AdoNet.Databases;
using AdoNet.Specification.Tests;

namespace MicrosoftSqlClient6.Tests;

public class MicrosoftSqlClient6SelectValueFixture : MicrosoftSqlClient6DbFactoryFixture, ISelectValueFixture, IDeleteFixture, IDisposable
{
	public MicrosoftSqlClient6SelectValueFixture()
	{
		SqlServerDatabase.CreateSelectValueTable(this);
	}

	public void Dispose() => SqlServerDatabase.DropSelectValueTable(this);

	public string CreateSelectSql(DbType dbType, ValueKind kind) => SqlServerDatabase.CreateSelectSql(dbType, kind);

	public string CreateSelectSql(byte[] value) => SqlServerDatabase.CreateSelectSql(value);

	public string SelectNoRows => SqlServerDatabase.SelectNoRows;

	public IReadOnlyCollection<DbType> SupportedDbTypes => SqlServerDatabase.SupportedDbTypes;

	public Type NullValueExceptionType => SqlServerDatabase.NullValueExceptionType;

	public string DeleteNoRows => SqlServerDatabase.DeleteNoRows;
}
