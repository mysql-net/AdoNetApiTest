# Version History

## 2.0.0 Alpha 4

* **Breaking** Add `ISelectValueFixture.NullValueExceptionType`.
* Add more cancellation tests: [#14](https://github.com/mysql-net/AdoNetApiTest/pull/14).
* Add `GetTextReader` tests.

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
