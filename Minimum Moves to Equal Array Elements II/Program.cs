using System;

namespace Minimum_Moves_to_Equal_Array_Elements_II
{
    // https://leetcode.com/problems/minimum-moves-to-equal-array-elements-ii/

    /* Solution described here
     * here is the straightforward proof for this problem
        lets start with two points:
        a--------------------------------b
        the smallest moves is any point between a and b, and the number of moves is b-a
        if we addd another two points
        a--------c----------d------------b
        what's the minimum moves to make sure c and d make the smallest number of moves?
        it the same logic as a and b, which is ANY point between c and d.
        if eventually their value is between a and c or b and d, we can only make sure a c move the least, but not for c d
        so, just define two pointers and calculate the distance for each pair, add to result.
     * 
     */

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
