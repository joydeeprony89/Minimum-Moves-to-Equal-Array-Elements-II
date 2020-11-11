using System;

namespace Minimum_Moves_to_Equal_Array_Elements_II
{
    // https://leetcode.com/problems/minimum-moves-to-equal-array-elements-ii/


    class Program
    {
        static void Main(string[] args)
        {
            var nums = new int[] { 1, 2, 3 };
            Console.WriteLine(MinMoves2(nums));
        }

        static int MinMoves2(int[] nums)
        {
            Array.Sort(nums);
            int i = 0, j = nums.Length - 1;
            int minMove = 0;
            while (i < j)
            {
                minMove += nums[j--] - nums[i++];
            }
            return minMove;
        }
    }
}
