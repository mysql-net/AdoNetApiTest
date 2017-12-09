using System.Data.Common;
using AdoNet.Specification.Tests;
using Devart.Data.PostgreSql;

namespace DotConnectPostgres.Tests
{
	public class DotConnectPostgresDbFactoryFixture : IDbFactoryFixture
	{
		public DbProviderFactory Factory => PgSqlProviderFactory.Instance;
		public string ConnectionString => "host=localhost;user id=root;password=test;unpreparedexecute=true;database=dotconnect;";
	}
}
