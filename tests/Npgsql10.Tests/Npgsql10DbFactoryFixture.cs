namespace Npgsql10.Tests;

public class Npgsql10DbFactoryFixture : IDbFactoryFixture
{
	public DbProviderFactory Factory => NpgsqlFactory.Instance;
	public string ConnectionString => "host=localhost;user id=root;password=test;database=npgsql10";
}
