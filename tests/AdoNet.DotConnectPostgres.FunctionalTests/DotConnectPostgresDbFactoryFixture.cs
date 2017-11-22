using System.Data.Common;
using AdoNet.Specification.Tests;
using Devart.Data.PostgreSql;

namespace AdoNet.DotConnectPostgres.FunctionalTests
{
    public sealed class DotConnectPostgresDbFactoryFixture : IDbFactoryFixture
	{
		public DbProviderFactory Factory => PgSqlProviderFactory.Instance;

		// docker run --name postgres -e POSTGRES_USER=root -e POSTGRES_PASSWORD=test -p 5432:5432 -d postgres
		public string ConnectionString => "host=localhost;user id=root;password=test;";
	}
}
