using System;
using System.Collections.Generic;
using System.Data;
using AdoNet.Databases;
using AdoNet.Specification.Tests;

namespace MySqlConnector.Tests
{
	public class MySqlConnectorSelectValueFixture : MySqlConnectorDbFactoryFixture, ISelectValueFixture, IDisposable
	{
		public MySqlConnectorSelectValueFixture() => MySqlDatabase.CreateSelectValueTable(this);

		public void Dispose() => MySqlDatabase.DropSelectValueTable(this);

		public string CreateSelectSql(DbType dbType, ValueKind kind) => MySqlDatabase.CreateSelectSql(dbType, kind);

		public string CreateSelectSql(byte[] value) => MySqlDatabase.CreateSelectSql(value);

		public string SelectNoRows => MySqlDatabase.SelectNoRows;

		public IReadOnlyCollection<DbType> SupportedDbTypes => MySqlDatabase.SupportedDbTypes;
	}
}
