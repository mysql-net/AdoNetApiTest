using System;

namespace AdoNet.Specification.Tests.Databases
{
	public class SqliteDatabaseBase : DatabaseBase
	{
		public override string CreateHexLiteral(byte[] value) => $"X'{BitConverter.ToString(value).Replace("-", "")}'";
	}
}
