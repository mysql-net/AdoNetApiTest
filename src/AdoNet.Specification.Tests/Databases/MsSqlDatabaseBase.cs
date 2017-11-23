using System;

namespace AdoNet.Specification.Tests.Databases
{
	public class MsSqlDatabaseBase : DatabaseBase
	{
		// docker run --name mssql -e ACCEPT_EULA=Y -e MSSQL_SA_PASSWORD=Pa$$word -p 1433:1433 -d microsoft/mssql-server-linux:2017-latest
		public override string ConnectionString => "data source=localhost;user id=sa;password=Pa$$word";
		public override string CreateHexLiteral(byte[] value) => $"0x{BitConverter.ToString(value).Replace("-", "")}";
	}
}
