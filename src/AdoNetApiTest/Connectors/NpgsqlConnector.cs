using System.Data.Common;
using Npgsql;

namespace AdoNetApiTest.Connectors
{
	public sealed class NpgsqlConnector : Connector
	{
		protected override void OnInitialize()
		{
		}

		public override string Name => "Npgsql 3.2.5";
		public override DbProviderFactory Factory => NpgsqlFactory.Instance;
	}
}
