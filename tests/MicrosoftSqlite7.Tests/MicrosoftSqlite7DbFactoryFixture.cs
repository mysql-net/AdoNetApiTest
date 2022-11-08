using System.Data.Common;
using AdoNet.Specification.Tests;
using Microsoft.Data.Sqlite;

namespace MicrosoftSqlite7.Tests;

public class MicrosoftSqlite7DbFactoryFixture : IDbFactoryFixture
{
	public DbProviderFactory Factory => SqliteFactory.Instance;
	public string ConnectionString => "data source=temp.db";
}
