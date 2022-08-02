# Version History

## 2.0.0 Alpha 9

* Add many new test methods, including hundreds for `GetFieldValueAsync`.
* Update Xunit to 2.4.2.
* Remove dependency on Xunit.SkippableFact.

## 2.0.0 Alpha 8

* Add `DbProviderFactoryTestBase`.
* Test that `GetSchemaTable` returns `null`.

## 2.0.0 Alpha 7

* Add nullability tests.
* Add connection string tests.
* Add `CommandBehavior` tests.
* **Breaking** Move tests to new `TransactionTestBase` class.
* Thanks to [Shay Rojansky](https://github.com/roji) for contributions to this release.

## 2.0.0 Alpha 6

* Add `DataReaderTestBase.GetValues_throws_for_null`.
* For each `DataReader.GetX` test, add a parallel `GetFieldValue<x>` test for the return type.
  * For example, added tests of `GetFieldValue<byte>` alongside `GetByte` and `GetFieldValue<short>` alongside `GetInt16`.

## 2.0.0 Alpha 5

* Add conversion tests:
  * `GetDecimal` for float and double columns (should fail)
  * `GetDouble` for decimal columns (should pass)
  * `GetFloat` for decimal columns (should pass)

## 2.0.0 Alpha 4

* **Breaking** Add `ISelectValueFixture.NullValueExceptionType`.
* Add more cancellation tests: [#14](https://github.com/mysql-net/AdoNetApiTest/pull/14).
* Add `GetTextReader` tests.
* Add tests for `DbParameter` and `DbParameterCollection`.
* Test `GetString` for numeric columns (should fail).
* Test `GetFieldValue<TextReader>`.
* Test `DbDataReader` methods after executing a `DELETE` statement: [#28](https://github.com/mysql-net/AdoNetApiTest/issues/28).
* Test `DbDataReader.Read` continues returning `false`: [#24](https://github.com/mysql-net/AdoNetApiTest/issues/24).
* Test `DbDataReader.GetValues` with null argument.

## 2.0.0 Alpha 3

* Test `DbCommand.Cancel`.
* Check lowercase column name in `GetName`: [#12](https://github.com/mysql-net/AdoNetApiTest/pull/12).

## 2.0.0 Alpha 2

* Add `GetChar`, `Commit_transaction`, `Rollback_transaction` tests; see [API diff](https://www.fuget.org/packages/AdoNet.Specification.Tests/2.0.0-alpha2/lib/netstandard2.0/diff/2.0.0-alpha1/)
* Update to xUnit.net 2.4.1

## 2.0.0 Alpha 1

* **Breaking** Removed `AdoNet.Specification.Tests.Database` namespace, `DatabaseBase` class and derived classes
* **Breaking** Removed some `virtual` tests from `CommandTestBase`, `DataReaderTestBase`
* **Breaking** Changed `DataReaderTestBase` to require `ISelectValueFixture`
* Add `ISelectValueFixture` interface
* Remove methods from `IDbFactoryFixture` (they have moved to `ISelectValueFixture`)
* Add `GetValueConversionTestBase` test class
* Add `ParameterTestBase` test class

## 1.0.0

* Initial release
