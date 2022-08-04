using System;
using System.Data;
using System.Data.Common;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Xunit;
using Xunit.Sdk;

namespace AdoNet.Specification.Tests
{
	public abstract class DbProviderFactoryTestBase<TFixture> : DbFactoryTestBase<TFixture>
		where TFixture : class, IDbFactoryFixture
	{
		protected DbProviderFactoryTestBase(TFixture fixture)
			: base(fixture)
		{
		}

		[Fact]
		public virtual void DbProviderFactory_CreateCommand_is_not_null() => Assert.NotNull(Fixture.Factory.CreateCommand());

		[Fact]
		public virtual void DbProviderFactory_CreateCommandBuilder_is_not_null() => Assert.NotNull(Fixture.Factory.CreateCommandBuilder());

		[Fact]
		public virtual void DbProviderFactory_CreateConnection_is_not_null() => Assert.NotNull(Fixture.Factory.CreateConnection());

		[Fact]
		public virtual void DbProviderFactory_CreateConnectionStringBuilder_is_not_null() => Assert.NotNull(Fixture.Factory.CreateConnectionStringBuilder());

		[Fact]
		public virtual void DbProviderFactory_CreateDataAdapter_is_not_null() => Assert.NotNull(Fixture.Factory.CreateDataAdapter());

		[Fact]
		public virtual void DbProviderFactory_CreateDataSourceEnumerator_is_null() => Assert.Null(Fixture.Factory.CreateDataSourceEnumerator());

		[Fact]
		public virtual void DbProviderFactory_CreateParameter_is_not_null() => Assert.NotNull(Fixture.Factory.CreateParameter());

		[Fact]
		public virtual void DbProviderFactory_CanCreateDataSourceEnumerator_is_false() => Assert.False(Fixture.Factory.CanCreateDataSourceEnumerator);

		[Fact]
		public virtual void DbProviderFactory_CanCreateDataSourceEnumerator_is_accurate() => Assert.Equal(Fixture.Factory.CanCreateDataSourceEnumerator, Fixture.Factory.CreateDataSourceEnumerator() is object);

#if NETSTANDARD2_0
		[SkippableFact]
		public virtual void DbProviderFactory_CanCreateCommandBuilder_is_true() => throw new Xunit.SkipException("Not supported on this TargetFramework");

		[SkippableFact]
		public virtual void DbProviderFactory_CanCreateDataAdapter_is_true() => throw new Xunit.SkipException("Not supported on this TargetFramework");
#else
		[Fact]
		public virtual void DbProviderFactory_CanCreateCommandBuilder_is_true() => Assert.True(Fixture.Factory.CanCreateCommandBuilder);

		[Fact]
		public virtual void DbProviderFactory_CanCreateDataAdapter_is_true() => Assert.True(Fixture.Factory.CanCreateDataAdapter);
#endif
	}
}
