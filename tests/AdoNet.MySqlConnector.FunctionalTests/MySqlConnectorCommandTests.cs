using AdoNet.Specification.Tests;
using Xunit;

namespace AdoNet.MySqlConnector.FunctionalTests
{
	public sealed class MySqlConnectorCommandTests : CommandTestBase<MySqlConnectorDbFactoryFixture>
	{
		public MySqlConnectorCommandTests(MySqlConnectorDbFactoryFixture fixture)
			: base(fixture)
		{
		}

		public override void ExecuteScalar_returns_double_when_real()
		{
			using (var connection = CreateOpenConnection())
			using (var command = connection.CreateCommand())
			{
				command.CommandText = "SELECT 3.14;";
				Assert.Equal(3.14m, command.ExecuteScalar());
			}
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
