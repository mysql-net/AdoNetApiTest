using System;
using System.Collections.Generic;
using System.Data;
using AdoNet.Databases;
using AdoNet.Specification.Tests;

namespace MySqlData8.Tests
{
	public class MySqlData8SelectValueFixture : MySqlData8DbFactoryFixture, ISelectValueFixture, IDeleteFixture, IDisposable
	{
		public MySqlData8SelectValueFixture() => MySqlDatabase.CreateSelectValueTable(this);

		public void Dispose() => MySqlDatabase.DropSelectValueTable(this);

		public string CreateSelectSql(DbType dbType, ValueKind kind) => MySqlDatabase.CreateSelectSql(dbType, kind);

		public string CreateSelectSql(byte[] value) => MySqlDatabase.CreateSelectSql(value);

		public string SelectNoRows => MySqlDatabase.SelectNoRows;

		public IReadOnlyCollection<DbType> SupportedDbTypes => MySqlDatabase.SupportedDbTypes;

		public Type NullValueExceptionType => MySqlDatabase.NullValueExceptionType;

		public string DeleteNoRows => MySqlDatabase.DeleteNoRows;
	}
}
