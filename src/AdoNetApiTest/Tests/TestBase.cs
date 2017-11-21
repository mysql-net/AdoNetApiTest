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

		protected TestResult Throws<TException>(Action action)
			where TException : Exception
		{
			try
			{
				action();
				return TestResult.NoException;
			}
			catch (TException)
			{
				return TestResult.Pass;
			}
			catch (NullReferenceException)
			{
				return TestResult.Exception;
			}
			catch (Exception ex)
			{
				Console.Write("{0} {1}", ex.GetType().Name, ex.Message);
				return TestResult.WrongException;
			}
		}
	}
}
