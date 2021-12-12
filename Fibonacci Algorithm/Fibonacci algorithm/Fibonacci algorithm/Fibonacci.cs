using System;
using System.Collections.Generic;
using System.Text;

namespace Fibonacci_algorithm
{
    public class FibonacciAlgorithm
    {
		public void Fibonacci(int number)
		{
			int n = 1;
			int m = 0;
			for (int i = 0; i < number; i++)
			{
				n += m;
				m = n - m;

				Console.WriteLine(m);
			}

		}
	}
}
