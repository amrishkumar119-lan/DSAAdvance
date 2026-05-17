using System;
using System.Linq;

namespace DSAAdvance.BinarySearch.OnAnswer
{
    // LeetCode #1283 - Find the Smallest Divisor Given a Threshold
    // Find smallest d such that sum of ceil(nums[i]/d) <= limit.
    // Binary search on the answer (divisor).
    public class SmallestDivisor
    {
        public int Solve(int[] nums, int limit)
        {
            int low = 1, high = nums.Max();
            int ans = -1;
            while (low <= high)
            {
                int mid = (high + low) / 2;
                if (DivisionSumAtMost(nums, mid, limit))
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

        // Helper: does sum of ceil(nums[i]/mid) <= limit?
        private bool DivisionSumAtMost(int[] nums, int mid, int limit)
        {
            long count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                count += (long)Math.Ceiling((double)nums[i] / mid);
            }
            return count <= limit;
        }

        // Alternate version returning low directly
        public int SolveAlt(int[] nums, int limit)
        {
            int low = 1, high = nums.Max();
            while (low <= high)
            {
                int mid = (low + high) / 2;
                if (SumDivisor(nums, mid) <= limit)
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

        private long SumDivisor(int[] nums, int mid)
        {
            long sum = 0;
            foreach (int num in nums)
            {
                sum += (long)Math.Ceiling((double)num / mid);
            }
            return sum;
        }
    }
}
