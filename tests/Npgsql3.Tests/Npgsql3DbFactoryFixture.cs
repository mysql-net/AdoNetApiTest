using System.Data.Common;
using AdoNet.Specification.Tests;
using Npgsql;

namespace Npgsql3.Tests
{
	public class Npgsql3DbFactoryFixture : IDbFactoryFixture
	{
		public DbProviderFactory Factory => NpgsqlFactory.Instance;
		public string ConnectionString => "host=localhost;user id=root;password=test;database=npgsql3";
	}
}
