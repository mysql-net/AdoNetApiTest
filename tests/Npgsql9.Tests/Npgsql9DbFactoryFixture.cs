namespace Npgsql9.Tests;

public class Npgsql9DbFactoryFixture : IDbFactoryFixture
{
	public DbProviderFactory Factory => NpgsqlFactory.Instance;
	public string ConnectionString => "host=localhost;user id=root;password=test;database=npgsql9";
}
