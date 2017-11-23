using System.Data.Common;
using AdoNet.Specification.Tests.Databases;

namespace Npgsql.Tests
{
	public sealed class NpgsqlDbFactoryFixture : DbFactoryFixtureBase<PostgresDatabaseBase>
	{
		public override DbProviderFactory Factory => NpgsqlFactory.Instance;
	}
}
