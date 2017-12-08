using System.Data;
using System.Data.Common;

namespace AdoNet.Specification.Tests
{
	/// <summary>
	/// The "kind" of value that should be returned by <see cref="ISelectValueFixture.CreateSelectSql"/>.
	/// </summary>
	public enum ValueKind
	{
		/// <summary>
		/// The value is <c>NULL</c>. <see cref="DbDataReader.IsDBNull"/> would return <c>true</c>.
		/// </summary>
		Null,

		/// <summary>
		/// An "empty" value, such as a zero-length byte array or empty string. This is only meaningful for
		/// <see cref="DbType.Binary"/> and <see cref="DbType.String"/>.
		/// </summary>
		Empty,

		/// <summary>
		/// A "zero" value. For numeric types, this should be <c>0</c>. For <see cref="DbType.Binary"/>, <c>new byte[] { 0 }</c>.
		/// For <see cref="DbType.String"/>, <c>"0"</c>. For other DbType values, an object with all fields set to zeroes.
		/// </summary>
		Zero,

		/// <summary>
		/// A "one" value. For numeric types, this should be <c>1</c>. For <see cref="DbType.Binary"/>, <c>new byte[] { 1 }</c>.
		/// For <see cref="DbType.String"/>, <c>"1"</c>. For <see cref="DbType.DateTimeOffset"/>, <c>1111-11-11 11:11:11.111 +11:11</c>;
		/// other date/time values should use the corresponding part. For <see cref="DbType.Guid"/>, <c>{11111111-1111-1111-1111-111111111111}</c>.
		/// </summary>
		One,

		/// <summary>
		/// The minimum value. For numeric types, this should be <see cref="int.MinValue"/>, etc. For <see cref="DbType.Single"/>, <c>1.18e-38</c>.
		/// For <see cref="DbType.Double"/>, <c>2.23e-308</c>. For <see cref="DbType.Decimal"/>, <c>0.000000000000001</c>.
		/// For <see cref="DbType.DateTimeOffset"/>, <c>0001-01-01 00:00:00 +00.00</c>; other date/time values should use the corresponding part.
		/// </summary>
		Minimum,

		/// <summary>
		/// The minimum value. For numeric types, this should be <see cref="int.MaxValue"/>, etc. For <see cref="DbType.Single"/>, <c>3.40e38</c>.
		/// For <see cref="DbType.Double"/>, <c>1.79e308</c>. For <see cref="DbType.Decimal"/>, <c>99999999999999999999.999999999999999</c>.
		/// For <see cref="DbType.DateTimeOffset"/>, <c>9999-12-31 23:59:59.999 +14:00</c>; other date/time values should use the corresponding part.
		/// </summary>
		Maximum,
	}
}
