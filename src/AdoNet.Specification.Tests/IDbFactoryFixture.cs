using System.Data.Common;

namespace AdoNet.Specification.Tests;

public interface IDbFactoryFixture
{
	DbProviderFactory Factory { get; }
	string ConnectionString { get; }
}
