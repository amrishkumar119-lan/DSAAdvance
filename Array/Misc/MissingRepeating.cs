using System.Collections.Generic;

namespace DSAAdvance.Array.Misc
{
    // GFG - Find Missing and Repeating Numbers
    // Given an array of n integers in range [1..n] with one missing and one repeated.
    // Note: optimal is math (sum + sum of squares) or XOR for O(n) time, O(1) space.
    // This impl is O(n^2).
    public class MissingRepeating
    {
        public List<int> Solve(List<int> nums)
        {
            int n = nums.Count;
            int repeat = 0, missing = 0;
            for (int i = 1; i <= n; i++)
            {
                int count = 0;
                for (int j = 0; j < n; j++)
                {
                    if (i == nums[j]) count++;
                }
                if (count == 2) repeat = i;
                else if (count == 0) missing = i;
                if (repeat > 0 && missing > 0) break;
            }
            return new List<int>() { repeat, missing };
        }
    }
}
