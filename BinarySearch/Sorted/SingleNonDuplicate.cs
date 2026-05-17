namespace DSAAdvance.BinarySearch.Sorted
{
    // LeetCode #540 - Single Element in a Sorted Array
    // Every element appears twice except one. Find it. Time O(log n).
    // (Alternate implementation - see also Array/Search/SingleNonDuplicate.cs)
    public class SingleNonDuplicate
    {
        public int Solve(int[] nums)
        {
            int low = 0, high = nums.Length - 1;
            while (low <= high)
            {
                int mid = (high + low) / 2;
                if (mid + 1 < nums.Length && mid - 1 >= 0
                    && nums[mid] != nums[mid + 1] && nums[mid] != nums[mid - 1])
                {
                    return nums[mid];
                }
                if ((mid % 2 == 1 && mid - 1 >= 0 && nums[mid] == nums[mid - 1])
                    || (mid % 2 == 0 && mid + 1 < nums.Length && nums[mid] == nums[mid + 1]))
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }
            }
            return -1;
        }
    }
}
