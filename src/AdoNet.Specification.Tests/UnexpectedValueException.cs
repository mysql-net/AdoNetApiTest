using System;
using System.Data.Common;
using System.Linq;

namespace AdoNet.Specification.Tests
{
	/// <summary>
	/// <see cref="UnexpectedValueException"/> is thrown when <see cref="DbDataReader.GetValue"/> succeeds
	/// but it was expected to throw an exception.
	/// </summary>
	public class UnexpectedValueException : Exception
	{
		public UnexpectedValueException(object value)
			: base(value == null ? "Unexpected value: (null)" : $"Unexpected value: {ToString(value)} ({value.GetType()})")
		{
		}

		private static string ToString(object value)
		{
			if (value is byte[] byteArray)
				return string.Join(" ", byteArray.Take(10).Select(x => x.ToString("X2"))) + (byteArray.Length > 10 ? "..." : "");
			return value.ToString();
		}
	}
}
