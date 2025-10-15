using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment1
{
    class Anagram
    {
        static bool IsAnagram(string s1, string s2)
        {
            s1 = new string(s1.ToLower().OrderBy(c => c).ToArray());
            s2 = new string(s2.ToLower().OrderBy(c => c).ToArray());
            return s1 == s2;
        }

        static void Main()
        {
            Console.WriteLine("Enter first string:");
            string s1 = Console.ReadLine();
            Console.WriteLine("Enter second string:");
            string s2 = Console.ReadLine();

            Console.WriteLine(IsAnagram(s1, s2) ? "Anagram" : "Not Anagram");
            Console.WriteLine("Press any key to exit...");
            Console.ReadLine();
        }
    }
}
