using System;
using System.Data.Common;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace AdoNet.Specification.Tests
{
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

		protected virtual DbConnection CreateOpenConnection()
		{
			var connection = Fixture.Factory.CreateConnection();
			connection.ConnectionString = Fixture.ConnectionString;
			connection.Open();
			return connection;
		}

		readonly CancellationTokenSource m_cancellationTokenSource;
	}
}
