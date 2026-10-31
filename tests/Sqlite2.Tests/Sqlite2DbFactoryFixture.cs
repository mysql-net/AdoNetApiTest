using System.Data.Common;
using System.Data.SQLite;
using AdoNet.Specification.Tests;

namespace Sqlite2.Tests;

public class Sqlite2DbFactoryFixture : IDbFactoryFixture
{
	public DbProviderFactory Factory => SQLiteFactory.Instance;
	public string ConnectionString => "data source=temp.db";
}
