using System.Collections.Generic;

namespace DSAAdvance.Array.Majority
{
    // LeetCode #229 - Majority Element II
    // Find all elements that appear more than n/3 times. At most 2 such elements exist.
    // Extended Boyer-Moore Voting (track 2 candidates).
    // Time O(n), Space O(1).
    public class MajorityElementII
    {
        // Version with verification pass (correct LC submission)
        public IList<int> Solve(List<int> nums)
        {
            List<int> lst = new List<int>();
            int n = nums.Count;
            int count1 = 0, count2 = 0;
            int element1 = 0, element2 = 0;

            // Pass 1: find candidates
            for (int i = 0; i < n; i++)
            {
                if (count1 == 0 && element2 != nums[i])
                {
                    count1++;
                    element1 = nums[i];
                }
                else if (count2 == 0 && element1 != nums[i])
                {
                    count2++;
                    element2 = nums[i];
                }
                else if (element1 == nums[i]) { count1++; }
                else if (element2 == nums[i]) { count2++; }
                else { count1--; count2--; }
            }

            // Pass 2: verify candidates
            count1 = 0; count2 = 0;
            for (int i = 0; i < n; i++)
            {
                if (element1 == nums[i]) count1++;
                if (element2 == nums[i]) count2++;
            }
            int mini = (n / 3) + 1;
            if (count1 >= mini) lst.Add(element1);
            if (count2 >= mini && element2 != element1) lst.Add(element2);

            return lst;
        }

        // Earlier version without verification (assumes both candidates are valid)
        public List<int> SolveNoVerify(List<int> nums)
        {
            List<int> lst = new List<int>();
            int el1 = 0, el2 = 0, count1 = 0, count2 = 0;
            for (int i = 0; i < nums.Count; i++)
            {
                if (count1 == 0 && el2 != nums[i])
                {
                    count1++;
                    el1 = nums[i];
                }
                else if (count2 == 0 && el1 != nums[i])
                {
                    count2++;
                    el2 = nums[i];
                }
                else if (el1 == nums[i]) { count1++; }
                else if (el2 == nums[i]) { count2++; }
                else { count1--; count2--; }
            }
            lst.Add(el1);
            lst.Add(el2);
            return lst;
        }
    }
}
