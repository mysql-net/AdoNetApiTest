using AdoNet.Specification.Tests;

namespace DotConnectMySql.Tests;

public sealed class DotConnectMySqlParameterTests : ParameterTestBase<DotConnectMySqlDbFactoryFixture>
{
	public DotConnectMySqlParameterTests(DotConnectMySqlDbFactoryFixture fixture)
		: base(fixture)
	{
	}
}
