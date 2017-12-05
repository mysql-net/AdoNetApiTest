using System.Data.Common;
using AdoNet.Specification.Tests.Databases;

namespace Npgsql.Tests
{
	public class NpgsqlDbFactoryFixture : DbFactoryFixtureBase<PostgresDatabaseBase>
	{
		public override DbProviderFactory Factory => NpgsqlFactory.Instance;
		public override string ConnectionString => "host=localhost;user id=root;password=test";
	}
}
