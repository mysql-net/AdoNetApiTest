extern alias MySqlData;
using System.Data.Common;
using MySqlData.MySql.Data.MySqlClient;

namespace AdoNetApiTest.Connectors
{
	public sealed class MySqlDataConnector : Connector
	{
		protected override void OnInitialize()
		{
		}

		protected override void OnUninitialize()
		{
			MySqlConnection.ClearAllPools();
		}

		public override DbProviderFactory Factory => MySqlClientFactory.Instance;
	}
}
