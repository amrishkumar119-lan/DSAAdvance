using System;
using System.Collections.Generic;

namespace DSAAdvance.BinarySearch.OnAnswer
{
    // LeetCode #1482 - Minimum Number of Days to Make m Bouquets
    // Make m bouquets, each requiring k adjacent flowers. Return min days.
    // Binary search on the answer (day count).
    public class RoseGarden
    {
        public int Solve(List<int> nums, int k, int m)
        {
            int low = int.MaxValue, high = int.MinValue;
            int ans = -1;
            for (int i = 0; i < nums.Count; i++)
            {
                low = Math.Min(low, nums[i]);
                high = Math.Max(high, nums[i]);
            }
            while (low <= high)
            {
                int mid = (high + low) / 2;
                if (CanMake(nums, mid, k, m))
                {
                    ans = mid;
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }
            }
            return ans;
        }

        // Helper: can we make m bouquets of k adjacent flowers by 'day'?
        private bool CanMake(List<int> nums, int day, int k, int m)
        {
            int count = 0, possible = 0;
            for (int i = 0; i < nums.Count; i++)
            {
                if (nums[i] <= day)
                {
                    count++;
                }
                else
                {
                    possible += count / k;
                    count = 0;
                }
            }
            possible += count / k;
            return possible >= m;
        }
    }
}
