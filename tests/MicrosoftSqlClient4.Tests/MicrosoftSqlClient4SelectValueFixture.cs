using System;
using System.Collections.Generic;
using System.Data;
using AdoNet.Databases;
using AdoNet.Specification.Tests;

namespace MicrosoftSqlClient4.Tests
{
	public class MicrosoftSqlClient4SelectValueFixture : MicrosoftSqlClient4DbFactoryFixture, ISelectValueFixture, IDeleteFixture, IDisposable
	{
		public MicrosoftSqlClient4SelectValueFixture()
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
}
