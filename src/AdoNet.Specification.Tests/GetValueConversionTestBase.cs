using System;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;
using Xunit;
using Xunit.Sdk;

namespace AdoNet.Specification.Tests;

[Collection("ISelectValueFixture Collection")]
public abstract partial class GetValueConversionTestBase<TFixture> : DbFactoryTestBase<TFixture>
	where TFixture : class, ISelectValueFixture
{
	protected GetValueConversionTestBase(TFixture fixture)
		: base(fixture)
	{
		Fixture = fixture;
	}

	protected new TFixture Fixture { get; }

	protected virtual void TestGetFieldType(DbType dbType, ValueKind kind, Type expectedType) => DoTest(dbType, kind, reader => Assert.Equal(expectedType, reader.GetFieldType(0)));
	protected virtual void TestGetFieldValue<T>(DbType dbType, ValueKind kind, T expected) => DoTest(dbType, kind, reader => Assert.Equal(expected, reader.GetFieldValue<T>(0)));
	protected virtual void TestGetValue<T>(DbType dbType, ValueKind kind, T expected) => DoTest(dbType, kind, reader => Assert.Equal(expected, reader.GetValue(0)));
	protected virtual void TestGetValue<T>(DbType dbType, ValueKind kind, Func<DbDataReader, T> getValue, T expected) => DoTest(dbType, kind, reader => Assert.Equal(expected, getValue(reader)));
	protected virtual async Task TestGetValueAsync<T>(DbType dbType, ValueKind kind, Func<DbDataReader, Task<T>> getValue, T expected) => await DoTestAsync(dbType, kind, async reader => Assert.Equal(expected, await getValue(reader)));

	protected virtual void TestException<T>(DbType dbType, ValueKind kind, Func<DbDataReader, T> getValue, Type exceptionType) =>
		DoTest(dbType, kind, reader =>
		{
			try
			{
				var value = getValue(reader);
				throw new UnexpectedValueException(value);
			}
			catch (UnexpectedValueException)
			{
				throw;
			}
			catch (Exception ex) when (ex.GetType() == exceptionType)
			{
			}
			catch (Exception ex)
			{
				throw new ThrowsException(exceptionType, ex);
			}
		});


	protected virtual async Task TestExceptionAsync<T>(DbType dbType, ValueKind kind, Func<DbDataReader, Task<T>> getValue, Type exceptionType) =>
		await DoTestAsync(dbType, kind, async reader =>
		{
			try
			{
				var value = await getValue(reader);
				throw new UnexpectedValueException(value);
			}
			catch (UnexpectedValueException)
			{
				throw;
			}
			catch (Exception ex) when (ex.GetType() == exceptionType)
			{
			}
			catch (Exception ex)
			{
				throw new ThrowsException(exceptionType, ex);
			}
		});

	protected virtual void DoTest(DbType dbType, ValueKind kind, Action<DbDataReader> action)
	{
		if (!Fixture.SupportedDbTypes.Contains(dbType))
			throw new Xunit.SkipException("Database doesn't support this data type");

		using var connection = CreateOpenConnection();
		using var command = connection.CreateCommand();
		command.CommandText = Fixture.CreateSelectSql(dbType, kind);
		using var reader = command.ExecuteReader();
		Assert.True(reader.Read());
		action(reader);
	}

	protected virtual async Task DoTestAsync(DbType dbType, ValueKind kind, Func<DbDataReader, Task> action)
	{
		if (!Fixture.SupportedDbTypes.Contains(dbType))
			throw new Xunit.SkipException("Database doesn't support this data type");

		using var connection = CreateOpenConnection();
		using var command = connection.CreateCommand();
		command.CommandText = Fixture.CreateSelectSql(dbType, kind);
		using var reader = command.ExecuteReader();
		Assert.True(reader.Read());
		await action(reader);
	}
}
