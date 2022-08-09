using System;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Xunit;

namespace AdoNet.Specification.Tests;

public abstract class ConnectionTestBase<TFixture> : DbFactoryTestBase<TFixture>
	where TFixture : class, IDbFactoryFixture
{
	protected ConnectionTestBase(TFixture fixture)
		: base(fixture)
	{
	}

	[Fact]
	public virtual void ConnectionString_is_empty_string_by_default()
	{
		using var connection = Fixture.Factory.CreateConnection();
		Assert.Equal("", connection.ConnectionString);
	}

	[Fact]
	public void ConnectionString_is_coerced_to_empty_string()
	{
		using var connection = Fixture.Factory.CreateConnection();
		connection.ConnectionString = null;
		Assert.Equal("", connection.ConnectionString);
	}

	[Fact]
	public void ConnectionString_can_be_set_to_empty_string()
	{
		using var connection = Fixture.Factory.CreateConnection();
		connection.ConnectionString = "";
		Assert.Equal("", connection.ConnectionString);
	}

	[Fact]
	public virtual void ConnectionString_setter_throws_when_open()
	{
		using var connection = CreateOpenConnection();
		Assert.Throws<InvalidOperationException>(() => connection.ConnectionString = ConnectionString + ";");
	}

	[Fact]
	public virtual void ConnectionString_gets_and_sets_value()
	{
		using var connection = CreateConnection();
		connection.ConnectionString = ConnectionString;
		Assert.Equal(ConnectionString, connection.ConnectionString);
	}

	[Fact]
	public virtual void Database_returns_value()
	{
		using var connection = CreateOpenConnection();
		Assert.NotNull(connection.Database);
	}

	[Fact]
	public virtual void Database_returns_empty_when_closed()
	{
		using var connection = CreateConnection();
		Assert.Equal(string.Empty, connection.Database);
	}

	[Fact]
	public virtual void DataSource_returns_value()
	{
		using var connection = CreateOpenConnection();
		Assert.NotNull(connection.DataSource);
	}

	[Fact]
	public virtual void DataSource_returns_empty_when_closed()
	{
		using var connection = CreateConnection();
		Assert.Equal(string.Empty, connection.DataSource);
	}

	[Fact]
	public virtual void ServerVersion_returns_value()
	{
		using var connection = CreateOpenConnection();
		Assert.NotNull(connection.ServerVersion);
		Assert.NotEmpty(connection.ServerVersion);
	}

	[Fact]
	public virtual void ServerVersion_throws_when_closed()
	{
		using var connection = CreateConnection();
		Assert.Throws<InvalidOperationException>(() => connection.ServerVersion);
	}

	[Fact]
	public virtual void State_closed_by_default()
	{
		using var connection = CreateConnection();
		Assert.Equal(ConnectionState.Closed, connection.State);
	}

	[Fact]
	public virtual void Open_throws_when_no_connection_string()
	{
		using var connection = CreateConnection();
		Assert.Throws<InvalidOperationException>(() => connection.Open());
	}

	[Fact]
	public virtual void Set_ConnectionString_throws_when_invalid()
	{
		using var connection = CreateConnection();
		Assert.ThrowsAny<ArgumentException>(() => connection.ConnectionString = "xyzzy=Invalid");
	}

	[Fact]
	public virtual void Open_works()
	{
		using var connection = CreateConnection();
		var raised = false;
		var previousState = ConnectionState.Closed;

		void Handler(object sender, StateChangeEventArgs e)
		{
			raised = true;

			Assert.Equal(connection, sender);
			Assert.Equal(previousState, e.OriginalState);
			if (previousState == ConnectionState.Closed && (e.CurrentState == ConnectionState.Connecting || e.CurrentState == ConnectionState.Open))
				previousState = e.CurrentState;
			else if (previousState == ConnectionState.Connecting && e.CurrentState == ConnectionState.Open)
				previousState = e.CurrentState;
			else
				Assert.Equal(ConnectionState.Open, e.CurrentState);
		}

		connection.StateChange += Handler;
		try
		{
			connection.ConnectionString = ConnectionString;
			connection.Open();

			Assert.True(raised);
			Assert.Equal(ConnectionState.Open, connection.State);
		}
		finally
		{
			connection.StateChange -= Handler;
		}
	}

	[Fact]
	public virtual void Open_cannot_be_called_twice()
	{
		using var connection = CreateOpenConnection();
		Assert.Throws<InvalidOperationException>(() => connection.Open());
	}

	[Fact]
	public virtual async Task OpenAsync_is_canceled()
	{
		using var connection = CreateConnection();
		connection.ConnectionString = ConnectionString;
		var task = connection.OpenAsync(CanceledToken);
		await Assert.ThrowsAnyAsync<OperationCanceledException>(() => task);
		Assert.True(task.IsCanceled);
	}

	[Fact]
	public virtual void Close_works()
	{
		using var connection = CreateOpenConnection();
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

	[Fact]
	public virtual void Close_can_be_called_before_open()
	{
		using var connection = CreateConnection();
		connection.Close();
	}

	[Fact]
	public virtual void Close_can_be_called_more_than_once()
	{
		using var connection = CreateOpenConnection();
		connection.Close();
		connection.Close();
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
		using var connection = CreateOpenConnection();
		using var command = connection.CreateCommand();
		Assert.NotNull(command);
		Assert.Same(connection, command.Connection);
	}

	[Fact]
	public virtual void CreateCommand_does_not_set_Transaction_property()
	{
		using var connection = CreateOpenConnection();
		using var transaction = connection.BeginTransaction();
		using var command = connection.CreateCommand();
		Assert.Null(command.Transaction);
	}

	[Fact]
	public virtual void DbProviderFactory_has_correct_value()
	{
		using var connection = CreateConnection();
		var property = connection.GetType().GetProperty("DbProviderFactory", BindingFlags.Instance | BindingFlags.NonPublic);
		var dbProviderFactory = property.GetValue(connection);
		Assert.Same(Fixture.Factory, dbProviderFactory);
	}

	[Fact]
	public virtual void GetSchema_parameterless_returns_proper_MetaDataCollections_or_throws()
	{
		using var connection = CreateOpenConnection();
		try
		{
			var table = connection.GetSchema();
			CheckMetaDataCollectionsSchema(table);
		}
		catch (NotSupportedException)
		{
			return;
		}
	}

	[Fact]
	public virtual void GetSchema_returns_proper_MetaDataCollections_or_throws()
	{
		using var connection = CreateOpenConnection();
		try
		{
			var table = connection.GetSchema("MetaDataCollections");
			CheckMetaDataCollectionsSchema(table);
		}
		catch (NotSupportedException)
		{
			return;
		}
	}

	protected virtual void CheckMetaDataCollectionsSchema(DataTable table)
	{
		Assert.Equal("MetaDataCollections", table.TableName);
		Assert.Collection(table.Columns.Cast<DataColumn>(),
			c =>
			{
				Assert.Equal("CollectionName", c.ColumnName);
				Assert.Same(typeof(string), c.DataType);
			},
			c =>
			{
				Assert.Equal("NumberOfRestrictions", c.ColumnName);
				Assert.Same(typeof(int), c.DataType);
			},
			c =>
			{
				Assert.Equal("NumberOfIdentifierParts", c.ColumnName);
				Assert.Same(typeof(int), c.DataType);
			});
	}
}
