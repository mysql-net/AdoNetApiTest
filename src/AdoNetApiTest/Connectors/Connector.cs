using System.Data.Common;

namespace AdoNetApiTest.Connectors
{
	public abstract class Connector
	{
		public void Initialize(string connectionString)
		{
			ConnectionString = connectionString;
			OnInitialize();
		}

		public void Uninitialize()
		{
			OnUninitialize();
		}

		public abstract string Name { get; }
		public abstract DbProviderFactory Factory { get; }

		public DbCommand CreateCommand() => Factory.CreateCommand();
		public DbConnection CreateConnection() => Factory.CreateConnection();

		public DbConnection CreateOpenConnection()
		{
			var connection = CreateConnection();
			connection.ConnectionString = ConnectionString;
			connection.Open();
			return connection;
		}

		protected abstract void OnInitialize();
		protected virtual void OnUninitialize() { }

		protected string ConnectionString { get; private set; }
	}
}
