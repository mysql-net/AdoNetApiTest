using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;
using Xunit.Sdk;

// Copied from:
// https://github.com/xunit/samples.xunit/tree/master/DynamicSkipExample

namespace AdoNet.Specification.Tests
{
	[XunitTestCaseDiscoverer("AdoNet.Specification.Tests.SkippableFactDiscoverer", "AdoNet.Specification.Tests")]
	public class SkippableFactAttribute : FactAttribute
	{
	}

	public class SkipTestException : Exception
	{
		public SkipTestException(string reason)
			: base(reason) { }
	}

	public class SkippableFactDiscoverer : IXunitTestCaseDiscoverer
	{
		readonly IMessageSink diagnosticMessageSink;

		public SkippableFactDiscoverer(IMessageSink diagnosticMessageSink)
		{
			this.diagnosticMessageSink = diagnosticMessageSink;
		}

		public IEnumerable<IXunitTestCase> Discover(ITestFrameworkDiscoveryOptions discoveryOptions, ITestMethod testMethod, IAttributeInfo factAttribute)
		{
			yield return new SkippableFactTestCase(diagnosticMessageSink, discoveryOptions.MethodDisplayOrDefault(), testMethod);
		}
	}

	public class SkippableFactMessageBus : IMessageBus
	{
		readonly IMessageBus innerBus;

		public SkippableFactMessageBus(IMessageBus innerBus)
		{
			this.innerBus = innerBus;
		}

		public int DynamicallySkippedTestCount { get; private set; }

		public void Dispose() { }

		public bool QueueMessage(IMessageSinkMessage message)
		{
			var testFailed = message as ITestFailed;
			if (testFailed != null)
			{
				var exceptionType = testFailed.ExceptionTypes.FirstOrDefault();
				if (exceptionType == typeof(SkipTestException).FullName)
				{
					DynamicallySkippedTestCount++;
					return innerBus.QueueMessage(new TestSkipped(testFailed.Test, testFailed.Messages.FirstOrDefault()));
				}
			}

			// Nothing we care about, send it on its way
			return innerBus.QueueMessage(message);
		}
	}

	public class SkippableFactTestCase : XunitTestCase
	{
		[Obsolete("Called by the de-serializer; should only be called by deriving classes for de-serialization purposes")]
		public SkippableFactTestCase() { }

		public SkippableFactTestCase(IMessageSink diagnosticMessageSink, TestMethodDisplay defaultMethodDisplay, ITestMethod testMethod, object[] testMethodArguments = null)
			: base(diagnosticMessageSink, defaultMethodDisplay, testMethod, testMethodArguments) { }

		public override async Task<RunSummary> RunAsync(IMessageSink diagnosticMessageSink,
			IMessageBus messageBus,
			object[] constructorArguments,
			ExceptionAggregator aggregator,
			CancellationTokenSource cancellationTokenSource)
		{
			var skipMessageBus = new SkippableFactMessageBus(messageBus);
			var result = await base.RunAsync(diagnosticMessageSink, skipMessageBus, constructorArguments, aggregator, cancellationTokenSource);
			if (skipMessageBus.DynamicallySkippedTestCount > 0)
			{
				result.Failed -= skipMessageBus.DynamicallySkippedTestCount;
				result.Skipped += skipMessageBus.DynamicallySkippedTestCount;
			}

			return result;
		}
	}
}
