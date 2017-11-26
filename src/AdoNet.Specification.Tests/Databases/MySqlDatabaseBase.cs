using System;

namespace AdoNet.Specification.Tests.Databases
{
	public class MySqlDatabaseBase : DatabaseBase
	{
		public override string CreateHexLiteral(byte[] value) => $"X'{BitConverter.ToString(value).Replace("-", "")}'";
		public override string SelectNoRows => "SELECT * FROM mysql.user WHERE 0 = 1;";
	}
}
