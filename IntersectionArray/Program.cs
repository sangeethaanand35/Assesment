using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntersectionArray
{

    class arrayIntersection
    {
        static List<int> intersection(int[] a, int[] b)
        {
            List<int> res = new List<int>();

            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < b.Length; j++)
                {
                    if (a[i] == b[j])
                    {
                        res.Add(a[i]);
                        break;
                    }
                }
            }

            return res;
        }

        static void Main()
        {
            int[] a = { 5, 6, 2, 1, 4 };
            int[] b = { 7, 9, 4, 2 };

            List<int> res = intersection(a, b);

            foreach (int num in res)
            {
                Console.Write(num + " ");
            }
            Console.ReadLine();
        }
    }
}
