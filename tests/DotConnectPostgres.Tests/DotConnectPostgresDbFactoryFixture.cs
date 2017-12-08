using System.Data.Common;
using AdoNet.Specification.Tests;
using Devart.Data.PostgreSql;

namespace DotConnectPostgres.Tests
{
	public sealed class DotConnectPostgresDbFactoryFixture : IDbFactoryFixture
	{
		public DbProviderFactory Factory => PgSqlProviderFactory.Instance;
		public string ConnectionString => "host=localhost;user id=root;password=test;";
	}
}
