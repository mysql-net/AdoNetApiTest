using System;
using System.Linq;

namespace AdoNet.Specification.Tests.Databases
{
	public class PostgresDatabaseBase : DatabaseBase
	{
		// docker run --name postgres -e POSTGRES_USER=root -e POSTGRES_PASSWORD=test -p 5432:5432 -d postgres
		public override string ConnectionString => "host=localhost;user id=root;password=test;";
		public override string CreateHexLiteral(byte[] value) => $@"E'{string.Join("", value.Select(x => @"\x" + x.ToString("X2")))}'::bytea";
	}
}
