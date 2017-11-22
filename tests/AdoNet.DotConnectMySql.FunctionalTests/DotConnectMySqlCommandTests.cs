using AdoNet.Specification.Tests;
using Xunit;

namespace AdoNet.DotConnectMySql.FunctionalTests
{
	public sealed class DotConnectMySqlCommandTests : CommandTestBase<DotConnectMySqlDbFactoryFixture>
	{
		public DotConnectMySqlCommandTests(DotConnectMySqlDbFactoryFixture fixture)
			: base(fixture)
		{
		}

		public override void ExecuteScalar_returns_null_when_empty()
		{
			using (var connection = CreateOpenConnection())
			using (var command = connection.CreateCommand())
			{
				command.CommandText = "SELECT 1 FROM mysql.user WHERE 0 = 1;";
				Assert.Null(command.ExecuteScalar());
			}
		}
	}
}
