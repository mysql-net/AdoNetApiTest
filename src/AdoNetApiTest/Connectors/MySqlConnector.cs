extern alias MySqlConnector;
using System.Data.Common;
using MySqlConnector.MySql.Data.MySqlClient;

namespace AdoNetApiTest.Connectors
{
	public sealed class MySqlConnector : Connector
	{
		protected override void OnInitialize()
		{
		}

		protected override void OnUninitialize()
		{
			MySqlConnection.ClearAllPools();
		}

		public override string Name => "MySqlConnector 0.31.1";
		public override DbProviderFactory Factory => MySqlClientFactory.Instance;
	}
}
