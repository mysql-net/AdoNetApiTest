using System;
using System.Data.Common;

namespace AdoNet.Specification.Tests
{
	/// <summary>
	/// <see cref="UnexpectedValueException"/> is thrown when <see cref="DbDataReader.GetValue"/> succeeds
	/// but it was expected to throw an exception.
	/// </summary>
	public class UnexpectedValueException : Exception
	{
		public UnexpectedValueException(object value)
			: base(value == null ? "Unexpected value: (null)" : $"Unexpected value: {value} ({value.GetType()})")
		{
		}
	}
}
