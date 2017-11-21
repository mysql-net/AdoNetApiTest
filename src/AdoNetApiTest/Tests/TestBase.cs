using System;
using System.Data.Common;
using AdoNetApiTest.Connectors;

namespace AdoNetApiTest.Tests
{
	public abstract class TestBase
	{
		internal void SetConnector(Connector connector) => Connector = connector;

		protected Connector Connector { get; private set; }

		protected DbConnection CreateOpenConnection() => Connector.CreateOpenConnection();

		protected bool Throws<TException>(Action action)
			where TException : Exception
		{
			try
			{
				action();
				return false;
			}
			catch (TException)
			{
				return true;
			}
		}
	}
}
