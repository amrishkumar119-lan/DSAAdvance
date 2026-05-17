using System.Collections.Generic;
using System.Linq;

namespace DSAAdvance.BinarySearch.OnAnswer
{
    // GFG - Book Allocation Problem / Allocate Minimum Pages
    // Distribute books to m students minimizing the max pages any student reads.
    // Binary search on the answer (max pages allowed).
    public class BookAllocation
    {
        public int Solve(List<int> nums, int m)
        {
            long low = nums.Max();
            long high = nums.Sum(o => (long)o);
            while (low <= high)
            {
                long mid = low + (high - low) / 2;
                int students = StudentsNeeded(nums, mid);
                if (students < m)
                {
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }
            }
            return (int)high;
        }

        // Helper: how many students are needed if max pages per student = 'page'
        private int StudentsNeeded(List<int> nums, long page)
        {
            int count = 1;
            long currentSum = 0;
            for (int i = 0; i < nums.Count; i++)
            {
                if ((nums[i] + currentSum) >= page)
                {
                    count++;
                    currentSum = nums[i];
                }
                else
                {
                    currentSum += nums[i];
                }
            }
            return count;
        }
    }
}
