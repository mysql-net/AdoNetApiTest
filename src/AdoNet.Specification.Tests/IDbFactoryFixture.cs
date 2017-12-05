using System.Data.Common;

namespace AdoNet.Specification.Tests
{
	public interface IDbFactoryFixture
	{
		DbProviderFactory Factory { get; }
		string ConnectionString { get; }
		string CreateHexLiteral(byte[] value);
		string SelectNoRows { get; }
	}
}
