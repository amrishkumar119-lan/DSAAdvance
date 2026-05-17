namespace DSAAdvance.BinarySearch.Rotated
{
    // LeetCode #81 - Search in Rotated Sorted Array II
    // The array may contain duplicates. Return true if target k is found.
    // Time O(log n) average, O(n) worst case (due to duplicates).
    public class SearchInRotatedSortedArrayII
    {
        public bool Solve(int[] nums, int k)
        {
            int low = 0, high = nums.Length - 1;
            while (low <= high)
            {
                int mid = (high + low) / 2;
                if (nums[mid] == k) return true;
                if (nums[low] <= nums[mid])
                {
                    if (nums[low] <= k && k <= nums[mid])
                    {
                        high = mid - 1;
                    }
                    else
                    {
                        low = mid + 1;
                    }
                }
                else
                {
                    if (k <= nums[high] && nums[mid] <= k)
                    {
                        low = mid + 1;
                    }
                    else
                    {
                        high = mid - 1;
                    }
                }
            }
            return false;
        }
    }
}
