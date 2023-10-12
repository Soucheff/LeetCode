using System;
using System.Diagnostics.CodeAnalysis;

namespace MyApp // Note: actual namespace depends on the project name.
{
    public class Solution {
       public int[] RunningSum(int[] nums) {
            for(int i=1; i<nums.Length; i++){
                nums[i]+=nums[i-1];
            }
            return nums;    
        }
    }
    internal class Program
    {
        static void Main()
        {
            int[] a = {1,2,3,4};
            Solution s = new Solution();
            Console.WriteLine("[{0}]",string.Join(",",s.RunningSum(a)));
        }
    }
}