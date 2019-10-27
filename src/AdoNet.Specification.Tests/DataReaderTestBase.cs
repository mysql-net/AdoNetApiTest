using System;
using System.Data;
using System.Data.Common;
using System.IO;
using System.Threading.Tasks;
using Xunit;

namespace AdoNet.Specification.Tests
{
	[Collection("ISelectValueFixture Collection")]
	public class DataReaderTestBase<TFixture> : DbFactoryTestBase<TFixture>
		where TFixture : class, ISelectValueFixture, IDeleteFixture
	{
		public DataReaderTestBase(TFixture fixture)
			: base(fixture)
		{
			Fixture = fixture;
		}

		protected new TFixture Fixture { get; }

		[Fact]
		public virtual void Dispose_command_before_reader()
		{
			using (var connection = CreateOpenConnection())
			{
				DbDataReader reader;
				using (var command = connection.CreateCommand())
				{
					command.CommandText = "SELECT 'test';";
					reader = command.ExecuteReader();
				}

				Assert.True(reader.Read());
				Assert.Equal("test", reader.GetString(0));
				Assert.False(reader.Read());
			}
		}

		[Fact]
		public virtual void Depth_returns_zero()
		{
			using (var connection = CreateOpenConnection())
			using (var command = connection.CreateCommand())
			{
				command.CommandText = "SELECT 1;";
				using (var reader = command.ExecuteReader())
				{
					Assert.Equal(0, reader.Depth);
				}
			}
		}

		[Fact]
		public virtual void ExecuteScalar_returns_null_when_empty()
		{
			using (var connection = CreateOpenConnection())
			using (var command = connection.CreateCommand())
			{
				command.CommandText = Fixture.SelectNoRows;
				Assert.Null(command.ExecuteScalar());
			}
		}

		[Fact]
		public virtual void FieldCount_works()
		{
			using (var connection = CreateOpenConnection())
			using (var command = connection.CreateCommand())
			{
				command.CommandText = "SELECT 1;";
				using (var reader = command.ExecuteReader())
				{
					Assert.Equal(1, reader.FieldCount);
				}
			}
		}

		[Fact]
		public virtual void FieldCount_throws_when_closed()
			=> X_throws_when_closed(
				r =>
				{
					var x = r.FieldCount;
				});

		[Fact]
		public virtual void GetBytes_works()
		{
			using (var connection = CreateOpenConnection())
			using (var command = connection.CreateCommand())
			{
				command.CommandText = Fixture.CreateSelectSql(new byte[] { 0x7E, 0x57 });
				using (var reader = command.ExecuteReader())
				{
					var hasData = reader.Read();
					Assert.True(hasData);

					var buffer = new byte[2];
					Assert.Equal(2, reader.GetBytes(0, 0, buffer, 0, buffer.Length));
					Assert.Equal(new byte[] { 0x7E, 0x57 }, buffer);
				}
			}
		}

		[Fact]
		public virtual void GetChars_works()
		{
			using (var connection = CreateOpenConnection())
			using (var command = connection.CreateCommand())
			{
				command.CommandText = "SELECT 'test';";
				using (var reader = command.ExecuteReader())
				{
					var hasData = reader.Read();
					Assert.True(hasData);

					var buffer = new char[4];
					Assert.Equal(4, reader.GetChars(0, 0, buffer, 0, buffer.Length));
					Assert.Equal(new[] { 't', 'e', 's', 't' }, buffer);
				}
			}
		}

		[Fact]
		public virtual void GetDataTypeName_throws_when_ordinal_out_of_range()
		{
			using (var connection = CreateOpenConnection())
			using (var command = connection.CreateCommand())
			{
				command.CommandText = "SELECT 1;";
				using (var reader = command.ExecuteReader())
				{
					Assert.Throws<IndexOutOfRangeException>(() => reader.GetDataTypeName(1));
				}
			}
		}

		[Fact]
		public virtual void GetDataTypeName_throws_when_closed()
			=> X_throws_when_closed(r => r.GetDataTypeName(0));

		[Fact]
		public virtual void GetEnumerator_works()
		{
			using (var connection = CreateOpenConnection())
			using (var command = connection.CreateCommand())
			{
				command.CommandText = "SELECT 1;";
				using (var reader = command.ExecuteReader())
				{
					var hasData = reader.Read();
					Assert.True(hasData);

					Assert.NotNull(reader.GetEnumerator());
				}
			}
		}

		[Fact]
		public virtual void GetFieldValue_of_DBNull_throws_when_not_null()
		{
			using (var connection = CreateOpenConnection())
			using (var command = connection.CreateCommand())
			{
				command.CommandText = "SELECT 1;";
				using (var reader = command.ExecuteReader())
				{
					var hasData = reader.Read();

					Assert.True(hasData);
					Assert.Throws<InvalidCastException>(() => reader.GetFieldValue<DBNull>(0));
				}
			}
		}

		[Fact]
		public virtual void GetFieldValue_throws_before_read()
			=> X_throws_before_read(r => r.GetFieldValue<DBNull>(0));

		[Fact]
		public virtual void GetFieldValue_throws_when_done()
			=> X_throws_when_done(r => r.GetFieldValue<DBNull>(0));

		[Fact]
		public virtual async Task GetFieldValueAsync_is_canceled()
		{
			using (var connection = CreateOpenConnection())
			using (var command = connection.CreateCommand())
			{
				command.CommandText = "SELECT 1;";
				using (var reader = command.ExecuteReader())
				{
					reader.Read();

					var task = reader.GetFieldValueAsync<int>(0, CanceledToken);
					await Assert.ThrowsAnyAsync<OperationCanceledException>(() => task);
					Assert.True(task.IsCanceled);
				}
			}
		}

		[Fact]
		public virtual void GetFieldType_works()
		{
			using (var connection = CreateOpenConnection())
			using (var command = connection.CreateCommand())
			{
				command.CommandText = "SELECT 'test';";
				using (var reader = command.ExecuteReader())
				{
					Assert.Equal(typeof(string), reader.GetFieldType(0));
				}
			}
		}

		[Fact]
		public virtual void GetFieldType_throws_when_ordinal_out_of_range()
		{
			using (var connection = CreateOpenConnection())
			using (var command = connection.CreateCommand())
			{
				command.CommandText = "SELECT 1;";
				using (var reader = command.ExecuteReader())
				{
					Assert.Throws<IndexOutOfRangeException>(() => reader.GetFieldType(1));
				}
			}
		}

		[Fact]
		public virtual void GetFieldType_throws_when_closed()
			=> X_throws_when_closed(r => r.GetFieldType(0));

		[Fact]
		public virtual void GetName_works()
		{
			using (var connection = CreateOpenConnection())
			using (var command = connection.CreateCommand())
			{
				command.CommandText = "SELECT 1 AS id;";
				using (var reader = command.ExecuteReader())
				{
					Assert.Equal("id", reader.GetName(0));
				}
			}
		}

		[Fact]
		public virtual void GetName_throws_when_ordinal_out_of_range()
		{
			using (var connection = CreateOpenConnection())
			using (var command = connection.CreateCommand())
			{
				command.CommandText = "SELECT 1;";
				using (var reader = command.ExecuteReader())
				{
					Assert.Throws<IndexOutOfRangeException>(() => reader.GetName(1));
				}
			}
		}

		[Fact]
		public virtual void GetName_throws_when_closed()
			=> X_throws_when_closed(r => r.GetName(0));

		[Fact]
		public virtual void GetOrdinal_works()
		{
			using (var connection = CreateOpenConnection())
			using (var command = connection.CreateCommand())
			{
				command.CommandText = "SELECT 1 AS Id;";
				using (var reader = command.ExecuteReader())
				{
					Assert.Equal(0, reader.GetOrdinal("Id"));
				}
			}
		}

		[Fact]
		public virtual void GetOrdinal_throws_when_out_of_range()
		{
			using (var connection = CreateOpenConnection())
			using (var command = connection.CreateCommand())
			{
				command.CommandText = "SELECT 1;";
				using (var reader = command.ExecuteReader())
				{
					Assert.Throws<IndexOutOfRangeException>(() => reader.GetOrdinal("Name"));
				}
			}
		}

		[Fact]
		public virtual void GetString_works_utf8_two_bytes() => GetX_works("SELECT 'Ä';", r => r.GetString(0), "Ä");

		[Fact]
		public virtual void GetString_works_utf8_three_bytes() => GetX_works("SELECT 'Ḁ';", r => r.GetString(0), "Ḁ");

		[Fact]
		public virtual void GetString_works_utf8_four_bytes() => GetX_works("SELECT '😀';", r => r.GetString(0), "😀");

		[Fact]
		public virtual void GetFieldValue_works_utf8_two_bytes() => GetX_works("SELECT 'Ä';", r => r.GetFieldValue<string>(0), "Ä");

		[Fact]
		public virtual void GetFieldValue_works_utf8_three_bytes() => GetX_works("SELECT 'Ḁ';", r => r.GetFieldValue<string>(0), "Ḁ");

		[Fact]
		public virtual void GetFieldValue_works_utf8_four_bytes() => GetX_works("SELECT '😀';", r => r.GetFieldValue<string>(0), "😀");

		[Fact]
		public virtual void GetValue_to_string_works_utf8_two_bytes() => GetX_works("SELECT 'Ä';", r => r.GetValue(0) as string, "Ä");

		[Fact]
		public virtual void GetValue_to_string_works_utf8_three_bytes() => GetX_works("SELECT 'Ḁ';", r => r.GetValue(0) as string, "Ḁ");

		[Fact]
		public virtual void GetValue_to_string_works_utf8_four_bytes() => GetX_works("SELECT '😀';", r => r.GetValue(0) as string, "😀");

		[Fact]
		public virtual void GetString_works()
			=> GetX_works(
				"SELECT 'test';",
				r => r.GetString(0),
				"test");

		[Fact]
		public virtual void GetValue_throws_before_read()
			=> X_throws_before_read(r => r.GetValue(0));

		[Fact]
		public virtual void GetValue_throws_when_done()
			=> X_throws_when_done(r => r.GetValue(0));

		[Fact]
		public virtual void GetValue_throws_when_closed()
			=> X_throws_when_closed(r => r.GetValue(0));

		[Fact]
		public virtual void GetValues_works()
		{
			using (var connection = CreateOpenConnection())
			using (var command = connection.CreateCommand())
			{
				command.CommandText = "SELECT 'a', 'b';";
				using (var reader = command.ExecuteReader())
				{
					var hasData = reader.Read();
					Assert.True(hasData);

					// Array may be wider than row
					var values = new object[3];
					var result = reader.GetValues(values);

					Assert.Equal(2, result);
					Assert.Equal("a", values[0]);
					Assert.Equal("b", values[1]);
				}
			}
		}

		[Fact]
		public virtual void GetValues_when_too_narrow()
		{
			using (var connection = CreateOpenConnection())
			using (var command = connection.CreateCommand())
			{
				command.CommandText = "SELECT 1;";
				using (var reader = command.ExecuteReader())
				{
					var hasData = reader.Read();
					Assert.True(hasData);

					var values = new object[0];
					Assert.Equal(0, reader.GetValues(values));
				}
			}
		}

		[Fact]
		public virtual void GetValues_throws_for_null()
		{
			using (var connection = CreateOpenConnection())
			using (var command = connection.CreateCommand())
			{
				command.CommandText = "SELECT 1;";
				using (var reader = command.ExecuteReader())
				{
					reader.Read();
					Assert.Throws<ArgumentNullException>(() => reader.GetValues(default(object[])));
				}
			}
		}

		[Fact]
		public virtual void HasRows_returns_true_when_rows()
		{
			using (var connection = CreateOpenConnection())
			using (var command = connection.CreateCommand())
			{
				command.CommandText = "SELECT 1;";
				using (var reader = command.ExecuteReader())
				{
					Assert.True(reader.HasRows);
				}
			}
		}

		[Fact]
		public virtual void HasRows_returns_false_when_no_rows()
		{
			using (var connection = CreateOpenConnection())
			using (var command = connection.CreateCommand())
			{
				command.CommandText = Fixture.SelectNoRows;
				using (var reader = command.ExecuteReader())
				{
					Assert.False(reader.HasRows);
				}
			}
		}

		[Fact]
		public virtual void HasRows_works_when_batching()
		{
			using (var connection = CreateOpenConnection())
			using (var command = connection.CreateCommand())
			{
				command.CommandText = Fixture.SelectNoRows + "SELECT 1;";
				using (var reader = command.ExecuteReader())
				{
					Assert.False(reader.HasRows);

					reader.NextResult();

					Assert.True(reader.HasRows);
				}
			}
		}

		[Fact]
		public virtual void IsClosed_returns_false_when_active()
		{
			using (var connection = CreateOpenConnection())
			using (var command = connection.CreateCommand())
			{
				command.CommandText = "SELECT 1;";
				using (var reader = command.ExecuteReader())
				{
					Assert.False(reader.IsClosed);
				}
			}
		}

		[Fact]
		public virtual void IsClosed_returns_true_when_closed()
		{
			using (var connection = CreateOpenConnection())
			using (var command = connection.CreateCommand())
			{
				command.CommandText = "SELECT 1;";
				var reader = command.ExecuteReader();
				reader.Close();

				Assert.True(reader.IsClosed);
			}
		}

		[Fact]
		public virtual void IsDBNull_works()
		{
			using (var connection = CreateOpenConnection())
			using (var command = connection.CreateCommand())
			{
				command.CommandText = "SELECT NULL;";
				using (var reader = command.ExecuteReader())
				{
					var hasData = reader.Read();

					Assert.True(hasData);
					Assert.True(reader.IsDBNull(0));
				}
			}
		}

		[Fact]
		public virtual async Task IsDBNullAsync_is_canceled()
		{
			using (var connection = CreateOpenConnection())
			using (var command = connection.CreateCommand())
			{
				command.CommandText = "SELECT 1;";
				using (var reader = command.ExecuteReader())
				{
					reader.Read();

					var task = reader.IsDBNullAsync(0, CanceledToken);
					await Assert.ThrowsAnyAsync<OperationCanceledException>(() => task);
					Assert.True(task.IsCanceled);
				}
			}
		}

		[Fact]
		public virtual void IsDBNull_throws_before_read()
			=> X_throws_before_read(r => r.IsDBNull(0));

		[Fact]
		public virtual void IsDBNull_throws_when_done()
			=> X_throws_when_done(r => r.IsDBNull(0));

		[Fact]
		public virtual void IsDBNull_throws_when_closed()
			=> X_throws_when_closed(r => r.IsDBNull(0));

		[Fact]
		public virtual void Item_by_ordinal_works()
		{
			using (var connection = CreateOpenConnection())
			using (var command = connection.CreateCommand())
			{
				command.CommandText = "SELECT 'test';";
				using (var reader = command.ExecuteReader())
				{
					var hasData = reader.Read();
					Assert.True(hasData);

					Assert.Equal("test", reader[0]);
				}
			}
		}

		[Fact]
		public virtual void Item_by_name_works()
		{
			using (var connection = CreateOpenConnection())
			using (var command = connection.CreateCommand())
			{
				command.CommandText = "SELECT 'test' AS Id;";
				using (var reader = command.ExecuteReader())
				{
					var hasData = reader.Read();
					Assert.True(hasData);

					Assert.Equal("test", reader["Id"]);
				}
			}
		}

		[Fact]
		public virtual void NextResult_works()
		{
			using (var connection = CreateOpenConnection())
			using (var command = connection.CreateCommand())
			{
				command.CommandText = "SELECT 1; SELECT 2";
				using (var reader = command.ExecuteReader())
				{
					var hasData = reader.Read();
					Assert.True(hasData);
					Assert.Equal(1L, reader.GetInt64(0));

					var hasResults = reader.NextResult();
					Assert.True(hasResults);

					hasData = reader.Read();
					Assert.True(hasData);
					Assert.Equal(2L, reader.GetInt64(0));

					hasResults = reader.NextResult();
					Assert.False(hasResults);
				}
			}
		}

		[Fact]
		public virtual void SingleRow_returns_one_row()
		{
			using var connection = CreateOpenConnection();
			using var command = connection.CreateCommand();
			command.CommandText = "SELECT 1 UNION SELECT 2;";

			using var reader = command.ExecuteReader(CommandBehavior.SingleRow);
			var hasData = reader.Read();
			Assert.True(hasData);
			Assert.Equal(1L, Convert.ToInt64(reader.GetValue(0)));
			Assert.False(reader.Read());

			Assert.False(reader.NextResult());
		}

		[Fact]
		public virtual void SingleRow_returns_one_result_set()
		{
			using var connection = CreateOpenConnection();
			using var command = connection.CreateCommand();
			command.CommandText = "SELECT 1; SELECT 2; SELECT 3;";

			using var reader = command.ExecuteReader(CommandBehavior.SingleRow);
			var hasData = reader.Read();
			Assert.True(hasData);
			Assert.Equal(1L, Convert.ToInt64(reader.GetValue(0)));
			Assert.False(reader.Read());

			Assert.False(reader.NextResult());
		}

		[Fact]
		public virtual void SingleResult_returns_one_result_set()
		{
			using var connection = CreateOpenConnection();
			using var command = connection.CreateCommand();
			command.CommandText = "SELECT 1; SELECT 2; SELECT 3;";

			using var reader = command.ExecuteReader(CommandBehavior.SingleResult);
			var hasData = reader.Read();
			Assert.True(hasData);
			Assert.Equal(1L, Convert.ToInt64(reader.GetValue(0)));
			Assert.False(reader.Read());

			Assert.False(reader.NextResult());
		}

		[Fact]
		public virtual void NextResult_can_be_called_more_than_once()
		{
			using (var connection = CreateOpenConnection())
			using (var command = connection.CreateCommand())
			{
				command.CommandText = "SELECT 1;";
				using (var reader = command.ExecuteReader())
				{
					var hasResults = reader.NextResult();
					Assert.False(hasResults);

					hasResults = reader.NextResult();
					Assert.False(hasResults);
				}
			}
		}

		[Fact]
		public virtual void Read_works()
		{
			using (var connection = CreateOpenConnection())
			using (var command = connection.CreateCommand())
			{
				command.CommandText = "SELECT 1 UNION SELECT 2;";
				using (var reader = command.ExecuteReader())
				{
					var hasData = reader.Read();
					Assert.True(hasData);
					Assert.Equal(1L, reader.GetInt64(0));

					hasData = reader.Read();
					Assert.True(hasData);
					Assert.Equal(2L, reader.GetInt64(0));

					hasData = reader.Read();
					Assert.False(hasData);
				}
			}
		}

		[Fact]
		public virtual void Read_keeps_returning_false()
		{
			using (var connection = CreateOpenConnection())
			using (var command = connection.CreateCommand())
			{
				command.CommandText = Fixture.CreateSelectSql(DbType.String, ValueKind.Empty);
				using (var reader = command.ExecuteReader())
				{
					Assert.True(reader.Read());
					Assert.False(reader.Read());
					Assert.False(reader.Read());
					Assert.False(reader.Read());
				}
			}
		}

		[Fact]
		public virtual void Read_throws_when_closed() => X_throws_when_closed(r => r.Read());

		[Fact]
		public virtual void NextResult_throws_when_closed() => X_throws_when_closed(r => r.NextResult());

		[Fact]
		public virtual void GetBytes_throws_when_dataOffset_is_negative() => TestGetBytes(reader =>
		{
			AssertThrowsAny<ArgumentOutOfRangeException, IndexOutOfRangeException, InvalidOperationException>(() => reader.GetBytes(0, -1, new byte[4], 0, 4));
		});

		[Fact]
		public virtual void GetBytes_reads_nothing_when_dataOffset_is_too_large() => TestGetBytes(reader =>
		{
			Assert.Equal(0, reader.GetBytes(0, 6, new byte[4], 0, 4));
		});

		[Fact]
		public virtual void GetBytes_returns_length_when_buffer_is_null() => TestGetBytes(reader =>
		{
			Assert.Equal(4, reader.GetBytes(0, 0, null, 0, 0));
		});

		[Fact]
		public virtual void GetBytes_throws_when_bufferOffset_is_negative() => TestGetBytes(reader =>
		{
			AssertThrowsAny<ArgumentOutOfRangeException, IndexOutOfRangeException>(() => reader.GetBytes(0, 0, new byte[4], -1, 4));
		});

		[Fact]
		public virtual void GetBytes_throws_when_bufferOffset_is_too_large() => TestGetBytes(reader =>
		{
			AssertThrowsAny<ArgumentOutOfRangeException, IndexOutOfRangeException>(() => reader.GetBytes(0, 0, new byte[4], 5, 0));
		});

		[Fact]
		public virtual void GetBytes_reads_nothing_at_end_of_buffer() => TestGetBytes(reader =>
		{
			Assert.Equal(0, reader.GetBytes(0, 0, new byte[4], 4, 0));
		});

		[Fact]
		public virtual void GetBytes_throws_when_bufferOffset_plus_length_is_too_long() => TestGetBytes(reader =>
		{
			AssertThrowsAny<ArgumentException, IndexOutOfRangeException>(() => reader.GetBytes(0, 0, new byte[4], 2, 3));
		});

		[Fact]
		public virtual void GetBytes_works_when_buffer_is_large() => TestGetBytes(reader =>
		{
			var buffer = new byte[6];
			Assert.Equal(4, reader.GetBytes(0, 0, buffer, 0, 6));
			Assert.Equal(new byte[] { 1, 2, 3, 4, 0, 0 }, buffer);
		});

		[Fact]
		public virtual void GetBytes_reads_part_of_blob() => TestGetBytes(reader =>
		{
			var buffer = new byte[5];
			Assert.Equal(2, reader.GetBytes(0, 1, buffer, 2, 2));
			Assert.Equal(new byte[] { 0, 0, 2, 3, 0 }, buffer);
		});

		private void TestGetBytes(Action<DbDataReader> action)
		{
			using (var connection = CreateOpenConnection())
			using (var command = connection.CreateCommand())
			{
				command.CommandText = Fixture.CreateSelectSql(new byte[] { 1, 2, 3, 4 });
				using (var reader = command.ExecuteReader())
				{
					reader.Read();
					action(reader);
				}
			}
		}

		[Fact]
		public virtual void GetChars_throws_when_dataOffset_is_negative() => TestGetChars(reader =>
		{
			AssertThrowsAny<ArgumentOutOfRangeException, IndexOutOfRangeException, InvalidOperationException>(() => reader.GetChars(0, -1, new char[4], 0, 4));
		});

		[Fact]
		public virtual void GetChars_reads_nothing_when_dataOffset_is_too_large() => TestGetChars(reader =>
		{
			Assert.Equal(0, reader.GetChars(0, 6, new char[4], 0, 4));
		});

		[Fact]
		public virtual void GetChars_returns_length_when_buffer_is_null() => TestGetChars(reader =>
		{
			Assert.Equal(4, reader.GetChars(0, 0, null, 0, 0));
		});

		[Fact]
		public virtual void GetChars_throws_when_bufferOffset_is_negative() => TestGetChars(reader =>
		{
			AssertThrowsAny<ArgumentOutOfRangeException, IndexOutOfRangeException>(() => reader.GetChars(0, 0, new char[4], -1, 4));
		});

		[Fact]
		public virtual void GetChars_throws_when_bufferOffset_is_too_large() => TestGetChars(reader =>
		{
			AssertThrowsAny<ArgumentOutOfRangeException, IndexOutOfRangeException>(() => reader.GetChars(0, 0, new char[4], 5, 0));
		});

		[Fact]
		public virtual void GetChars_reads_nothing_at_end_of_buffer() => TestGetChars(reader =>
		{
			Assert.Equal(0, reader.GetChars(0, 0, new char[4], 4, 0));
		});

		[Fact]
		public virtual void GetChars_throws_when_bufferOffset_plus_length_is_too_long() => TestGetChars(reader =>
		{
			AssertThrowsAny<ArgumentException, IndexOutOfRangeException>(() => reader.GetChars(0, 0, new char[4], 2, 3));
		});

		[Fact]
		public virtual void GetChars_works_when_buffer_is_large() => TestGetChars(reader =>
		{
			var buffer = new char[6];
			Assert.Equal(4, reader.GetChars(0, 0, buffer, 0, 6));
			Assert.Equal(new[] { 'a', 'b', 'c', 'd', '\0', '\0' }, buffer);
		});

		[Fact]
		public virtual void GetChars_reads_part_of_string() => TestGetChars(reader =>
		{
			var buffer = new char[5];
			Assert.Equal(2, reader.GetChars(0, 1, buffer, 2, 2));
			Assert.Equal(new[] { '\0', '\0', 'b', 'c', '\0' }, buffer);
		});

		private void TestGetChars(Action<DbDataReader> action)
		{
			using (var connection = CreateOpenConnection())
			using (var command = connection.CreateCommand())
			{
				command.CommandText = "SELECT 'abcd';";
				using (var reader = command.ExecuteReader())
				{
					reader.Read();
					action(reader);
				}
			}
		}

		[Fact]
		public virtual void GetTextReader_for_one_String() => TestGetTextReader(ValueKind.One, "1");

		[Fact]
		public virtual void GetTextReader_for_empty_String() => TestGetTextReader(ValueKind.Empty, "");

		[Fact]
		public virtual void GetTextReader_returns_empty_for_null_String() => TestGetTextReader(ValueKind.Null, "");

		[Fact]
		public virtual void GetTextReader_throws_for_null_String()
		{
			using (var connection = CreateOpenConnection())
			using (var command = connection.CreateCommand())
			{
				command.CommandText = Fixture.CreateSelectSql(DbType.String, ValueKind.Null);
				using (var reader = command.ExecuteReader())
				{
					reader.Read();
					Assert.Throws<InvalidCastException>(() => reader.GetTextReader(0));
				}
			}
		}

		[Fact]
		public virtual void GetFieldValue_for_TextReader()
		{
			using (var connection = CreateOpenConnection())
			using (var command = connection.CreateCommand())
			{
				command.CommandText = Fixture.CreateSelectSql(DbType.String, ValueKind.One);
				using (var reader = command.ExecuteReader())
				{
					reader.Read();
					using (var textReader = reader.GetFieldValue<TextReader>(0))
						Assert.Equal("1", textReader.ReadToEnd());
				}
			}
		}

		[Fact]
		public virtual void GetFieldValue_for_TextReader_throws_for_null_String()
		{
			using (var connection = CreateOpenConnection())
			using (var command = connection.CreateCommand())
			{
				command.CommandText = Fixture.CreateSelectSql(DbType.String, ValueKind.Null);
				using (var reader = command.ExecuteReader())
				{
					reader.Read();
					Assert.Throws<InvalidCastException>(() => reader.GetFieldValue<TextReader>(0));
				}
			}
		}

		[Fact]
		public virtual void FieldCount_is_zero_after_Delete() => Test_X_after_Delete(x => Assert.Equal(0, x.FieldCount));

		[Fact]
		public virtual void IsDBNull_throws_after_Delete() => Test_X_after_Delete(x => Assert.Throws<InvalidOperationException>(() => x.IsDBNull(0)));

		[Fact]
		public virtual async Task IsDBNullAsync_throws_after_Delete() => await Test_X_after_Delete(async x => await Assert.ThrowsAsync<InvalidOperationException>(async () => await x.IsDBNullAsync(0)));

		[Fact]
		public virtual void Read_returns_false_after_Delete() => Test_X_after_Delete(x => Assert.False(x.Read()));

		[Fact]
		public virtual void NextResult_returns_false_after_Delete() => Test_X_after_Delete(x => Assert.False(x.NextResult()));

		[Fact]
		public virtual void GetDataTypeName_throws_after_Delete() => Test_X_after_Delete(x => Assert.Throws<InvalidOperationException>(() => x.GetDataTypeName(0)));

		[Fact]
		public virtual void GetFieldType_throws_after_Delete() => Test_X_after_Delete(x => Assert.Throws<InvalidOperationException>(() => x.GetFieldType(0)));

		[Fact]
		public virtual void GetFieldValue_throws_after_Delete() => Test_X_after_Delete(x => Assert.Throws<InvalidOperationException>(() => x.GetFieldValue<object>(0)));

		[Fact]
		public virtual async Task GetFieldValueAsync_throws_after_Delete() => await Test_X_after_Delete(async x => await Assert.ThrowsAsync<InvalidOperationException>(async () => await x.GetFieldValueAsync<object>(0)));

		[Fact]
		public virtual void GetBoolean_throws_after_Delete() => Test_X_after_Delete(x => Assert.Throws<InvalidOperationException>(() => x.GetBoolean(0)));

		[Fact]
		public virtual void GetByte_throws_after_Delete() => Test_X_after_Delete(x => Assert.Throws<InvalidOperationException>(() => x.GetByte(0)));

		[Fact]
		public virtual void GetBytes_throws_after_Delete()
		{
			Test_X_after_Delete(x =>
			{
				var bytes = new byte[1];
				Assert.Throws<InvalidOperationException>(() => x.GetBytes(0, 0, bytes, 0, 1));
			});
		}

		[Fact]
		public virtual void GetChar_throws_after_Delete() => Test_X_after_Delete(x => Assert.Throws<InvalidOperationException>(() => x.GetChar(0)));

		[Fact]
		public virtual void GetChars_throws_after_Delete()
		{
			Test_X_after_Delete(x =>
			{
				var chars = new char[1];
				Assert.Throws<InvalidOperationException>(() => x.GetChars(0, 0, chars, 0, 1));
			});
		}

		[Fact]
		public virtual void GetDataTime_throws_after_Delete() => Test_X_after_Delete(x => Assert.Throws<InvalidOperationException>(() => x.GetDateTime(0)));

		[Fact]
		public virtual void GetDecimal_throws_after_Delete() => Test_X_after_Delete(x => Assert.Throws<InvalidOperationException>(() => x.GetDecimal(0)));

		[Fact]
		public virtual void GetDouble_throws_after_Delete() => Test_X_after_Delete(x => Assert.Throws<InvalidOperationException>(() => x.GetDouble(0)));

		[Fact]
		public virtual void GetFloat_throws_after_Delete() => Test_X_after_Delete(x => Assert.Throws<InvalidOperationException>(() => x.GetFloat(0)));

		[Fact]
		public virtual void GetGuid_throws_after_Delete() => Test_X_after_Delete(x => Assert.Throws<InvalidOperationException>(() => x.GetGuid(0)));

		[Fact]
		public virtual void GetInt16_throws_after_Delete() => Test_X_after_Delete(x => Assert.Throws<InvalidOperationException>(() => x.GetInt16(0)));

		[Fact]
		public virtual void GetInt32_throws_after_Delete() => Test_X_after_Delete(x => Assert.Throws<InvalidOperationException>(() => x.GetInt32(0)));

		[Fact]
		public virtual void GetInt64_throws_after_Delete() => Test_X_after_Delete(x => Assert.Throws<InvalidOperationException>(() => x.GetInt64(0)));

		[Fact]
		public virtual void GetSchemaTable_throws_after_Delete() => Test_X_after_Delete(x => Assert.Throws<InvalidOperationException>(() => x.GetSchemaTable()));

		[Fact]
		public virtual void GetStream_throws_after_Delete() => Test_X_after_Delete(x => Assert.Throws<InvalidOperationException>(() => x.GetStream(0)));

		[Fact]
		public virtual void GetString_throws_after_Delete() => Test_X_after_Delete(x => Assert.Throws<InvalidOperationException>(() => x.GetString(0)));

		[Fact]
		public virtual void GetTextReader_throws_after_Delete() => Test_X_after_Delete(x => Assert.Throws<InvalidOperationException>(() => x.GetTextReader(0)));

		[Fact]
		public virtual void GetName_throws_after_Delete() => Test_X_after_Delete(x => Assert.Throws<InvalidOperationException>(() => x.GetName(0)));

		[Fact]
		public virtual void GetValue_throws_after_Delete() => Test_X_after_Delete(x => Assert.Throws<InvalidOperationException>(() =>x.GetValue(0)));

		[Fact]
		public virtual void GetValues_throws_after_Delete()
		{
			Test_X_after_Delete(x => 
			{
				var values = new object[1];
				Assert.Throws<InvalidOperationException>(() => x.GetValues(values));
			});
		}

		private void TestGetTextReader(ValueKind valueKind, string expected)
		{
			using (var connection = CreateOpenConnection())
			using (var command = connection.CreateCommand())
			{
				command.CommandText = Fixture.CreateSelectSql(DbType.String, valueKind);
				using (var reader = command.ExecuteReader())
				{
					reader.Read();
					using (var textReader = reader.GetTextReader(0))
						Assert.Equal(expected, textReader.ReadToEnd());
				}
			}
		}

		private void GetX_works<T>(string sql, Func<DbDataReader, T> action, T expected)
		{
			using (var connection = CreateOpenConnection())
			using (var command = connection.CreateCommand())
			{
				command.CommandText = sql;
				using (var reader = command.ExecuteReader())
				{
					var hasData = reader.Read();

					Assert.True(hasData);
					Assert.Equal(expected, action(reader));
				}
			}
		}

		private void X_throws_before_read(Action<DbDataReader> action)
		{
			using (var connection = CreateOpenConnection())
			using (var command = connection.CreateCommand())
			{
				command.CommandText = "SELECT NULL;";
				using (var reader = command.ExecuteReader())
				{
					Assert.Throws<InvalidOperationException>(() => action(reader));
				}
			}
		}

		private void X_throws_when_done(Action<DbDataReader> action)
		{
			using (var connection = CreateOpenConnection())
			using (var command = connection.CreateCommand())
			{
				command.CommandText = "SELECT NULL;";
				using (var reader = command.ExecuteReader())
				{
					var hasData = reader.Read();
					Assert.True(hasData);

					hasData = reader.Read();
					Assert.False(hasData);

					Assert.Throws<InvalidOperationException>(() => action(reader));
				}
			}
		}

		private void X_throws_when_closed(Action<DbDataReader> action)
		{
			using (var connection = CreateOpenConnection())
			using (var command = connection.CreateCommand())
			{
				command.CommandText = "SELECT 1;";
				var reader = command.ExecuteReader();
				((IDisposable) reader).Dispose();

				Assert.Throws<InvalidOperationException>(() => action(reader));
			}
		}

		private void Test_X_after_Delete(Action<DbDataReader> action)
		{
			using (var connection = CreateOpenConnection())
			using (var command = connection.CreateCommand())
			{
				command.CommandText = Fixture.DeleteNoRows;
				using (var reader = command.ExecuteReader())
				{
					action(reader);
				}
			}
		}

		private async Task Test_X_after_Delete(Func<DbDataReader, Task> action)
		{
			using (var connection = CreateOpenConnection())
			using (var command = connection.CreateCommand())
			{
				command.CommandText = Fixture.DeleteNoRows;
				using (var reader = command.ExecuteReader())
				{
					await action(reader);
				}
			}
		}
	}
}
