using System.Data.Common;

namespace AdoNet.Specification.Tests.Databases
{
	public abstract class DbFactoryFixtureBase<TDatabase> : IDbFactoryFixture
		where TDatabase : DatabaseBase, new()
	{
		protected DbFactoryFixtureBase()
		{
			Database = new TDatabase();
		}

		public abstract DbProviderFactory Factory { get; }
		public virtual string ConnectionString => Database.ConnectionString;
		public virtual string CreateHexLiteral(byte[] value) => Database.CreateHexLiteral(value);

		protected TDatabase Database { get; set; }
	}
}
