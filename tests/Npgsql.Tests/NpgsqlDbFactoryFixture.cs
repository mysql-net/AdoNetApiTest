using System.Data.Common;
using AdoNet.Specification.Tests;
using Npgsql;

namespace Npgsql.Tests
{
    public sealed class NpgsqlDbFactoryFixture : IDbFactoryFixture
	{
		public DbProviderFactory Factory => NpgsqlFactory.Instance;

		// docker run --name postgres -e POSTGRES_USER=root -e POSTGRES_PASSWORD=test -p 5432:5432 -d postgres
		public string ConnectionString => "host=localhost;user id=root;password=test";
	}
}
