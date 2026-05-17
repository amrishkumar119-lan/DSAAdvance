namespace DSAAdvance.BinarySearch.Sorted
{
    // GFG - Floor and Ceil in a Sorted Array
    // Floor of x = largest element <= x. Ceil of x = smallest element >= x.
    // Time O(log n).
    public class FloorAndCeil
    {
        public int[] Solve(int[] nums, int x)
        {
            int[] arr = { -1, -1 };
            arr[0] = FindFloor(nums, x);
            arr[1] = FindCeil(nums, x);
            return arr;
        }

        private int FindFloor(int[] nums, int x)
        {
            int low = 0, high = nums.Length - 1;
            int ans = -1;
            while (low <= high)
            {
                int mid = (high + low) / 2;
                if (nums[mid] <= x)
                {
                    ans = nums[mid];
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }
            }
            return ans;
        }

        private int FindCeil(int[] nums, int x)
        {
            int low = 0, high = nums.Length - 1;
            int ans = -1;
            while (low <= high)
            {
                int mid = (high + low) / 2;
                if (nums[mid] >= x)
                {
                    ans = nums[mid];
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }
            }
            return ans;
        }
    }
}
