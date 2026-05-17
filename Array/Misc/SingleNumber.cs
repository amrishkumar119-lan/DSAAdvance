namespace DSAAdvance.Array.Misc
{
    // LeetCode #136 - Single Number
    // Every element appears twice except one. Find that one.
    // Note: optimal is XOR of all elements (O(n), O(1)). This impl assumes sorted input.
    public class SingleNumber
    {
        public int Solve(int[] nums)
        {
            for (int i = 0; i < nums.Length - 1; i += 2)
            {
                if (nums[i] != nums[i + 1])
                {
                    return nums[i];
                }
            }
            return nums[nums.Length - 1];
        }
    }
}
