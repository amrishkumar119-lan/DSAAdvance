namespace DSAAdvance.BinarySearch.Rotated
{
    // GFG - Find Rotation Count in a Rotated Sorted Array
    // Given a sorted array rotated k times, return k (index of the minimum element).
    // Time O(log n).
    public class FindKRotation
    {
        public int Solve(int[] nums)
        {
            int low = 0, high = nums.Length - 1;
            int index = -1;
            while (low <= high)
            {
                int mid = (high + low) / 2;
                if (nums[low] <= nums[high])
                {
                    if (nums[low] < nums[mid])
                    {
                        return low;
                    }
                }
                if (nums[low] <= nums[mid])
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }
            }
            return index;
        }

        // --- Earlier full version tracking min element value + index ---
        //public int SolveV1(int[] nums)
        //{
        //    int low = 0, high = nums.Length - 1;
        //    int ans = int.MaxValue;
        //    int index = -1;
        //    while (low <= high)
        //    {
        //        int mid = low + (high - low) / 2;
        //        if (nums[low] <= nums[high])
        //        {
        //            if (nums[low] < ans) { index = low; ans = nums[low]; }
        //            break;
        //        }
        //        if (nums[low] <= nums[mid])
        //        {
        //            if (nums[low] < ans) { index = low; ans = nums[low]; }
        //            low = mid + 1;
        //        }
        //        else
        //        {
        //            if (nums[mid] < ans) { index = mid; ans = nums[mid]; }
        //            high = mid - 1;
        //        }
        //    }
        //    return index;
        //}
    }
}
