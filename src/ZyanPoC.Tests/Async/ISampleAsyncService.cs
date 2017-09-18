﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ZyanPoC.Tests.Async
{
	public interface ISampleAsyncService
	{
		Task PerformShortOperation();

		Task PerformLongOperation();

		Task<int> Add(int a, int b);

		Task<string> Concatenate(params string[] strings);

		Task<DateTime> Construct(int y, int m, int d);

		Task<DateTimeOffset> Now { get; }
	}
}