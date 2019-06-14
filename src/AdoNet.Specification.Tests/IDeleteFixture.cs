namespace AdoNet.Specification.Tests
{
	/// <summary>
	/// Provides methods to DELETE rows from a particular database server.
	/// </summary>
	public interface IDeleteFixture
	{
		/// <summary>
		/// Returns a <c>DELETE</c> statement that deletes no rows.
		/// </summary>
		string DeleteNoRows { get; }
	}
}
