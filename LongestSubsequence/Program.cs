using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestSubsequence
{


    class Program
    {
        static int LongestCommonSubsequence(string A, string B)
        {
            int m = A.Length, n = B.Length;
            int[,] dp = new int[m + 1, n + 1];

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (A[i] == B[j])
                        dp[i + 1, j + 1] = dp[i, j] + 1;
                    else
                        dp[i + 1, j + 1] = Math.Max(dp[i + 1, j], dp[i, j + 1]);
                }
            }

            return dp[m, n];
        }

        static void Main()
        {
            string A = "abbcdgf";
            string B = "bbadcgf";
            Console.WriteLine(LongestCommonSubsequence(A, B));
            Console.ReadLine();
        }
    }
}

