# ADO.NET Specification Tests

This library provides a suit of [xUnit.net](https://xunit.github.io/)-based tests for ADO.NET providers, i.e.,
classes that inherit from `DbConnection`, `DbCommand`, `DbDataReader`, etc.

It intends to clarify ambiguous areas in the ADO.NET documenation and help ensure that various providers act
consistently (when the behaviour doesn't depend on the specific target database server).

## How to Use

Add a reference to the [NuGet package](https://www.nuget.org/packages/AdoNet.Specification.Tests) to your test project.

Create a class that implements `IDbFactoryFixture`. In most cases, the easiest way to do this
is to inherit from ` DbFactoryFixtureBase<TDatabase>` where `TDatabase` is one of the built-in
classes from the `AdoNet.Specification.Tests.Databases` namespace. Then implement the
`Factory` property, which returns a `DbProviderFactory` for your ADO.NET implementation. See
[this example](https://github.com/mysql-net/AdoNetApiTest/blob/master/tests/SqlClient.Tests/SqlClientDbFactoryFixture.cs) for
`System.Data.SqlClient`.

Create one public derived class from each `XTestBase<T>` test base class. Add a public
constructor that takes an instance of your `IDbFactoryFixture` implementation and passes it
to the base class.

As necessary, override failing test methods to customize/skip them for your provider.

## License

[MIT](LICENSE)
