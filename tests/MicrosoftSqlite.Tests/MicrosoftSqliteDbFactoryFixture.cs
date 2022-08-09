using System.Data.Common;
using AdoNet.Specification.Tests;
using Microsoft.Data.Sqlite;

namespace MicrosoftSqlite.Tests;

public class MicrosoftSqliteDbFactoryFixture : IDbFactoryFixture
{
	public DbProviderFactory Factory => SqliteFactory.Instance;
	public string ConnectionString => "data source=temp.db";
}
