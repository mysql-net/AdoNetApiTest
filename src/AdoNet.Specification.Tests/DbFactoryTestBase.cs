using System;
using System.Data.Common;
using System.Threading;
using System.Threading.Tasks;
using Xunit;
using Xunit.Sdk;

namespace AdoNet.Specification.Tests;

public abstract class DbFactoryTestBase<TFixture> : IAsyncLifetime, IDisposable, IClassFixture<TFixture>
	where TFixture : class, IDbFactoryFixture
{
	protected DbFactoryTestBase(TFixture fixture)
	{
		Fixture = fixture;
		m_cancellationTokenSource = new CancellationTokenSource();
		m_cancellationTokenSource.Cancel();
		CanceledToken = m_cancellationTokenSource.Token;
	}

	public async Task InitializeAsync()
	{
		await OnInitializeAsync().ConfigureAwait(false);
	}

	public async Task DisposeAsync()
	{
		await OnDisposeAsync().ConfigureAwait(false);
	}

	public void Dispose()
	{
		m_cancellationTokenSource.Dispose();
	}

	protected TFixture Fixture { get; }

	protected CancellationToken CanceledToken { get; }

	protected virtual Task OnInitializeAsync() => Task.CompletedTask;

	protected virtual Task OnDisposeAsync() => Task.CompletedTask;

	protected virtual DbConnection CreateConnection() => Fixture.Factory.CreateConnection();

	protected virtual DbConnection CreateOpenConnection()
	{
		var connection = CreateConnection();
		connection.ConnectionString = ConnectionString;
		connection.Open();
		return connection;
	}

	protected virtual DbConnectionStringBuilder CreateConnectionStringBuilder()
		=> Fixture.Factory.CreateConnectionStringBuilder();

	protected virtual string ConnectionString
	{
		get
		{
			if (m_connectionString == null)
				m_connectionString = Environment.GetEnvironmentVariable("ConnectionString") ?? Fixture.ConnectionString;
			return m_connectionString;
		}
	}

	protected static Exception AssertThrowsAny<TException1, TException2>(Action action)
		where TException1 : Exception
		where TException2 : Exception
	{
		try
		{
			action();
			throw ThrowsException.ForNoException(typeof(TException1));
		}
		catch (TException1 ex)
		{
			return ex;
		}
		catch (TException2 ex)
		{
			return ex;
		}
		catch (Exception ex)
		{
			throw ThrowsException.ForIncorrectExceptionType(typeof(TException1), ex);
		}
	}

	protected static Exception AssertThrowsAny<TException1, TException2, TException3>(Action action)
		where TException1 : Exception
		where TException2 : Exception
		where TException3 : Exception
	{
		try
		{
			action();
			throw ThrowsException.ForNoException(typeof(TException1));
		}
		catch (TException1 ex)
		{
			return ex;
		}
		catch (TException2 ex)
		{
			return ex;
		}
		catch (TException3 ex)
		{
			return ex;
		}
		catch (Exception ex)
		{
			throw ThrowsException.ForIncorrectExceptionType(typeof(TException1), ex);
		}
	}

	readonly CancellationTokenSource m_cancellationTokenSource;
	string m_connectionString;
}
