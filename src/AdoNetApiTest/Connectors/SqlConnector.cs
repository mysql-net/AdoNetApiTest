using System.Data.Common;
using System.Data.SqlClient;

namespace AdoNetApiTest.Connectors
{
	public sealed class SqlConnector : Connector
	{
		protected override void OnInitialize()
		{
		}

		public override DbProviderFactory Factory => SqlClientFactory.Instance;
	}
}
