using System;
using System.Data;
using System.Data.Common;
using System.Linq;
using Xunit;

namespace AdoNet.Specification.Tests
{
	public abstract partial class GetValueConversionTestBase<TFixture> : DbFactoryTestBase<TFixture>
		where TFixture : class, IGetValueFixture
	{
		protected GetValueConversionTestBase(TFixture fixture)
			: base(fixture)
		{
			Fixture = fixture;
		}

		protected new TFixture Fixture { get; }
		protected virtual Type GetNullExceptionType() => typeof(InvalidCastException);

		protected virtual void TestGetFieldType(DbType dbType, ValueKind kind, Type expectedType) => DoTest(dbType, kind, reader => Assert.Equal(expectedType, reader.GetFieldType(0)));
		protected virtual void TestGetFieldValue<T>(DbType dbType, ValueKind kind, T expected) => DoTest(dbType, kind, reader => Assert.Equal(expected, reader.GetFieldValue<T>(0)));
		protected virtual void TestGetValue<T>(DbType dbType, ValueKind kind, Func<DbDataReader, T> getValue, T expected) => DoTest(dbType, kind, reader => Assert.Equal(expected, getValue(reader)));
		protected virtual void TestException<T>(DbType dbType, ValueKind kind, Func<DbDataReader, T> getValue, Type exceptionType) => DoTest(dbType, kind, reader => Assert.Throws(exceptionType, () => getValue(reader)));

		protected virtual void DoTest(DbType dbType, ValueKind kind, Action<DbDataReader> action)
		{
			if (!Fixture.SupportedDbTypes.Contains(dbType))
				throw new SkipTestException("Database doesn't support this data type");

			using (var connection = CreateOpenConnection())
			using (var command = connection.CreateCommand())
			{
				command.CommandText = Fixture.CreateSelectSql(dbType, kind);
				using (var reader = command.ExecuteReader())
				{
					Assert.True(reader.Read());
					action(reader);
				}
			}
		}
	}
}
