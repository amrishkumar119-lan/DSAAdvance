namespace DSAAdvance.Array.Misc
{
    // LeetCode #485 - Max Consecutive Ones
    // Given a binary array, return the max number of consecutive 1s.
    // Time O(n), Space O(1).
    public class MaxConsecutiveOnes
    {
        public int Solve(int[] nums)
        {
            int k = 0, temp = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 1)
                {
                    k++;
                }
                else
                {
                    if (temp < k) temp = k;
                    k = 0;
                }
            }
            if (k > temp) return k;
            return temp;
        }
    }
}
