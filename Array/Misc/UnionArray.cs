using System.Collections.Generic;
using System.Linq;

namespace DSAAdvance.Array.Misc
{
    // GFG - Union of Two Sorted Arrays
    // Note: optimal is two-pointer merge for O(m+n) time. This impl is O((m+n)^2).
    public class UnionArray
    {
        public List<int> Solve(List<int> nums1, List<int> nums2)
        {
            List<int> lst = new List<int>();
            for (int i = 0; i < nums1.Count; i++) lst.Add(nums1[i]);
            for (int i = 0; i < nums2.Count; i++) lst.Add(nums2[i]);

            List<int> s1 = lst.ToList();
            // Bubble sort
            for (int i = 0; i < s1.Count; i++)
            {
                for (int j = i + 1; j < s1.Count; j++)
                {
                    if (s1[i] > s1[j])
                    {
                        int temp = s1[i];
                        s1[i] = s1[j];
                        s1[j] = temp;
                    }
                }
            }
            return s1;
        }
    }
}
