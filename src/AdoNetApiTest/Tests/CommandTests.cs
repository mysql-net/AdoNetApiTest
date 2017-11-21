using System;
using System.Data;
using System.Data.Common;

namespace AdoNetApiTest.Tests
{
	public sealed class CommandTests : TestBase
	{
		public bool CreateCommand_sets_Connection_property()
		{
			using (var connection = CreateOpenConnection())
			using (var command = connection.CreateCommand())
			{
				return ReferenceEquals(connection, command.Connection);
			}
		}

		[ImplementationSpecific]
		public bool CreateCommand_does_not_set_Transaction_property()
		{
			using (var connection = CreateOpenConnection())
			using (var transaction = connection.BeginTransaction())
			using (var command = connection.CreateCommand())
			{
				return command.Transaction == null;
			}
		}

		public TestResult CommandText_throws_when_set_when_open_reader()
		{
			using (var connection = CreateOpenConnection())
			using (var command = connection.CreateCommand())
			{
				command.CommandText = "SELECT 1;";

				using (var reader = command.ExecuteReader())
				{
					reader.Read();

					return Throws<InvalidOperationException>(() => command.CommandText = "SELECT 2;");
				}
			}
		}

		public bool Connection_can_be_unset()
		{
			using (var connection = CreateOpenConnection())
			using (var command = connection.CreateCommand())
			{
				command.CommandText = "SELECT 1;";

				command.Connection = null;
				return command.Connection == null;
			}
		}

		public TestResult Connection_throws_when_set_when_open_reader()
		{
			using (var connection = CreateOpenConnection())
			using (var command = connection.CreateCommand())
			{
				command.CommandText = "SELECT 1;";

				using (var reader = command.ExecuteReader())
				{
					reader.Read();

					return Throws<InvalidOperationException>(() => command.Connection = Connector.CreateConnection());
				}
			}
		}

		public bool CommandType_text_by_default()
		{
			using (var command = Connector.CreateCommand())
				return command.CommandType == CommandType.Text;
		}

		public bool Parameters_is_not_null()
		{
			using (var command = Connector.CreateCommand())
				return command.Parameters != null;
		}

		public bool Parameters_returns_same_object()
		{
			using (var command = Connector.CreateCommand())
			{
				var parameters = command.Parameters;
				return object.ReferenceEquals(parameters, command.Parameters);
			}
		}

		public bool CreateParameter_is_not_null()
		{
			using (var command = Connector.CreateCommand())
				return command.CreateParameter() != null;
		}

		public TestResult Prepare_throws_when_no_connection()
		{
			using (var command = Connector.CreateCommand())
				return Throws<InvalidOperationException>(() => command.Prepare());
		}

		public TestResult Prepare_throws_when_connection_closed()
		{
			using (var connection = Connector.CreateConnection())
			using (var command = connection.CreateCommand())
				return Throws<InvalidOperationException>(() => command.Prepare());
		}

		public TestResult Prepare_throws_when_no_command_text()
		{
			using (var connection = CreateOpenConnection())
			using (var command = connection.CreateCommand())
				return Throws<InvalidOperationException>(() => command.Prepare());
		}

		public TestResult ExecuteReader_throws_when_no_connection()
		{
			using (var command = Connector.CreateCommand())
				return Throws<InvalidOperationException>(() => command.ExecuteReader());
		}

		public TestResult ExecuteReader_throws_when_connection_closed()
		{
			using (var connection = Connector.CreateConnection())
			using (var command = connection.CreateCommand())
				return Throws<InvalidOperationException>(() => command.ExecuteReader());
		}

		public TestResult ExecuteReader_throws_when_no_command_text()
		{
			using (var connection = CreateOpenConnection())
			using (var command = connection.CreateCommand())
				return Throws<InvalidOperationException>(() => command.ExecuteReader());
		}

		public TestResult ExecuteReader_throws_on_error()
		{
			using (var connection = CreateOpenConnection())
			using (var command = connection.CreateCommand())
			{
				command.CommandText = "INVALID;";
				return Throws<DbException>(() => command.ExecuteReader());
			}
		}

		public TestResult ExecuteReader_throws_when_transaction_required()
		{
			using (var connection = CreateOpenConnection())
			using (var command = connection.CreateCommand())
			{
				command.CommandText = "SELECT 1;";

				using (connection.BeginTransaction())
				{
					return Throws<InvalidOperationException>(() => command.ExecuteReader());
				}
			}
		}

		public TestResult ExecuteReader_throws_when_transaction_mismatched()
		{
			using (var connection = CreateOpenConnection())
			using (var command = connection.CreateCommand())
			{
				command.CommandText = "SELECT 1;";

				using (var otherConnection = CreateOpenConnection())
				using (var otherTransaction = otherConnection.BeginTransaction())
				{
					command.Transaction = otherTransaction;

					return Throws<InvalidOperationException>(() => command.ExecuteReader());
				}
			}
		}

		public TestResult ExecuteReader_throws_when_reader_open()
		{
			using (var connection = CreateOpenConnection())
			using (var command = connection.CreateCommand())
			{
				command.CommandText = "SELECT 1;";

				using (var reader = command.ExecuteReader())
				{
					return Throws<InvalidOperationException>(() => command.ExecuteReader());
				}
			}
		}

		public bool ExecuteReader_binds_parameters()
		{
			using (var connection = CreateOpenConnection())
			using (var command = connection.CreateCommand())
			{
				command.CommandText = "SELECT @Parameter;";
				var parameter = command.CreateParameter();
				parameter.ParameterName = "@Parameter";
				parameter.Value = 1;
				command.Parameters.Add(parameter);

				var scalar = command.ExecuteScalar();
				return 1.Equals(scalar) || 1L.Equals(scalar);
			}
		}

