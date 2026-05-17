using System.Collections.Generic;

namespace DSAAdvance.Array.Misc
{
    // LeetCode #189 - Rotate Array
    // Rotate the array to the right by k steps.
    public class RotateArray
    {
        // Using extra space - Time O(n), Space O(k)
        // Note: Optimal solution is reverse-the-whole, reverse-first-k, reverse-rest (O(1) space).
        public void Solve(List<int> nums, int k)
        {
            int d = k % nums.Count;
            int m = 0;
            List<int> Temp = new List<int>();
            for (int i = 0; i < d; i++)
            {
                Temp.Add(nums[i]);
            }
            for (int j = d; j < nums.Count; j++)
            {
                nums[m] = nums[j];
                m++;
            }
            for (int i = 0; i < d; i++)
            {
                nums[nums.Count - Temp.Count + i] = Temp[i];
            }
        }
    }
}
