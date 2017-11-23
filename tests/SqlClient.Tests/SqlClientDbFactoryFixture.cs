using System.Data.Common;
using System.Data.SqlClient;
using AdoNet.Specification.Tests.Databases;

namespace SqlClient.Tests
{
	public class SqlClientDbFactoryFixture : DbFactoryFixtureBase<MsSqlDatabaseBase>
	{
		public override DbProviderFactory Factory => SqlClientFactory.Instance;
	}
}
