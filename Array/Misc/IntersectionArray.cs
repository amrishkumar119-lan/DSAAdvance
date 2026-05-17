using System.Collections.Generic;

namespace DSAAdvance.Array.Misc
{
    // LeetCode #349 - Intersection of Two Arrays
    public class IntersectionArray
    {
        public int[] Solve(int[] nums1, int[] nums2)
        {
            List<int> lst = new List<int>();
            for (int i = 0; i < nums1.Length; i++)
            {
                for (int j = i; j < nums2.Length - nums2.Length + i + 1 - j; j++)
                {
                    if (nums1[i] == nums2[j])
                    {
                        lst.Add(nums1[i]);
                    }
                }
            }
            return lst.ToArray();
        }
    }
}
