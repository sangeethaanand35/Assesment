using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciSeries
{
    internal class Program
    {
        public static int[] Fibonacci(int n)
        {
            if (n <= 0)
            {
                return new int[0];
            }
            if (n == 1)
            {
                return new int[2] { 0,1 };
            }
            int[] fib = new int[n];
            fib[0] = 0; fib[1] = 1;
            for(int i = 2; i < n; i++)
            {
                fib[i]= fib[i - 1] + fib[i-2];
            }
            return fib;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter number");
            int n = int.Parse(Console.ReadLine());
            int[] result = Fibonacci(n);
            Console.WriteLine(string.Join(",",result));
            Console.ReadLine();
        }
    }
}
