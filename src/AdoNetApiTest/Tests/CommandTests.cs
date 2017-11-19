namespace AdoNetApiTest.Tests
{
	public sealed class CommandTests : TestBase
	{
		public bool CreateCommandDoesNotSetTransaction()
		{
			using (var connection = Connector.CreateOpenConnection())
			using (var transaction = connection.BeginTransaction())
			using (var command = connection.CreateCommand())
			{
				return command.Transaction == null;
			}
		}
	}
}
