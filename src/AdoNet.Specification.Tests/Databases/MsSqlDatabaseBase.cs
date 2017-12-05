using System;

namespace AdoNet.Specification.Tests.Databases
{
	public class MsSqlDatabaseBase : DatabaseBase
	{
		public override string CreateHexLiteral(byte[] value) => $"0x{BitConverter.ToString(value).Replace("-", "")}";
	}
}
