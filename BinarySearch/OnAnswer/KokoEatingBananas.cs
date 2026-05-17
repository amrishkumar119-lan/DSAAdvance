using System;
using System.Collections.Generic;
using System.Linq;

namespace DSAAdvance.BinarySearch.OnAnswer
{
    // LeetCode #875 - Koko Eating Bananas
    // Find min eating speed k such that Koko can finish all piles within h hours.
    // Binary search on the answer (speed).
    public class KokoEatingBananas
    {
        public int Solve(int[] piles, int h)
        {
            int low = 1, high = piles.Max();
            while (low <= high)
            {
                int mid = (high + low) / 2;
                long sum = 0;
                foreach (int num in piles)
                {
                    sum += (long)Math.Ceiling((double)num / mid);
                }
                if (sum <= h)
                {
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }
            }
            return low;
        }

        // List version - same algorithm
        public int SolveList(List<int> nums, int h)
        {
            int low = 1, high = FindMax(nums);
            while (low <= high)
            {
                int mid = (high + low) / 2;
                long sum = 0;
                foreach (int num in nums)
                {
                    sum += (long)Math.Ceiling((double)(num / mid));
                }
                if (sum <= h)
                {
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }
            }
            return low;
        }

        private int FindMax(List<int> nums)
        {
            int max = 0;
            for (int i = 0; i < nums.Count; i++)
            {
                if (max < nums[i]) max = Math.Max(max, nums[i]);
            }
            return max;
        }
    }
}
