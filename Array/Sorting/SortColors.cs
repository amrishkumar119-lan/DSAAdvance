using System.Collections.Generic;

namespace DSAAdvance.Array.Sorting
{
    // LeetCode #75 - Sort Colors (Dutch National Flag)
    // Sort an array containing only 0s, 1s, and 2s in-place.
    public class SortColors
    {
        // Dutch National Flag - Time O(n), Space O(1)
        public void Solve(List<int> nums)
        {
            int low = 0, mid = 0, high = nums.Count - 1;
            while (mid <= high)
            {
                if (nums[mid] == 0)
                {
                    int temp = nums[low];
                    nums[low] = nums[mid];
                    nums[mid] = temp;
                    low++; mid++;
                }
                else if (nums[mid] == 1)
                {
                    mid++;
                }
                else
                {
                    int temp = nums[high];
                    nums[high] = nums[mid];
                    nums[mid] = temp;
                    high--;
                }
            }
        }

        // int[] version - same algorithm
        public void SolveArray(int[] nums)
        {
            int low = 0, mid = 0, high = nums.Length - 1;
            while (mid <= high)
            {
                if (nums[mid] == 0)
                {
                    int temp = nums[low];
                    nums[low] = nums[mid];
                    nums[mid] = temp;
                    low++; mid++;
                }
                if (nums[mid] == 1)
                {
                    mid++;
                }
                else
                {
                    int temp = nums[high];
                    nums[high] = nums[mid];
                    nums[mid] = temp;
                    high--;
                }
            }
        }

        // --- Earlier cleaner attempt - kept for reference ---
        //public static void Solve(int[] nums)
        //{
        //    int low = 0, mid = 0, high = nums.Length - 1;
        //    while (mid <= high)
        //    {
        //        if (nums[mid] == 0)
        //        {
        //            int temp = nums[low];
        //            nums[low] = nums[mid];
        //            nums[mid] = temp;
        //            low++; mid++;
        //        }
        //        else if (nums[mid] == 1) { mid++; }
        //        else
        //        {
        //            int temp = nums[mid];
        //            nums[mid] = nums[high];
        //            nums[high] = temp;
        //            high--;
        //        }
        //    }
        //}
    }
}
