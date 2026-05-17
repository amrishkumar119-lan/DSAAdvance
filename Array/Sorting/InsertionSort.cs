namespace DSAAdvance.Array.Sorting
{
    // Insertion Sort
    // Build the sorted array one element at a time. Stable, in-place.
    // Time O(n^2) worst/average, O(n) best (already sorted), Space O(1).
    public class InsertionSort
    {
        public int[] Solve(int[] nums)
        {
            for (int i = 1; i < nums.Length - 1; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    if (nums[j - 1] > nums[j])
                    {
                        int temp = nums[j - 1];
                        nums[j - 1] = nums[j];
                        nums[j] = temp;
                    }
                }
            }
            return nums;
        }
    }
}
