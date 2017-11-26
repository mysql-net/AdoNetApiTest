using System.Linq;

namespace AdoNet.Specification.Tests.Databases
{
	public class PostgresDatabaseBase : DatabaseBase
	{
		public override string CreateHexLiteral(byte[] value) => $@"E'{string.Join("", value.Select(x => @"\x" + x.ToString("X2")))}'::bytea";
	}
}
