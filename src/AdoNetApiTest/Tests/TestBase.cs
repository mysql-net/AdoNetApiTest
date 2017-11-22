using System;
using System.Data.Common;
using System.Threading;
using System.Threading.Tasks;
using AdoNetApiTest.Connectors;

namespace AdoNetApiTest.Tests
{
	public abstract class TestBase
	{
		internal void SetConnector(Connector connector) => Connector = connector;

		protected TestBase()
		{
			m_cancellationTokenSource = new CancellationTokenSource();
			m_cancellationTokenSource.Cancel();
		}

		protected Connector Connector { get; private set; }

		protected DbConnection CreateOpenConnection() => Connector.CreateOpenConnection();

		protected CancellationToken CanceledToken => m_cancellationTokenSource.Token;

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
			catch (NullReferenceException ex)
			{
				Console.Write("{0} {1}", ex.GetType().Name, ex.Message);
				return TestResult.Exception;
			}
			catch (Exception ex)
			{
				Console.Write("{0} {1}", ex.GetType().Name, ex.Message);
				return TestResult.WrongException;
			}
		}

		protected async Task<TestResult> ThrowsAsync<TException>(Func<Task> action)
			where TException : Exception
		{
			try
			{
				await action().ConfigureAwait(false);
				return TestResult.NoException;
			}
			catch (TException)
			{
				return TestResult.Pass;
			}
			catch (NullReferenceException ex)
			{
				Console.Write("{0} {1}", ex.GetType().Name, ex.Message);
				return TestResult.Exception;
			}
			catch (Exception ex)
			{
				Console.Write("{0} {1}", ex.GetType().Name, ex.Message);
				return TestResult.WrongException;
			}
		}

		CancellationTokenSource m_cancellationTokenSource;
	}
}
