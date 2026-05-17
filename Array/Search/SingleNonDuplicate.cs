namespace DSAAdvance.Array.Search
{
    // LeetCode #540 - Single Element in a Sorted Array
    // Every element appears twice except one. Find the single one.
    // Trick: in a sorted array of pairs, the single element breaks the index pattern.
    // Time O(log n), Space O(1).
    public class SingleNonDuplicate
    {
        public int Solve(int[] nums)
        {
            int n = nums.Length;
            // Edge cases:
            if (n == 1) return nums[0];
            if (nums[0] != nums[1]) return nums[0];
            if (nums[n - 1] != nums[n - 2]) return nums[n - 1];

            int low = 1, high = n - 2;
            while (low <= high)
            {
                int mid = low + (high - low) / 2;

                // mid is the single element
                if (nums[mid] != nums[mid + 1] && nums[mid] != nums[mid - 1])
                {
                    return nums[mid];
                }

                // We are in the left part (single is to the right):
                if ((mid % 2 == 1 && nums[mid] == nums[mid - 1])
                    || (mid % 2 == 0 && nums[mid] == nums[mid + 1]))
                {
                    low = mid + 1;
                }
                // We are in the right part (single is to the left):
                else
                {
                    high = mid - 1;
                }
            }

            return -1;
        }
    }
}
