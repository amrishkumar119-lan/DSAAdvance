using System.Collections.Generic;
using System.Linq;

namespace DSAAdvance.Array.Sum
{
    // LeetCode #15 - 3Sum
    // Find all unique triplets [a, b, c] such that a + b + c = 0.
    public class ThreeSum
    {
        // Sort + Two Pointers - Time O(n^2), Space O(1) (excluding output)
        public IList<IList<int>> Solve(int[] nums)
        {
            System.Array.Sort(nums);
            IList<IList<int>> lst = new List<IList<int>>();
            for (int i = 0; i < nums.Count(); i++)
            {
                if (i > 0 && nums[i] == nums[i - 1]) continue;
                int mid = i + 1, last = nums.Count() - 1;
                while (mid <= last)
                {
                    int sum = nums[i] + nums[mid] + nums[last];
                    if (sum == 0)
                    {
                        lst.Add(new List<int>() { nums[i], nums[mid], nums[last] });
                        mid++; last--;
                        while (mid < last && nums[mid] == nums[mid - 1]) mid++;
                        while (mid < last && nums[last] == nums[last + 1]) last--;
                    }
                    else if (sum < 0)
                    {
                        mid++;
                    }
                    else
                    {
                        last--;
                    }
                }
            }
            return lst;
        }

        // --- Earlier brute force attempt (O(n^3) using HashSet for uniqueness) ---
        //public IList<IList<int>> Solve(int[] nums)
        //{
        //    HashSet<string> set = new HashSet<string>();
        //    for (int i = 0; i < nums.Length - 2; i++)
        //    {
        //        for (int j = i + 1; j < nums.Length - 1; j++)
        //        {
        //            for (int k = j + 1; k < nums.Length; k++)
        //            {
        //                if ((nums[i] + nums[j] + nums[k] == 0))
        //                {
        //                    List<int> temp = new List<int> { nums[i], nums[j], nums[k] };
        //                    set.Add(string.Join(",", temp));
        //                }
        //            }
        //        }
        //    }
        //    List<IList<int>> ans = new List<IList<int>>();
        //    foreach (string trl in set)
        //    {
        //        ans.Add(trl.Split(',').Select(int.Parse).ToList());
        //    }
        //    return ans;
        //}
    }
}
