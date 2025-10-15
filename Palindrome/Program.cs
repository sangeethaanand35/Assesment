using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    using System;
    using System.Linq;

    class Program
    {
        public static string IsPalindrome(string input)
        {
            string cleaned = new string(input
                .Where(char.IsLetterOrDigit)
                .Select(char.ToLower)
                .ToArray());

            int left = 0, right = cleaned.Length - 1;
            while (left < right)
            {
                if (cleaned[left] != cleaned[right])
                    return "No, it's not a palindrome";
                left++;
                right--;
            }

            return "Yes, it's a palindrome";
        }

        static void Main()
        {
            Console.WriteLine("Enter the string to check palindrome");
            string str1 = Console.ReadLine();
            string result = IsPalindrome(str1);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
    

