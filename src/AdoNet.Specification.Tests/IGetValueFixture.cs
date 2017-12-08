using System.Collections.Generic;
using System.Data;

namespace AdoNet.Specification.Tests
{
	public interface IGetValueFixture : IDbFactoryFixture
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
	}
}
