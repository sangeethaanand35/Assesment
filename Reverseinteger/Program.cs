using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverseinteger
{
    internal class Program
    {

        public static int Reverse(int x)
        {
            int result = 0;

                         while (x != 0)
                    {
                //x=523
                int digit = x % 10;//3
                x /= 10;//x=52

               

                result = result * 10 + digit;//3
            }

            return result;
        }

        static void Main(string[] args)
        {
            Console.Write("Enter a 32-bit signed integer: ");
            int number = int.Parse(Console.ReadLine());

            int reversed = Reverse(number);

            Console.WriteLine("Reversed number: " + reversed);
            Console.ReadLine();
        }
    }

  
    }

