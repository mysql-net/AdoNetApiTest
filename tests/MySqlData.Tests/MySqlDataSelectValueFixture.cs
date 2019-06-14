using System;
using System.Collections.Generic;
using System.Data;
using AdoNet.Databases;
using AdoNet.Specification.Tests;

namespace MySqlData.Tests
{
	public class MySqlDataSelectValueFixture : MySqlDataDbFactoryFixture, ISelectValueFixture, IDeleteFixture, IDisposable
	{
		public MySqlDataSelectValueFixture() => MySqlDatabase.CreateSelectValueTable(this);

		public void Dispose() => MySqlDatabase.DropSelectValueTable(this);

		public string CreateSelectSql(DbType dbType, ValueKind kind) => MySqlDatabase.CreateSelectSql(dbType, kind);

		public string CreateSelectSql(byte[] value) => MySqlDatabase.CreateSelectSql(value);

		public string SelectNoRows => MySqlDatabase.SelectNoRows;

		public IReadOnlyCollection<DbType> SupportedDbTypes => MySqlDatabase.SupportedDbTypes;

		public Type NullValueExceptionType => MySqlDatabase.NullValueExceptionType;

		public string DeleteNoRows => MySqlDatabase.DeleteNoRows;
	}
}
