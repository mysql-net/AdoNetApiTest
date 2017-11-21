using System.Data.Common;
using Microsoft.Data.Sqlite;

namespace AdoNetApiTest.Connectors
{
	public sealed class MicrosoftSqliteConnector : Connector
	{
		protected override void OnInitialize()
		{
		}

		public override string Name => "Microsoft SQLite 2.0.0";
		public override DbProviderFactory Factory => SqliteFactory.Instance;
	}
}
