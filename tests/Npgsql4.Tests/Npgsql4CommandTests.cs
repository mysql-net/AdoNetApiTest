using System;
using AdoNet.Specification.Tests;
using Npgsql;
using Xunit;

namespace Npgsql4.Tests;

public sealed class Npgsql4CommandTests : CommandTestBase<Npgsql4DbFactoryFixture>
{
	public Npgsql4CommandTests(Npgsql4DbFactoryFixture fixture)
		: base(fixture)
	{
	}

	[Fact]
	public override void Connection_throws_when_set_when_open_reader()
	{
		using var connection = CreateOpenConnection();
		using var command = (NpgsqlCommand) connection.CreateCommand();
		command.CommandText = "SELECT 1;";

		using var reader = command.ExecuteReader();

		Assert.Throws<InvalidOperationException>(() => command.Connection = (NpgsqlConnection) CreateConnection());
	}

	[Fact]
	public override void Connection_throws_when_set_to_null_when_open_reader()
	{
		using var connection = CreateOpenConnection();
		using var command = (NpgsqlCommand) connection.CreateCommand();
		command.CommandText = "SELECT 1;";

		using var reader = command.ExecuteReader();

		Assert.Throws<InvalidOperationException>(() => command.Connection = null);
	}
}
