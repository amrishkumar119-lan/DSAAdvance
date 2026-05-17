namespace DSAAdvance.Array.Search
{
    // LeetCode #34 - Find First and Last Position of Element in Sorted Array
    // Return [first, last] indices of target, or [-1, -1] if not found.
    // Note: optimal is two binary searches O(log n); this version is linear scan O(n).
    public class SearchRange
    {
        public int[] Solve(int[] nums, int target)
        {
            int first = -1, sec = -1;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == target)
                {
                    first = i;
                }
                else if (nums[i] == target && first != sec)
                {
                    sec = i;
                }
            }
            return new int[] { first, sec };
        }
    }
}
