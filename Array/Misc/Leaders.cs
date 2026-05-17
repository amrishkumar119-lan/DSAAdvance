using System.Collections.Generic;
using System.Linq;

namespace DSAAdvance.Array.Misc
{
    // GFG - Leaders in an Array
    // An element is a leader if it is greater than all elements to its right.
    // Approach: scan from right, keep track of running max. Time O(n).
    public class Leaders
    {
        public List<int> Solve(List<int> nums)
        {
            List<int> lst = new List<int>();
            int k = nums[nums.Count - 1];
            lst.Add(k);
            for (int i = nums.Count - 2; i >= 0; i--)
            {
                if (nums[i] > k)
                {
                    lst.Add(nums[i]);
                    k = nums[i];
                }
            }
            return lst.OrderByDescending(x => x).ToList();
        }
    }
}
