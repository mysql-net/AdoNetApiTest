namespace AdoNetApiTest
{
	public struct TestResult
	{
		public TestResult(TestStatus status, string message)
		{
			Status = status;
			Message = message;
		}

		public TestStatus Status { get; }
		public string Message { get; }
	}
}
