using System.Collections.Generic;

namespace DSAAdvance.Array.Sum
{
    // LeetCode #18 - 4Sum
    // Find all unique quadruplets [a, b, c, d] such that a + b + c + d = target.
    public class FourSum
    {
        // Sort + Two Pointers - Time O(n^3), Space O(1) (excluding output)
        public IList<IList<int>> Solve(int[] nums, int target)
        {
            List<IList<int>> lst = new List<IList<int>>();
            //Array.Sort(nums); // input is expected to be sorted before calling
            for (int i = 0; i < nums.Length; i++)
            {
                if (i > 0 && nums[i] == nums[i - 1]) continue;
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (j > i + 1 && nums[j] == nums[j - 1]) continue;
                    int mid = j + 1, high = nums.Length - 1;
                    while (mid < high)
                    {
                        long sum = nums[i] + nums[j] + nums[mid] + nums[high];
                        if (sum == target)
                        {
                            lst.Add(new List<int>() { nums[i], nums[j], nums[mid], nums[high] });
                            mid++; high--;
                            while (mid < high && nums[mid] == nums[mid - 1]) mid++;
                            while (mid < high && nums[high] == nums[high + 1]) high--;
                        }
                        else if (sum > target)
                        {
                            high--;
                        }
                        else
                        {
                            mid++;
                        }
                    }
                }
            }
            return lst;
        }

        // --- Earlier attempt using HashSet to dedupe (O(n^3) but extra work) ---
        //public IList<IList<int>> Solve(int[] nums, int target)
        //{
        //    HashSet<string> set = new HashSet<string>();
        //    int length = nums.Length - 1;
        //    List<IList<int>> lst = new List<IList<int>>();
        //    for (int i = 0; i <= length - 2; i++)
        //    {
        //        if (i > 0 && nums[i] == nums[i + 1]) continue;
        //        for (int j = i + 1; j <= length - 1; j++)
        //        {
        //            if (j > i + 1 && nums[j] == nums[j + 1]) continue;
        //            int left = j + 1, right = nums.Length - 1;
        //            while (right >= left)
        //            {
        //                if (nums[i] + nums[j] + nums[left] == 0)
        //                {
        //                    List<int> ad = new List<int>() { nums[i], nums[j], nums[left] };
        //                    set.Add(string.Join(",", ad));
        //                    left++; right--;
        //                    while (right > left && nums[left] == nums[left - 1]) left++;
        //                    while (left < right && nums[right] == nums[right + 1]) right--;
        //                }
        //                else { left++; right--; }
        //            }
        //        }
        //    }
        //    foreach (string trl in set)
        //    {
        //        lst.Add(trl.Split(',').Select(int.Parse).ToList());
        //    }
        //    return lst;
        //}
    }
}
