using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;

namespace AdoNet.Specification.Tests
{
	/// <summary>
	/// Provides methods to SELECT values of specific types from a particular database server.
	/// </summary>
	public interface ISelectValueFixture : IDbFactoryFixture
	{
		/// <summary>
		/// Returns a collection of all <see cref="DbType"/> values that are supported by this database
		/// engine. A <see cref="DbType"/> enumeration value should only be included in this collection
		/// if it is the "best" match for a particular native column type.
		/// </summary>
		IReadOnlyCollection<DbType> SupportedDbTypes { get; }

		/// <summary>
		/// Returns a complete <c>SELECT</c> statement that returns a value of the specified
		/// type and kind.
		/// </summary>
		/// <param name="dbType">The data type of the value to return. This must be an entry in <see cref="SupportedDbTypes"/>.</param>
		/// <param name="kind">The kind of value; see the documentation on <see cref="ValueKind"/> for details.</param>
		string CreateSelectSql(DbType dbType, ValueKind kind);

		/// <summary>
		/// Returns a <c>SELECT</c> statement that returns the specified byte array.
		/// </summary>
		string CreateSelectSql(byte[] value);

		/// <summary>
		/// Returns a <c>SELECT</c> statement that selects no rows.
		/// </summary>
		string SelectNoRows { get; }

		/// <summary>
		/// Returns the <see cref="Type"/> of the exception that is thrown when <see cref="DbDataReader.GetValue"/> (and similar methods)
		/// are called for a field that is <c>NULL</c>, i.e., <see cref="DbDataReader.IsDBNull"/> return <c>true</c>. This is typically
		/// <see cref="InvalidCastException"/> but some providers may use a different exception type.
		/// </summary>
		/// <returns></returns>
		Type NullValueExceptionType { get; }
	}
}
