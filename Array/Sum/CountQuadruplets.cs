namespace DSAAdvance.Array.Sum
{
    // LeetCode #1995 - Count Special Quadruplets
    // Count quadruplets (i, j, k, m) where i<j<k<m and nums[i] + nums[j] + nums[k] == nums[m].
    public class CountQuadruplets
    {
        // Brute Force - Time O(n^4)
        public int Solve(int[] nums)
        {
            int s = 0;
            for (int i = 0; i < nums.Length - 3; i++)
            {
                for (int j = i + 1; j < nums.Length - 2; j++)
                {
                    for (int k = j + 1; k < nums.Length - 1; k++)
                    {
                        for (int m = k + 1; m < nums.Length; m++)
                        {
                            if (nums[i] + nums[j] + nums[k] == nums[m])
                            {
                                s++;
                            }
                        }
                    }
                }
            }
            return s;
        }
    }
}
