# ADO.NET Specification Tests

This library provides a suit of [xUnit.net](https://xunit.github.io/)-based tests for ADO.NET providers, i.e.,
classes that inherit from `DbConnection`, `DbCommand`, `DbDataReader`, etc.

It intends to clarify ambiguous areas in the ADO.NET documentation and help ensure that various providers act
consistently (when the behaviour doesn't depend on the specific target database server).

[![Build Status](https://dev.azure.com/mysqlnet/AdoNetApiTest/_apis/build/status/mysql-net.AdoNetApiTest?branchName=master)](https://dev.azure.com/mysqlnet/AdoNetApiTest/_build/latest?definitionId=1&branchName=master) [![Dependabot Status](https://api.dependabot.com/badges/status?host=github&repo=mysql-net/AdoNetApiTest)](https://dependabot.com)

## Current Results

The results from the latest build are [published here](https://mysql-net.github.io/AdoNetResults/).

## How to Use

Add a reference to the [NuGet package](https://www.nuget.org/packages/AdoNet.Specification.Tests) to your test project.

Create a class that implements `IDbFactoryFixture`: the
`Factory` property must return a `DbProviderFactory` for your ADO.NET implementation,
and the `ConnectionString` property must return a valid connection string that the test
suite can use to connect to a database. See
[this example](https://github.com/mysql-net/AdoNetApiTest/blob/master/tests/SqlClient.Tests/SqlClientDbFactoryFixture.cs) for
`System.Data.SqlClient`.

To use the tests that execute SQL statements, you must implement the `ISelectValueFixture`
interface. Examples of doing this can be found in the `tests/*` projects and `AdoNet.Databases`.

Create one public derived class from each `XTestBase<T>` test base class. Add a public
constructor that takes an instance of your `IDbFactoryFixture` implementation and passes it
to the base class.

As necessary, override failing test methods to customize/skip them for your provider.

## Version History

See [Version History](VersionHistory.md).

## How to Build a Comparison Chart

Clone this repo.

Run the required database servers locally:

```
cd docker
docker-compose up
```

Run the `AdoNetApiTest` program:

1. In Visual Studio 2017, set it as the Start Up Project and press `Ctrl+F5` to launch, or
2. From a command prompt: `dotnet run -p src\AdoNetApiTest\AdoNetApiTest.csproj`

Note that some DB providers require the full .NET Framework 4.7; this program has only been tested on Windows (not with mono).

The program will run all providers' test suites, then open the results in your default browser.

## License

[MIT](LICENSE)
