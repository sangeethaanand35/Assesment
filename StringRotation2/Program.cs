using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringRotation2
{
    internal class Program
    {
      public static string   IsstringRotated(string str1,string str2)
        {
            if (str1.Length != str2.Length)
            {
                return "two strings are different in length";
            }
         
            char[] rotatedstring= str2.ToArray();
            Array.Reverse(rotatedstring);
            string rotatedstring1 = new string(rotatedstring);
            if (rotatedstring1 == str1)
            {
                return "string 1 is rotated version of string 2";
            }
            else
                return "No..two strings are different";
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first string");
           string s1= Console.ReadLine();
            Console.WriteLine("Enter second string");
            string s2 = Console.ReadLine();
            string result = IsstringRotated(s1, s2);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
