using System;

namespace AdoNetApiTest.Tests
{
	[AttributeUsage(AttributeTargets.Method)]
	public sealed class ImplementationSpecificAttribute : Attribute
	{
	}
}
