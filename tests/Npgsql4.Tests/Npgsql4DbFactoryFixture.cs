using System.Data.Common;
using AdoNet.Specification.Tests;
using Npgsql;

namespace Npgsql4.Tests;

public class Npgsql4DbFactoryFixture : IDbFactoryFixture
{
	public DbProviderFactory Factory => NpgsqlFactory.Instance;
	public string ConnectionString => "host=localhost;user id=root;password=test;database=npgsql4";
}
