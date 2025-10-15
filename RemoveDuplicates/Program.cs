using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveDuplicates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr= { 1, 2,2, 3, 4, 5,5, 6, 7, 8,8, 9 };
            int[] removedDuplicated=arr.Distinct().ToArray();
            Console.WriteLine(string.Join(",",removedDuplicated));
            Console.ReadLine();
        }
    }
}
