## ADO.NET Specification Tests

This package provides base classes that let you test your ADO.NET library for conformance to common ADO.NET patterns.
ADO.NET doesn't have a formal specification for ADO.NET providers, but many libraries (such as
[Microsoft.Data.SqlClient](https://www.nuget.org/packages/Microsoft.Data.SqlClient),
[Npgsql](https://www.nuget.org/packages/Npgsql), and [MySqlConnector](https://www.nuget.org/packages/MySqlConnector))
exhibit similar behavior.

### Usage

Create a test project that uses [xunit](https://www.nuget.org/packages/xunit).

Write a class that implements `IDbFactoryFixture`:

```csharp
public class DbFactoryFixture : IDbFactoryFixture
{
	public DbFactoryFixture()
	{
		ConnectionString ="your test connection string";
	}

	public string ConnectionString { get; }
	public DbProviderFactory Factory => YourDbProviderFactory.Instance;
}
```

Then write test classes that inherit from the classes in this package, e.g.,

```csharp
public sealed class ConnectionTests : ConnectionTestBase<DbFactoryFixture>
{
	public ConnectionTests(DbFactoryFixture fixture)
		: base(fixture)
	{
	}

	[Fact(Skip = "Override a method and provide a 'Skip' reason to opt out of a test.")]
	public override void Set_ConnectionString_throws_when_invalid()
	{
	}
}
```
