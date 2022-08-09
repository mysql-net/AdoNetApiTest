using System.Data.Common;
using AdoNet.Specification.Tests;
using Microsoft.Data.Sqlite;

namespace MicrosoftSqlite5.Tests;

public class MicrosoftSqlite5DbFactoryFixture : IDbFactoryFixture
{
	public DbProviderFactory Factory => SqliteFactory.Instance;
	public string ConnectionString => "data source=temp.db";
}
