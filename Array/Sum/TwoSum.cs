using System.Collections.Generic;

namespace DSAAdvance.Array.Sum
{
    // LeetCode #1 - Two Sum
    // Given nums[] and target, return indices of two numbers that add up to target.
    public class TwoSum
    {
        // HashMap approach - Time O(n), Space O(n)
        public int[] Solve(int[] nums, int target)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                map[nums[i]] = i;
            }
            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];
                if (map.ContainsKey(complement) && map[complement] != i)
                {
                    return new int[] { i, map[complement] };
                }
            }
            return new int[] { };
        }

        // Brute Force approach - Time O(n^2), Space O(1)
        public List<int> SolveBrute(List<int> nums, int target)
        {
            List<int> lst = new List<int>();
            for (int i = 0; i < nums.Count; i++)
            {
                int complement = target - nums[i];
                for (int j = i + 1; j < nums.Count; j++)
                {
                    if (nums[j] == complement)
                    {
                        lst.Add(i);
                        lst.Add(j);
                        return lst;
                    }
                }
            }
            return lst;
        }
    }
}
