using System.Data.Common;
using System.Data.SQLite;

namespace AdoNetApiTest.Connectors
{
	public sealed class SqliteConnector : Connector
	{
		protected override void OnInitialize()
		{
		}

		public override string Name => "System.Data.SQLite 1.0.6";
		public override DbProviderFactory Factory => SQLiteFactory.Instance;
	}
}
