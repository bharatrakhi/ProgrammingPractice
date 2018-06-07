using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            int Result = FibbonancciSeriesUsingTabulation(100);

            Console.WriteLine("Fibonacci Series " + Result);
            Console.Read();
        }

        private static int FibbonancciSeriesUsingTabulation(int n)
        {
            if (n <= 0)
                return 0;

            int[] Result = new int[n+1];

            Result[0] = 0;
            Result[1] = 1;

            for (int i = 2; i <= n; i++)
                Result[i] = Result[i - 1] + Result[i - 2];
            return Result[n];
        }
    }
}
