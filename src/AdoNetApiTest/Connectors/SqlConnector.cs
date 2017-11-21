using System.Data.Common;
using System.Data.SqlClient;

namespace AdoNetApiTest.Connectors
{
	public sealed class SqlConnector : Connector
	{
		protected override void OnInitialize()
		{
		}

		protected override void OnUninitialize()
		{
			SqlConnection.ClearAllPools();
		}

		public override string Name => "SqlClient";
		public override DbProviderFactory Factory => SqlClientFactory.Instance;
	}
}
