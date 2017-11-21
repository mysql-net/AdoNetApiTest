extern alias MySqlConnector;
using System.Data.Common;
using Devart.Data.MySql;

namespace AdoNetApiTest.Connectors
{
	public sealed class DotConnectMySqlConnector : Connector
	{
		protected override void OnInitialize()
		{
		}

		protected override void OnUninitialize()
		{
			MySqlConnection.ClearAllPools();
		}

		public override string Name => "dotConnect MySQL 8.10.1013";
		public override DbProviderFactory Factory => MySqlProviderFactory.Instance;
	}
}
