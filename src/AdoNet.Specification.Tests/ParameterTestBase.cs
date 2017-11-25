using System;
using System.Data;
using System.Data.Common;
using Xunit;

namespace AdoNet.Specification.Tests
{
	public abstract class ParameterTestBase<TFixture> : DbFactoryTestBase<TFixture>
		where TFixture : class, IDbFactoryFixture
	{
		protected ParameterTestBase(TFixture fixture)
			: base(fixture)
		{
		}

		[Fact]
		public virtual void Parameter_default_DbType_is_string()
		{
			Assert.Equal(DbType.String, Fixture.Factory.CreateParameter().DbType);
		}

		[Fact]
		public virtual void Parameter_default_Direction_is_input()
		{
			Assert.Equal(ParameterDirection.Input, Fixture.Factory.CreateParameter().Direction);
		}

		[Fact]
		public virtual void Parameter_default_IsNullable_is_false()
		{
			Assert.False(Fixture.Factory.CreateParameter().IsNullable);
		}

		[Fact]
		public virtual void Parameter_default_ParameterName_is_empty_string()
		{
			Assert.Equal("", Fixture.Factory.CreateParameter().ParameterName);
		}

		[Fact]
		public virtual void Parameter_default_Precision_is_zero()
		{
			Assert.Equal((byte) 0, Fixture.Factory.CreateParameter().Precision);
		}

		[Fact]
		public virtual void Parameter_default_Scale_is_zero()
		{
			Assert.Equal((byte) 0, Fixture.Factory.CreateParameter().Scale);
		}

		[Fact]
		public virtual void Parameter_default_Size_is_zero()
		{
			Assert.Equal(0, Fixture.Factory.CreateParameter().Size);
		}

		[Fact]
		public virtual void Parameter_default_SourceColumn_is_empty_string()
		{
			Assert.Equal("", Fixture.Factory.CreateParameter().SourceColumn);
		}

		[Fact]
		public virtual void Parameter_default_SourceVersion_is_Current()
		{
			Assert.Equal(DataRowVersion.Current, Fixture.Factory.CreateParameter().SourceVersion);
		}

		[Fact]
		public virtual void Parameter_default_Value_is_null()
		{
			Assert.Null(Fixture.Factory.CreateParameter().Value);
		}

		[Fact]
		public virtual void ResetDbType_works()
		{
			var parameter = Fixture.Factory.CreateParameter();
			parameter.DbType = DbType.Int64;

			parameter.ResetDbType();

			Assert.Equal(DbType.String, parameter.DbType);
		}

		[Fact]
		public virtual void Bind_requires_set_name()
		{
			using (var connection = CreateOpenConnection())
			using (var command = connection.CreateCommand())
			{
				command.CommandText = "SELECT @Parameter;";
				var parameter = command.CreateParameter();
				parameter.Value = 1;
				command.Parameters.Add(parameter);

				AssertThrowsAny<InvalidOperationException, DbException>(() => command.ExecuteNonQuery());
			}
		}

		[Fact]
		public virtual void Bind_requires_set_value()
		{
			using (var connection = CreateOpenConnection())
			using (var command = connection.CreateCommand())
			{
				command.CommandText = "SELECT @Parameter;";
				var parameter = command.CreateParameter();
				parameter.ParameterName = "@Parameter";
				command.Parameters.Add(parameter);

				// When you send a null parameter value to the server, you must specify DBNull, not null. The null value in the system is an empty object that has no value. DBNull is used to represent null values.
				Assert.Throws<InvalidOperationException>(() => command.ExecuteNonQuery());
			}
		}

		[Fact]
		public virtual void Bind_is_noop_on_unknown_parameter()
		{
			using (var connection = CreateOpenConnection())
			using (var command = connection.CreateCommand())
			{
				command.CommandText = "SELECT 1;";
				var parameter = command.CreateParameter();
				parameter.ParameterName = "@Unknown";
				parameter.Value = 1;
				command.Parameters.Add(parameter);

				command.ExecuteNonQuery();
			}
		}
		
		[Fact]
		public virtual void Bind_throws_when_unknown()
		{
			using (var connection = CreateOpenConnection())
			using (var command = connection.CreateCommand())
			{
				command.CommandText = "SELECT @Parameter;";
				var parameter = command.CreateParameter();
				parameter.ParameterName = "@Parameter";
				parameter.Value = new object();
				command.Parameters.Add(parameter);

				AssertThrowsAny<InvalidOperationException, NotSupportedException>(() => command.ExecuteScalar());
			}
		}

		[Fact]
		public virtual void Bind_works_with_string()
		{
			using (var connection = CreateOpenConnection())
			using (var command = connection.CreateCommand())
			{
				command.CommandText = "SELECT @Parameter;";
				var parameter = command.CreateParameter();
				parameter.ParameterName = "@Parameter";
				parameter.Value = "test";
				command.Parameters.Add(parameter);

				var result = command.ExecuteScalar();
				Assert.Equal("test", result);
			}
		}

		[Fact]
		public virtual void ParameterName_can_be_set_to_null()
		{
			Fixture.Factory.CreateParameter().ParameterName = null;
		}
	}
}
