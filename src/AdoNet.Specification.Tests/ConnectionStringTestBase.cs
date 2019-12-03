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
		public virtual void ConnectionString_set_to_null_is_empty_string()
		{
			var builder = CreateConnectionStringBuilder();
			builder.ConnectionString = null;
			Assert.Empty(builder.ConnectionString);
		}
	}
}
