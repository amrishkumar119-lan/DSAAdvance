using System.Linq;

namespace DSAAdvance.BinarySearch.OnAnswer
{
    // SPOJ AGGRCOW / GFG - Aggressive Cows
    // Place k cows in n stalls (positions in nums[]) so the minimum distance
    // between any two cows is maximized. Binary search on the answer (distance).
    public class AggressiveCows
    {
        public int Solve(int[] nums, int k)
        {
            int low = 0, high = nums.Max();
            System.Array.Sort(nums);
            while (low <= high)
            {
                int mid = (high + low) / 2;
                if (CanPlace(nums, mid) <= k)
                {
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }
            }
            return high;
        }

        // Helper: count how many cows we can place with minimum distance 'mid'
        private int CanPlace(int[] nums, int mid)
        {
            int count = 1, last = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                if ((nums[i] - last) >= mid)
                {
                    count++;
                    last = nums[i];
                }
            }
            return count;
        }
    }
}
