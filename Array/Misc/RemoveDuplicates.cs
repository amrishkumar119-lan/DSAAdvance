using System.Collections.Generic;

namespace DSAAdvance.Array.Misc
{
    // LeetCode #26 - Remove Duplicates from Sorted Array
    // Remove duplicates in-place, return new length.
    public class RemoveDuplicates
    {
        // List version - Time O(n^2) due to list.Remove. Use two-pointer for O(n).
        public int Solve(List<int> nums)
        {
            for (int i = 0; i < nums.Count - 1; i++)
            {
                if (nums[i] == nums[i + 1])
                {
                    nums.Remove(nums[i]);
                    i--;
                }
            }
            return nums.Count;
        }
    }
}
