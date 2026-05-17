using System.Collections.Generic;
using System.Linq;

namespace DSAAdvance.Array.Misc
{
    // GFG - Second Largest Element in an Array
    // Note: optimal is a single pass tracking largest + second largest (O(n), O(1)).
    public class SecondLargest
    {
        public int Solve(List<int> nums)
        {
            HashSet<int> set = new HashSet<int>(nums);
            var sets = set.OrderByDescending(o => o);
            int m = sets.ElementAt(0);
            foreach (int i in sets)
            {
                if (i != m) return i;
            }
            return -1;
        }
    }
}
