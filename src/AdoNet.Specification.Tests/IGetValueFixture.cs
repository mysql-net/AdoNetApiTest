using System.Collections.Generic;
using System.Data;

namespace AdoNet.Specification.Tests
{
	public interface IGetValueFixture : IDbFactoryFixture
	{
		IReadOnlyCollection<DbType> SupportedDbTypes { get; }

		string CreateSelectSql(DbType dbType, ValueKind kind);
	}
}
