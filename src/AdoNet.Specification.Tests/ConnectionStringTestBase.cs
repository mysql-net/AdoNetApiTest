using System;
using Xunit;

namespace AdoNet.Specification.Tests
{
	public class ConnectionStringTestBase<TFixture> : DbFactoryTestBase<TFixture>
		where TFixture : class, IDbFactoryFixture
	{
		public ConnectionStringTestBase(TFixture fixture)
			: base(fixture)
		{
			Fixture = fixture;
		}

		protected new TFixture Fixture { get; }

		[Fact]
		public void ConnectionString_is_empty_by_default()
		{
			var builder = CreateConnectionStringBuilder();
			Assert.Equal(string.Empty, builder.ConnectionString);
		}

		[Fact]
		public virtual void ConnectionString_can_set_null_but_returns_empty()
		{
			var builder = CreateConnectionStringBuilder();
			builder.ConnectionString = null;
			Assert.Empty(builder.ConnectionString);
		}
	}
}
