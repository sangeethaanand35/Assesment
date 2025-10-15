using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdjacentDuplicates
{
    internal class Program
    {
        static string IsAdjacentDuplicate(string s)
        {
            Stack<char> stack = new Stack<char>();
            foreach(char c in s)
            {
                if(stack.Count > 0 && stack.Peek() == c)
                {
                    stack.Pop();
                }
                else
                {
                    stack.Push(c);
                }
             
            }
            char[] result = stack.ToArray();
            Array.Reverse(result);
            return new string(result);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string to remove adjacent deplicates");
            string s=Console.ReadLine();
            Console.WriteLine(IsAdjacentDuplicate(s));
            Console.ReadLine();
        }
    }
}
