using System;

namespace AdoNet.Specification.Tests.Databases
{
	public class MySqlDatabaseBase : DatabaseBase
	{
		// docker run --name mysql -e MYSQL_ROOT_PASSWORD=test -p 3306:3306 -d mysql:5.7
		public override string ConnectionString => "Server=localhost;User Id=root;Password=test;";
		public override string CreateHexLiteral(byte[] value) => $"X'{BitConverter.ToString(value).Replace("-", "")}'";
	}
}
