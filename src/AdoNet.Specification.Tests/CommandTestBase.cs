using System;
using System.Data;
using System.Data.Common;
using System.Threading.Tasks;
using Xunit;
using Xunit.Sdk;

namespace AdoNet.Specification.Tests
{
	public abstract class CommandTestBase<TFixture> : DbFactoryTestBase<TFixture>
		where TFixture : class, IDbFactoryFixture
	{
		protected CommandTestBase(TFixture fixture)
			: base(fixture)
		{
		}

		[Fact]
		public virtual void Cancel_new_Command_is_no_op()
		{
			using var command = Fixture.Factory.CreateCommand();
			command.Cancel();
		}

		[Fact]
		public virtual void CommandText_throws_when_set_when_open_reader()
		{
			using var connection = CreateOpenConnection();
			using var command = connection.CreateCommand();
			command.CommandText = "SELECT 1;";

			using var reader = command.ExecuteReader();

			Assert.Throws<InvalidOperationException>(() => command.CommandText = "SELECT 2;");
		}

		[Fact]
		public virtual void Connection_can_be_unset()
		{
			using var connection = CreateOpenConnection();
			using var command = connection.CreateCommand();
			Assert.NotNull(command.Connection);
			command.Connection = null;
			Assert.Null(command.Connection);
		}

		[Fact]
		public virtual void Connection_throws_when_set_when_open_reader()
		{
			using var connection = CreateOpenConnection();
			using var command = connection.CreateCommand();
			command.CommandText = "SELECT 1;";

			using var reader = command.ExecuteReader();

			Assert.Throws<InvalidOperationException>(() => command.Connection = CreateConnection());
		}

		[Fact]
		public virtual void Connection_throws_when_set_to_null_when_open_reader()
		{
			using var connection = CreateOpenConnection();
			using var command = connection.CreateCommand();
			command.CommandText = "SELECT 1;";

			using var reader = command.ExecuteReader();

			Assert.Throws<InvalidOperationException>(() => command.Connection = null);
		}

		[Fact]
		public virtual void CommandText_does_not_throw_when_disposed()
		{
			var command = Fixture.Factory.CreateCommand();
			command.Dispose();
			Assert.Equal("", command.CommandText);
		}

		[Fact]
		public virtual void CommandText_is_empty_string_by_default()
		{
			using var command = Fixture.Factory.CreateCommand();
			Assert.Equal("", command.CommandText);
		}

		[Fact]
		public void CommandText_is_coerced_to_empty_string()
		{
			using var command = Fixture.Factory.CreateCommand();
			command.CommandText = null;
			Assert.Equal("", command.CommandText);
		}

		[Fact]
		public void CommandText_can_be_set_to_empty_string()
		{
			using var command = Fixture.Factory.CreateCommand();
			command.CommandText = "";
			Assert.Equal("", command.CommandText);
		}

		[Fact]
		public virtual void CommandType_text_by_default()
		{
			using var command = Fixture.Factory.CreateCommand();
			Assert.Equal(CommandType.Text, command.CommandType);
		}

		[Fact]
		public virtual void CommandType_does_not_throw_when_disposed()
		{
			var command = Fixture.Factory.CreateCommand();
			command.Dispose();
			Assert.Equal(CommandType.Text, command.CommandType);
		}

		[Fact]
		public virtual void Parameters_is_not_null()
		{
			using var command = Fixture.Factory.CreateCommand();
			Assert.NotNull(command.Parameters);
		}

		[Fact]
		public virtual void Parameters_returns_same_object()
		{
			using var command = Fixture.Factory.CreateCommand();
			var parameters = command.Parameters;
			Assert.Same(parameters, command.Parameters);
		}

		[Fact]
		public virtual void Parameters_does_not_throw_when_disposed()
		{
			var command = Fixture.Factory.CreateCommand();
			command.Dispose();
			Assert.NotNull(command.Parameters);
		}

		[Fact]
		public virtual void CreateParameter_is_not_null()
		{
			using var command = Fixture.Factory.CreateCommand();
			Assert.NotNull(command.CreateParameter());
		}

		[Fact]
		public virtual void Prepare_throws_when_no_connection()
		{
			using var command = Fixture.Factory.CreateCommand();
			Assert.Throws<InvalidOperationException>(() => command.Prepare());
		}

		[Fact]
		public virtual void Prepare_throws_when_connection_closed()
		{
			using var connection = CreateConnection();
			using var command = connection.CreateCommand();
			Assert.Throws<InvalidOperationException>(() => command.Prepare());
		}

		[Fact]
		public virtual void Prepare_throws_when_no_command_text()
		{
			using var connection = CreateOpenConnection();
			using var command = connection.CreateCommand();
			Assert.Throws<InvalidOperationException>(() => command.Prepare());
		}

		[Fact]
		public virtual void ExecuteReader_throws_when_no_connection()
		{
			using var command = Fixture.Factory.CreateCommand();
			Assert.Throws<InvalidOperationException>(() => command.ExecuteReader());
		}

		[Fact]
		public virtual void ExecuteReader_throws_when_connection_closed()
		{
			using var connection = CreateConnection();
			using var command = connection.CreateCommand();
			Assert.Throws<InvalidOperationException>(() => command.ExecuteReader());
		}

		[Fact]
		public virtual void ExecuteReader_throws_when_no_command_text()
		{
			using var connection = CreateOpenConnection();
			using var command = connection.CreateCommand();
			Assert.Throws<InvalidOperationException>(() => command.ExecuteReader());
		}

		[Fact]
		public virtual void ExecuteReader_throws_on_error()
		{
			using var connection = CreateOpenConnection();
			using var command = connection.CreateCommand();
			command.CommandText = "INVALID;";
			Assert.ThrowsAny<DbException>(() => command.ExecuteReader());
		}

		[Fact]
		public virtual void ExecuteReader_throws_when_transaction_required()
		{
			using var connection = CreateOpenConnection();
			using var command = connection.CreateCommand();
			command.CommandText = "SELECT 1;";

			using (connection.BeginTransaction())
			{
				Assert.Throws<InvalidOperationException>(() =>
				{
					using (command.ExecuteReader())
					{
					}
				});
			}
		}

		[Fact]
		public virtual void ExecuteReader_throws_when_transaction_mismatched()
		{
			using var connection = CreateOpenConnection();
			using var command = connection.CreateCommand();
			command.CommandText = "SELECT 1;";

			using var otherConnection = CreateOpenConnection();
			using var otherTransaction = otherConnection.BeginTransaction();
			command.Transaction = otherTransaction;

			Assert.Throws<InvalidOperationException>(() =>
			{
				using (command.ExecuteReader())
				{
				}
			});
		}

		[Fact]
		public virtual void ExecuteReader_throws_when_reader_open()
		{
			using var connection = CreateOpenConnection();
			using var command = connection.CreateCommand();
			command.CommandText = "SELECT 1;";

			using var reader = command.ExecuteReader();
			Assert.ThrowsAny<InvalidOperationException>(() => command.ExecuteReader());
		}

		[Fact]
		public virtual void ExecuteReader_binds_parameters()
		{
			using var connection = CreateOpenConnection();
			using var command = connection.CreateCommand();
			command.CommandText = "SELECT @Parameter;";
			var parameter = command.CreateParameter();
			parameter.ParameterName = "@Parameter";
			parameter.Value = 1;
			command.Parameters.Add(parameter);

			var scalar = command.ExecuteScalar();
			if (scalar is int)
				Assert.Equal(1, scalar);
			else
				Assert.Equal(1L, scalar);
		}

		[Fact]
		public virtual void ExecuteReader_HasRows_is_false_for_comment()
		{
			using var connection = CreateOpenConnection();
			using var command = connection.CreateCommand();
			command.CommandText = "-- TODO: Write SQL";

			using var reader = command.ExecuteReader();
			Assert.False(reader.HasRows);
		}

		[Fact]
		public virtual void ExecuteReader_works_when_trailing_comments()
		{
			using var connection = CreateOpenConnection();
			using var command = connection.CreateCommand();
			command.CommandText = "SELECT 0; -- My favorite number";

			using var reader = command.ExecuteReader();
			Assert.True(reader.Read());
			Assert.Equal(0, reader.GetInt32(0));
			Assert.False(reader.NextResult());
		}

		[Fact]
		public virtual void ExecuteReader_supports_CloseConnection()
		{
			using var connection = CreateOpenConnection();
			using var command = connection.CreateCommand();
			command.CommandText = "SELECT 0;";
			using (command.ExecuteReader(CommandBehavior.CloseConnection))
			{
			}
			Assert.Equal(ConnectionState.Closed, connection.State);
		}

		[Fact]
		public virtual void ExecuteScalar_throws_when_no_connection()
		{
			using var command = Fixture.Factory.CreateCommand();
			Assert.Throws<InvalidOperationException>(() => command.ExecuteScalar());
		}

		[Fact]
		public virtual void ExecuteScalar_throws_when_connection_closed()
		{
			using var connection = CreateConnection();
			using var command = connection.CreateCommand();
			Assert.Throws<InvalidOperationException>(() => command.ExecuteScalar());
		}

		[Fact]
		public virtual void ExecuteScalar_throws_when_no_command_text()
		{
			using var connection = CreateOpenConnection();
			using var command = connection.CreateCommand();
			Assert.Throws<InvalidOperationException>(() => command.ExecuteScalar());
		}

		[Fact]
		public virtual void ExecuteScalar_returns_integer()
		{
			using var connection = CreateOpenConnection();
			using var command = connection.CreateCommand();
			command.CommandText = "SELECT 1;";
			var result = command.ExecuteScalar();
			if (result is int)
				Assert.Equal(1, result);
			else
				Assert.Equal(1L, result);
		}

		[Fact]
		public virtual void ExecuteScalar_returns_real()
		{
			using var connection = CreateOpenConnection();
			using var command = connection.CreateCommand();
			command.CommandText = "SELECT 3.14;";
			var result = command.ExecuteScalar();
			if (result is double)
				Assert.Equal(3.14, result);
			else
				Assert.Equal(3.14m, result);
		}

		[Fact]
		public virtual void ExecuteScalar_returns_string_when_text()
		{
			using var connection = CreateOpenConnection();
			using var command = connection.CreateCommand();
			command.CommandText = "SELECT 'test';";
			Assert.Equal("test", command.ExecuteScalar());
		}

		[Fact]
		public virtual void ExecuteScalar_returns_DBNull_when_null()
		{
			using var connection = CreateOpenConnection();
			using var command = connection.CreateCommand();
			command.CommandText = "SELECT NULL;";
			Assert.Equal(DBNull.Value, command.ExecuteScalar());
		}

		[Fact]
		public virtual void ExecuteScalar_returns_first_when_batching()
		{
			using var connection = CreateOpenConnection();
			using var command = connection.CreateCommand();
			command.CommandText = "SELECT 42; SELECT 43;";
			Assert.Equal(42, Convert.ToInt32(command.ExecuteScalar()));
		}

		[Fact]
		public virtual void ExecuteScalar_returns_first_when_multiple_columns()
		{
			using var connection = CreateOpenConnection();
			using var command = connection.CreateCommand();
			command.CommandText = "SELECT 42, 43;";
			Assert.Equal(42, Convert.ToInt32(command.ExecuteScalar()));
		}

		[Fact]
		public virtual void ExecuteScalar_returns_first_when_multiple_rows()
		{
			using var connection = CreateOpenConnection();
			using var command = connection.CreateCommand();
			command.CommandText = "SELECT 42 UNION SELECT 43;";
			Assert.Equal(42, Convert.ToInt32(command.ExecuteScalar()));
		}

		[Fact]
		public virtual void ExecuteNonQuery_throws_when_no_connection()
		{
			using var command = Fixture.Factory.CreateCommand();
			Assert.Throws<InvalidOperationException>(() => command.ExecuteNonQuery());
		}

		[Fact]
		public virtual void ExecuteNonQuery_throws_when_connection_closed()
		{
			using var connection = CreateConnection();
			using var command = connection.CreateCommand();
			Assert.Throws<InvalidOperationException>(() => command.ExecuteNonQuery());
		}

		[Fact]
		public virtual void ExecuteNonQuery_throws_when_no_command_text()
		{
			using var connection = CreateOpenConnection();
			using var command = connection.CreateCommand();
			Assert.Throws<InvalidOperationException>(() => command.ExecuteNonQuery());
		}

		[Fact]
		public virtual void ExecuteNonQuery_returns_negative_one_for_SELECT()
		{
			using var connection = CreateOpenConnection();
			using var command = connection.CreateCommand();
			command.CommandText = "SELECT 1;";
			Assert.Equal(-1, command.ExecuteNonQuery());
		}

		[Fact]
		public virtual async Task ExecuteReaderAsync_throws_when_no_connection()
		{
			using var command = Fixture.Factory.CreateCommand();
			await Assert.ThrowsAsync<InvalidOperationException>(command.ExecuteReaderAsync);
		}

		[Fact]
		public virtual async Task ExecuteReaderAsync_throws_when_connection_closed()
		{
			using var connection = CreateConnection();
			using var command = connection.CreateCommand();
			await Assert.ThrowsAsync<InvalidOperationException>(command.ExecuteReaderAsync);
		}

		[Fact]
		public virtual async Task ExecuteReaderAsync_throws_when_no_command_text()
		{
			using var connection = CreateOpenConnection();
			using var command = connection.CreateCommand();
			await Assert.ThrowsAsync<InvalidOperationException>(command.ExecuteReaderAsync);
		}

		[Fact]
		public virtual async Task ExecuteReaderAsync_throws_on_error()
		{
			using var connection = CreateOpenConnection();
			using var command = connection.CreateCommand();
			command.CommandText = "INVALID;";
			await Assert.ThrowsAnyAsync<DbException>(command.ExecuteReaderAsync);
		}

		[Fact]
		public virtual async Task ExecuteScalarAsync_throws_when_no_connection()
		{
			using var command = Fixture.Factory.CreateCommand();
			await Assert.ThrowsAsync<InvalidOperationException>(command.ExecuteScalarAsync);
		}

		[Fact]
		public virtual async Task ExecuteScalarAsync_throws_when_connection_closed()
		{
			using var connection = CreateConnection();
			using var command = connection.CreateCommand();
			await Assert.ThrowsAsync<InvalidOperationException>(command.ExecuteScalarAsync);
		}

		[Fact]
		public virtual async Task ExecuteScalarAsync_throws_when_no_command_text()
		{
			using var connection = CreateOpenConnection();
			using var command = connection.CreateCommand();
			await Assert.ThrowsAsync<InvalidOperationException>(command.ExecuteScalarAsync);
		}

		[Fact]
		public virtual async Task ExecuteScalarAsync_throws_on_error()
		{
			using var connection = CreateOpenConnection();
			using var command = connection.CreateCommand();
			command.CommandText = "INVALID;";
			await Assert.ThrowsAnyAsync<DbException>(command.ExecuteScalarAsync);
		}

		[Fact]
		public virtual async Task ExecuteReaderAsync_is_canceled()
		{
			using var connection = CreateOpenConnection();
			using var command = connection.CreateCommand();
			command.CommandText = "SELECT 1;";
			var task = command.ExecuteReaderAsync(CanceledToken);
			await Assert.ThrowsAnyAsync<OperationCanceledException>(() => task);
			Assert.True(task.IsCanceled);
		}

		[Fact]
		public virtual async Task ExecuteNonQueryAsync_is_canceled()
		{
			using var connection = CreateOpenConnection();
			using var command = connection.CreateCommand();
			command.CommandText = "SELECT 1;";
			var task = command.ExecuteNonQueryAsync(CanceledToken);
			await Assert.ThrowsAnyAsync<OperationCanceledException>(() => task);
			Assert.True(task.IsCanceled);
		}

		[Fact]
		public virtual async Task ExecuteScalarAsync_is_canceled()
		{
			using var connection = CreateOpenConnection();
			using var command = connection.CreateCommand();
			command.CommandText = "SELECT 1;";
			var task = command.ExecuteScalarAsync(CanceledToken);
			await Assert.ThrowsAnyAsync<OperationCanceledException>(() => task);
			Assert.True(task.IsCanceled);
		}

		[Fact]
		public virtual void Execute_throws_for_unknown_ParameterValue_type()
		{
			using var connection = CreateOpenConnection();
			using var command = connection.CreateCommand();
			command.CommandText = "SELECT @Parameter;";
			var parameter = command.CreateParameter();
			parameter.ParameterName = "@Parameter";
			parameter.Value = new CustomClass();
			command.Parameters.Add(parameter);

			try
			{
				var value = command.ExecuteScalar();
				if (!"custom".Equals((string) value))
					throw new UnexpectedValueException(value);
			}
			catch (Exception ex) when (ex is NotSupportedException || ex is InvalidOperationException)
			{
			}
			catch (Exception ex) when (!(ex is UnexpectedValueException))
			{
				throw new ThrowsException(typeof(NotSupportedException), ex);
			}
		}

		protected class CustomClass
		{
			public override string ToString() => "custom";
		}
	}
}
