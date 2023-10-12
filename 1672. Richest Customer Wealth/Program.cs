using System;
using System.Diagnostics.CodeAnalysis;

namespace MyApp // Note: actual namespace depends on the project name.
{
    public class Solution
    {
        int max = 0;
        public int MaximumWealth(int[][] accounts)
        {
            foreach(int[] account in accounts)
            {
                if(account.Sum() > max)
                {
                    max = account.Sum();
                }
            }
            return max;
        }
    }
    internal class Program
    {
        static void Main()
        {
            int[][] a = new int[][]{ 
                                    new int[] {1, 2, 3}, 
                                    new int[] {3, 2, 1} 
                                };
            Solution s = new Solution();
            Console.WriteLine("{0}",s.MaximumWealth(a));
        }
    }
}