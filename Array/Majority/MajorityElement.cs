using System.Collections.Generic;

namespace DSAAdvance.Array.Majority
{
    // LeetCode #169 - Majority Element
    // Find the element that appears more than n/2 times. Boyer-Moore Voting Algorithm.
    // Time O(n), Space O(1).
    public class MajorityElement
    {
        public int Solve(List<int> nums)
        {
            int count = 0, element = 0;
            for (int i = 0; i < nums.Count; i++)
            {
                if (count == 0)
                {
                    count++;
                    element = nums[i];
                }
                if (element == nums[i])
                {
                    count++;
                }
                else
                {
                    count--;
                }
            }
            return element;
        }
    }
}
