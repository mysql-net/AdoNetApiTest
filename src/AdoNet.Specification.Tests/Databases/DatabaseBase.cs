using System;

namespace AdoNet.Specification.Tests.Databases
{
	public abstract class DatabaseBase
	{
		public abstract string CreateHexLiteral(byte[] value);
		public virtual string SelectNoRows => "SELECT 1 WHERE 0 = 1;";
	}
}
