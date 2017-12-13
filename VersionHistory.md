# Version History

## 2.0.0 Alpha 1

* **Breaking** Removed `AdoNet.Specification.Tests.Database` namespace, `DatabaseBase` class and derived classes
* **Breaking** Removed some `virtual` tests from `CommandTestBase`, `DataReaderTestBase`
* **Breaking** Changed `DataReaderTestBase` to require `ISelectValueFixture`
* Add `ISelectValueFixture` interface
* Remove methods from `IDbFactoryFixture` (they have moved to `ISelectValueFixture`)
* Add `GetValueConversionTestBase` test class

## 1.0.0

* Initial release
