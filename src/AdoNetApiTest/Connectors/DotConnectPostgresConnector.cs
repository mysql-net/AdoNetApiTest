using System.Data.Common;
using Devart.Data.PostgreSql;

namespace AdoNetApiTest.Connectors
{
	public sealed class DotConnectPostgresConnector : Connector
	{
		protected override void OnInitialize()
		{
		}

		protected override void OnUninitialize()
		{
			PgSqlConnection.ClearAllPools();
		}

		public override string Name => "dotConnect Postgres 8.10.1013";
		public override DbProviderFactory Factory => PgSqlProviderFactory.Instance;
	}
}
