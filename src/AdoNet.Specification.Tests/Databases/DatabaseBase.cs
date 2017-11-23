using System;

namespace AdoNet.Specification.Tests.Databases
{
	public abstract class DatabaseBase
	{
		public abstract string ConnectionString { get; }
		public abstract string CreateHexLiteral(byte[] value);
	}
}
