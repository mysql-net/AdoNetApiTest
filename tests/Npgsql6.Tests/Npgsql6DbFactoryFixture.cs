namespace Npgsql6.Tests;

public class Npgsql6DbFactoryFixture : IDbFactoryFixture
{
	public DbProviderFactory Factory => NpgsqlFactory.Instance;
	public string ConnectionString => "host=localhost;user id=root;password=test;database=npgsql6";
}
