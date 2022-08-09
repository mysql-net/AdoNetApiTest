using System;
using System.Data;
using Xunit;

namespace AdoNet.Specification.Tests;

public class TransactionTestBase<TFixture> : DbFactoryTestBase<TFixture>
	where TFixture : class, IDbFactoryFixture
{
	public TransactionTestBase(TFixture fixture)
		: base(fixture)
	{
		Fixture = fixture;
	}

	protected new TFixture Fixture { get; }

	[Fact]
	public virtual void BeginTransaction_throws_when_closed()
	{
		using var connection = CreateConnection();
		Assert.Throws<InvalidOperationException>(() => connection.BeginTransaction());
	}

	[Fact]
	public virtual void BeginTransaction_throws_when_parallel_transaction()
	{
		using var connection = CreateOpenConnection();
		using (connection.BeginTransaction())
		{
			Assert.Throws<InvalidOperationException>(() => connection.BeginTransaction());
		}
	}

	[Fact]
	public virtual void BeginTransaction_works()
	{
		using var connection = CreateOpenConnection();
		using var transaction = connection.BeginTransaction(IsolationLevel.Serializable);
		Assert.NotNull(transaction);
		Assert.Same(connection, transaction.Connection);
		Assert.Equal(IsolationLevel.Serializable, transaction.IsolationLevel);
	}

	[Fact]
	public virtual void Commit_transaction_clears_Connection()
	{
		using var connection = CreateOpenConnection();
		using var transaction = connection.BeginTransaction(IsolationLevel.Serializable);
		Assert.Same(connection, transaction.Connection);
		transaction.Commit();
		Assert.Null(transaction.Connection);
	}

	[Fact]
	public virtual void Commit_transaction_throws_after_Dispose()
	{
		using var connection = CreateOpenConnection();
		var transaction = connection.BeginTransaction();
		transaction.Dispose();
		Assert.Throws<ObjectDisposedException>(() => transaction.Commit());
	}

	[Fact]
	public virtual void Commit_transaction_twice_throws()
	{
		using var connection = CreateOpenConnection();
		using var transaction = connection.BeginTransaction(IsolationLevel.Serializable);
		Assert.Same(connection, transaction.Connection);
		transaction.Commit();
		Assert.Throws<InvalidOperationException>(() => transaction.Commit());
	}

	[Fact]
	public virtual void Commit_transaction_then_Rollback_throws()
	{
		using var connection = CreateOpenConnection();
		using var transaction = connection.BeginTransaction(IsolationLevel.Serializable);
		Assert.Same(connection, transaction.Connection);
		transaction.Commit();
		Assert.Throws<InvalidOperationException>(() => transaction.Rollback());
	}

	[Fact]
	public virtual void Rollback_transaction_clears_Connection()
	{
		using var connection = CreateOpenConnection();
		using var transaction = connection.BeginTransaction(IsolationLevel.Serializable);
		Assert.Same(connection, transaction.Connection);
		transaction.Rollback();
		Assert.Null(transaction.Connection);
	}

	[Fact]
	public virtual void Rollback_transaction_throws_after_Dispose()
	{
		using var connection = CreateOpenConnection();
		var transaction = connection.BeginTransaction();
		transaction.Dispose();
		Assert.Throws<ObjectDisposedException>(() => transaction.Rollback());
	}

	[Fact]
	public virtual void Rollback_transaction_twice_throws()
	{
		using var connection = CreateOpenConnection();
		using var transaction = connection.BeginTransaction(IsolationLevel.Serializable);
		Assert.Same(connection, transaction.Connection);
		transaction.Rollback();
		Assert.Throws<InvalidOperationException>(() => transaction.Rollback());
	}

	[Fact]
	public virtual void Rollback_transaction_then_Commit_throws()
	{
		using var connection = CreateOpenConnection();
		using var transaction = connection.BeginTransaction(IsolationLevel.Serializable);
		Assert.Same(connection, transaction.Connection);
		transaction.Rollback();
		Assert.Throws<InvalidOperationException>(() => transaction.Commit());
	}
}