		public TestResult ExecuteScalar_throws_when_no_connection()
		{
			using (var command = Connector.CreateCommand())
				return Throws<InvalidOperationException>(() => command.ExecuteScalar());
		}

		public TestResult ExecuteScalar_throws_when_connection_closed()
		{
			using (var connection = Connector.CreateConnection())
			using (var command = connection.CreateCommand())
				return Throws<InvalidOperationException>(() => command.ExecuteScalar());
		}

		public TestResult ExecuteScalar_throws_when_no_command_text()
		{
			using (var connection = CreateOpenConnection())
			using (var command = connection.CreateCommand())
				return Throws<InvalidOperationException>(() => command.ExecuteScalar());
		}

		/*public bool ExecuteScalar_returns_null_when_empty()
		{
			using (var connection = CreateOpenConnection())
			using (var command = connection.CreateCommand())
			{
				command.CommandText = "SELECT 1 WHERE 0 = 1;"; // not valid in all DBs
				return command.ExecuteScalar() == null;
			}
		}*/

		[ImplementationSpecific]
		public bool ExecuteScalar_returns_long_when_integer()
		{
			using (var connection = CreateOpenConnection())
			using (var command = connection.CreateCommand())
			{
				command.CommandText = "SELECT 1;";
				return 1L.Equals(command.ExecuteScalar());
			}
		}

		[ImplementationSpecific]
		public bool ExecuteScalar_returns_double_when_real()
		{
			using (var connection = CreateOpenConnection())
			using (var command = connection.CreateCommand())
			{
				command.CommandText = "SELECT 3.14;";
				return 3.14.Equals(command.ExecuteScalar());
			}
		}

		public bool ExecuteScalar_returns_string_when_text()
		{
			using (var connection = CreateOpenConnection())
			using (var command = connection.CreateCommand())
			{
				command.CommandText = "SELECT 'test';";
				return "test".Equals(command.ExecuteScalar());
			}
		}

		public bool ExecuteScalar_returns_DBNull_when_null()
		{
			using (var connection = CreateOpenConnection())
			using (var command = connection.CreateCommand())
			{
				command.CommandText = "SELECT NULL;";
				return DBNull.Value.Equals(command.ExecuteScalar());
			}
		}

		[ImplementationSpecific]
		public bool ExecuteScalar_returns_long_when_batching()
		{
			using (var connection = CreateOpenConnection())
			using (var command = connection.CreateCommand())
			{
				command.CommandText = "SELECT 42; SELECT 43;";
				return 42L.Equals(command.ExecuteScalar());
			}
		}

		[ImplementationSpecific]
		public bool ExecuteScalar_returns_long_when_multiple_columns()
		{
			using (var connection = CreateOpenConnection())
			using (var command = connection.CreateCommand())
			{
				command.CommandText = "SELECT 42, 43;";
				return 42L.Equals(command.ExecuteScalar());
			}
		}

		[ImplementationSpecific]
		public bool ExecuteScalar_returns_long_when_multiple_rows()
		{
			using (var connection = CreateOpenConnection())
			using (var command = connection.CreateCommand())
			{
				command.CommandText = "SELECT 42 UNION SELECT 43;";
				return 42L.Equals(command.ExecuteScalar());
			}
		}

		public TestResult ExecuteNonQuery_throws_when_no_connection()
		{
			using (var command = Connector.CreateCommand())
				return Throws<InvalidOperationException>(() => command.ExecuteNonQuery());
		}

		public TestResult ExecuteNonQuery_throws_when_connection_closed()
		{
			using (var connection = Connector.CreateConnection())
			using (var command = connection.CreateCommand())
				return Throws<InvalidOperationException>(() => command.ExecuteNonQuery());
		}

		public TestResult ExecuteNonQuery_throws_when_no_command_text()
		{
			using (var connection = CreateOpenConnection())
			using (var command = connection.CreateCommand())
				return Throws<InvalidOperationException>(() => command.ExecuteNonQuery());
		}

		public bool ExecuteNonQuery_returns_negative_one_for_SELECT()
		{
			using (var connection = CreateOpenConnection())
			using (var command = connection.CreateCommand())
			{
				command.CommandText = "SELECT 1;";
				return command.ExecuteNonQuery() == -1;
			}
		}

		public bool ExecuteReader_HasRows_is_false_for_comment()
		{
			using (var connection = CreateOpenConnection())
			using (var command = connection.CreateCommand())
			{
				command.CommandText = "-- TODO: Write SQL";

				using (var reader = command.ExecuteReader())
				{
					return !reader.HasRows;
				}
			}
		}

		public bool ExecuteReader_works_when_trailing_comments()
		{
			using (var connection = CreateOpenConnection())
			using (var command = connection.CreateCommand())
			{
				command.CommandText = "SELECT 0; -- My favorite number";

				using (var reader = command.ExecuteReader())
				{
					return reader.Read() && 0L.Equals(reader.GetValue(0)) && !reader.NextResult();
				}
			}
		}

		public bool ExecuteReader_supports_CloseConnection()
		{
			using (var connection = CreateOpenConnection())
			using (var command = connection.CreateCommand())
			{
				command.CommandText = "SELECT 0;";
				using (command.ExecuteReader(CommandBehavior.CloseConnection))
				{
				}
				return connection.State == ConnectionState.Closed;
			}
		}
	}
}
