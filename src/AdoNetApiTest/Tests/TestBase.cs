using AdoNetApiTest.Connectors;

namespace AdoNetApiTest.Tests
{
	public abstract class TestBase
	{
		internal void SetConnector(Connector connector) => Connector = connector;

		protected Connector Connector { get; private set; }
	}
}
