using System.Data.Common;
using Npgsql;

namespace AdoNetApiTest.Connectors
{
	public sealed class NpgsqlConnector : Connector
	{
		protected override void OnInitialize()
		{
		}

		public override DbProviderFactory Factory => NpgsqlFactory.Instance;
	}
}
