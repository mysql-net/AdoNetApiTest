using System;
using System.Data;
using System.Data.Common;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace AdoNet.Specification.Tests
{
	public abstract class ConnectionTestBase<TFixture> : IAsyncLifetime, IDisposable, IClassFixture<TFixture>
		where TFixture : class, IDbFactoryFixture
	{
		public virtual async Task InitializeAsync()
		{
			await OnInitializeAsync().ConfigureAwait(false);
		}

		public virtual async Task DisposeAsync()
		{
			await OnDisposeAsync().ConfigureAwait(false);
		}

		public void Dispose()
		{
			m_cancellationTokenSource.Dispose();
		}

		protected ConnectionTestBase(TFixture fixture)
		{
			Fixture = fixture;
			m_cancellationTokenSource = new CancellationTokenSource();
			m_cancellationTokenSource.Cancel();
			CanceledToken = m_cancellationTokenSource.Token;
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

		[Fact]
		public virtual void ConnectionString_setter_throws_when_open()
		{
			using (var connection = CreateOpenConnection())
				Assert.Throws<InvalidOperationException>(() => connection.ConnectionString = Fixture.ConnectionString + ";");
		}

		[Fact]
		public virtual void ConnectionString_gets_and_sets_value()
		{
			using (var connection = Fixture.Factory.CreateConnection())
			{
				connection.ConnectionString = Fixture.ConnectionString;
				Assert.Equal(Fixture.ConnectionString, connection.ConnectionString);
			}
		}

		[Fact]
		public virtual void Database_returns_value()
		{
			using (var connection = CreateOpenConnection())
				Assert.NotNull(connection.Database);
		}

		[Fact]
		public virtual void ServerVersion_returns_value()
		{
			using (var connection = CreateOpenConnection())
			{
				Assert.NotNull(connection.ServerVersion);
				Assert.NotEmpty(connection.ServerVersion);
			}
		}

		[Fact]
		public virtual void State_closed_by_default()
		{
			using (var connection = Fixture.Factory.CreateConnection())
				Assert.Equal(ConnectionState.Closed, connection.State);
		}

		[Fact]
		public virtual void Open_throws_when_no_connection_string()
		{
			using (var connection = Fixture.Factory.CreateConnection())
				Assert.Throws<InvalidOperationException>(() => connection.Open());
		}

		[Fact]
		public virtual void Set_ConnectionString_throws_when_invalid()
		{
			using (var connection = Fixture.Factory.CreateConnection())
				Assert.ThrowsAny<ArgumentException>(() => connection.ConnectionString = "xyzzy=Invalid");
		}

		[Fact]
		public virtual void Open_works()
		{
			using (var connection = Fixture.Factory.CreateConnection())
			{
				var raised = false;

				void Handler(object sender, StateChangeEventArgs e)
				{
					raised = true;

					Assert.Equal(connection, sender);
					Assert.Equal(ConnectionState.Closed, e.OriginalState);
					Assert.Equal(ConnectionState.Open, e.CurrentState);
				}

				connection.StateChange += Handler;
				try
				{
					connection.ConnectionString = Fixture.ConnectionString;
					connection.Open();

					Assert.True(raised);
					Assert.Equal(ConnectionState.Open, connection.State);
				}
				finally
				{
					connection.StateChange -= Handler;
				}
			}
		}

		[Fact]
		public virtual void Open_cannot_be_called_twice()
		{
			using (var connection = CreateOpenConnection())
				Assert.Throws<InvalidOperationException>(() => connection.Open());
		}

		[Fact]
		public virtual void Close_works()
		{
			using (var connection = CreateOpenConnection())
			{
				var raised = false;

				void Handler(object sender, StateChangeEventArgs e)
				{
					raised = true;

					Assert.Equal(connection, sender);
					Assert.Equal(ConnectionState.Open, e.OriginalState);
					Assert.Equal(ConnectionState.Closed, e.CurrentState);
				}

				connection.StateChange += Handler;
				try
				{
					connection.Close();

					Assert.True(raised);
					Assert.Equal(ConnectionState.Closed, connection.State);
				}
				finally
				{
					connection.StateChange -= Handler;
				}
			}
		}

		[Fact]
		public virtual void Close_can_be_called_before_open()
		{
			using (var connection = Fixture.Factory.CreateConnection())
				connection.Close();
		}

		[Fact]
		public virtual void Close_can_be_called_more_than_once()
		{
			using (var connection = CreateOpenConnection())
			{
				connection.Close();
				connection.Close();
			}
		}

		[Fact]
		public virtual void Dispose_closes_connection()
		{
			var connection = CreateOpenConnection();
			connection.Dispose();
			Assert.Equal(ConnectionState.Closed, connection.State);
		}

		[Fact]
		public virtual void Dispose_can_be_called_more_than_once()
		{
			var connection = CreateOpenConnection();
			connection.Dispose();
			connection.Dispose();
		}

		[Fact]
		public virtual void CreateCommand_returns_command()
		{
			using (var connection = CreateOpenConnection())
			using (var command = connection.CreateCommand())
			{
				Assert.NotNull(command);
				Assert.Same(connection, command.Connection);
			}
		}

		[Fact]
		public virtual void CreateCommand_does_not_set_Transaction_property()
		{
			using (var connection = CreateOpenConnection())
			using (var transaction = connection.BeginTransaction())
			using (var command = connection.CreateCommand())
			{
				Assert.Null(command.Transaction);
			}
		}

		[Fact]
		public virtual void BeginTransaction_throws_when_closed()
		{
			using (var connection = Fixture.Factory.CreateConnection())
				Assert.Throws<InvalidOperationException>(() => connection.BeginTransaction());
		}

		[Fact]
		public virtual void BeginTransaction_throws_when_parallel_transaction()
		{
			using (var connection = CreateOpenConnection())
			using (connection.BeginTransaction())
			{
				Assert.Throws<InvalidOperationException>(() => connection.BeginTransaction());
			}
		}

		[Fact]
		public virtual void BeginTransaction_works()
		{
			using (var connection = CreateOpenConnection())
			using (var transaction = connection.BeginTransaction(IsolationLevel.Serializable))
			{
				Assert.NotNull(transaction);
				Assert.Equal(connection, transaction.Connection);
				Assert.Equal(IsolationLevel.Serializable, transaction.IsolationLevel);
			}
		}
	}
}
