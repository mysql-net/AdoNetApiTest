using System.Data.Common;
using AdoNet.Specification.Tests;

namespace Npgsql.Tests
{
	public class NpgsqlDbFactoryFixture : IDbFactoryFixture
	{
		public DbProviderFactory Factory => NpgsqlFactory.Instance;
		public string ConnectionString => "host=localhost;user id=root;password=test;database=npgsql";
	}
}
