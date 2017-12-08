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
		/// Returns a complete <code>SELECT </code> statement that returns a value of the specified
		/// type and kind.
		/// </summary>
		/// <param name="dbType">The data type of the value to return. This must be an entry in <see cref="SupportedDbTypes"/>.</param>
		/// <param name="kind">The kind of value; see the documentation on <see cref="ValueKind"/> for details.</param>
		string CreateSelectSql(DbType dbType, ValueKind kind);
	}
}
