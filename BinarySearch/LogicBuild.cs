using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAAdvance.BinarySearch
{
    public class Solution
    {


        // SPOJ AGGRCOW / GFG - Aggressive Cows
        // Place k cows in stalls so minimum distance between any two is maximized.
        // Approach: Binary search on the answer.
        public int AggressiveCows(int[] nums, int k)
        {
            int low = 0, high = nums.Max();
            System.Array.Sort(nums);
            while (low <= high)
            {
                int mid = (high + low) / 2;
                if (findAggressiveCows(nums, mid) <= k)
                {
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }
            }
            return high;
        }

        public int findAggressiveCows(int[] nums, int mid)
        {
            int count = 1, last = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                if ((nums[i] - last) >= mid)
                {
                    count++;
                    last = nums[i];
                }
            }
            return count;
        }

        // GFG - Book Allocation Problem / Allocate Minimum Pages
        // Distribute books to m students minimizing the maximum pages any student reads.
        // Approach: Binary search on the answer.
        public int findPages(List<int> nums, int m)
        {
            long low = nums.Max(); long high = nums.Sum(o => o);
            while (low <= high)
            {
                long mid = low + (high - low) / 2;
                int value =AssingPage(nums, mid);
                if (value < m)
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
        public int AssingPage(List<int> nums, long page)
        {
            int count = 1; long Countvalue = 0;
            for (int i = 0; i < nums.Count; i++)
            {
                if ((nums[i] + Countvalue) >= page)
                {
                    count++;
                    Countvalue = nums[i];
                }
                else
                {
                    Countvalue += nums[i];
                }
            }
            return count;
        }

        

        // LeetCode #1283 - Find the Smallest Divisor Given a Threshold
        public int SmallestDivisor(int[] nums, int limit)
        {
            ArrayList obj = new ArrayList();
            obj.AddRange(nums);
            int x = (int)obj[0];
            List<int> list = new List<int>();
            list.Add(limit);
            int a = list[0];

            int low = 1, high = nums.Max();
            int ans = -1;
            while (low <= high)
            {
                int mid = (high + low) / 2;
                if (FindSDivisor(nums, mid, limit))
                {
                    ans = mid;
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }
            }
            return ans;

        }
        public bool FindSDivisor(int[] nums, int mid, int limit)
        {
            long count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                count += (long)Math.Ceiling((double)nums[i] / mid);
            }
            return count <= limit;
        }

        // GFG - Find Nth Root of a Number (find r such that r^N = M)
        public int NthRoot(int N, int M)
        {
            int low = 0, high = M;

            while (low <= high)
            {
                long ans = 1, val = N;
                int mid = low + (high - low) / 2;
                while (val > 0)
                {
                    ans *= mid;
                    if (ans > M) break;
                    val--;
                }
                if (ans == M)
                {
                    return mid;
                }
                if (ans > M)
                {
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }
            }
            return -1;
        }

        // LeetCode #69 - Sqrt(x) / Floor of Square Root
        public int floorSqrt(int n)
        {
            int left = 1, right = n;
            while (left <= right)
            {
                int mid = (right + left) / 2;
                long root = (long)mid * (long)mid;
                if (root <= n)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
            return right;
        }

        // LeetCode #1482 - Minimum Number of Days to Make m Bouquets (Rose Garden)
        public int RoseGarden(List<int> nums, int k, int m)
        {

            int low = int.MaxValue, high = int.MinValue;
            int ans = -1;
            for (int i = 0; i < nums.Count; i++)
            {
                low = Math.Min(low, nums[i]);
                high = Math.Max(high, nums[i]);

            }
            while (low <= high)
            {
                int mid = (high + low) / 2;
                if (possible(nums, mid, k, m))
                {
                    ans = mid;
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }
            }
            return ans;
        }

        public bool possible(List<int> nums, int day, int k, int m)
        {
            int count = 0, possible=0;
            for (int i = 0; i < nums.Count; i++)
            {
                if (nums[i] <= day)
                {
                    count++;
                }
                else
                {
                    possible += count / k;
                    count = 0;
                }
            }
            possible += count/k;
            return possible >= m;
        }

        // LeetCode #1283 - Find the Smallest Divisor (alternate approach)
        public int FindSDivisor(int[] nums,int limit)
        {
            int low=1,high=nums.Max();
            while(low<=high)
            {
                int mid = (low+high)/2;
                if (SumDivisor(nums,mid) <=limit)
                {
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }
            }
            return low;
        }

        // LeetCode #875 - Koko Eating Bananas
        // Find minimum eating speed k such that Koko can eat all bananas within h hours.
        public int MinEatingSpeed(int[] piles, int h)
        {
            int low = 1, high = piles.Max();
            while (low <= high)
            {
                int mid = (high + low) / 2;
                long sum = 0;
                foreach (int num in piles)
                {
                    sum += (long)Math.Ceiling((double)num / mid);
                }
                if (sum <= h)
                {
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }

            }
            return low;
        }

        // LeetCode #875 - Koko Eating Bananas (List version)
        public int MinimumRateToEatBananas(List<int> nums, int h)
        {
            int low = 1, high = findMax(nums);
            while (low <= high)
            {
                int mid = (high + low) / 2;
                long sum = 0;
                foreach (int num in nums)
                {
                    sum += (long)Math.Ceiling((double)(num / mid));
                }
                if (sum <= h)
                {
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }

            }
            return low;
        }

        public int findMax(List<int> nums)
        {
            int max = 0;
            for (int i = 0; i < nums.Count; i++)
            {
                if (max<nums[i])
                {
                    max = Math.Max(max, nums[i]);
                }
            }
            return max;
        }

        public long SumDivisor(int[] nums, int mid)
        {
            List<int> ints = new List<int>();
            ints.Max();
        
            long sum = 0;
            foreach (int num in nums) { 
              sum += (long)Math.Ceiling((double)num/mid);
            }
            return sum;
        }



        //public int NthRoot(int N, int M)
        //{
        //    int low = 1, high = M;
        //    while (low <= high)
        //    {
        //        int mid = (high + low) / 2;
        //        int em = findRoot(mid, N, M);
        //        if (em == 0)
        //        {
        //            return mid;
        //        }
        //        if (em == 2)
        //        {
        //            high = mid - 1;

        //        }
        //        else
        //        {
        //            low = mid + 1;
        //        }
        //    }
        //    return -1;
        //}

        public int findRoot(int mid, int N, int M)
        {
            int val = mid,ans=1;
            while (N > 0)
            {
                if (N % 2 == 1)
                {
                    ans *= val;
                    if (ans > M) return 2;
                    N--;
                }
                else
                {
                     N /= 2;
                    val *= val;
                    if (val > M) return 2;
                }
            }
            if (ans == M)
            {
                return 0;
            }
            return 1;
        }

        //public int NthRoot(int N, int M)
        //{
        //    int low = 1, high = M;
        //    while (low <= high)
        //    {
        //        int mid = (high + low) / 2;
        //        int mf = GetData(mid, N, M);
        //        if (mf == 0)
        //        {
        //            return mid;
        //        }
        //        if (mf == 2)
        //        {
        //            high = mid - 1;
        //        }
        //        else
        //        {
        //            low = mid + 1;
        //        }
        //    }
        //    return -1;
        //}
        //public int GetData(int mid, int N, int M)
        //{
        //    long val = mid, ans = 1;
        //    while (N > 0)
        //    {
        //        if (mid % 2 == 1)
        //        {
        //            ans *= val;
        //            if (val > M) return 2;
        //            N--;
        //        }
        //        else
        //        {
        //            N /= 2;
        //            val *= val;
        //            if (val > M) return 2;
        //        }
        //    }
        //    if (M == ans) return 0;
        //    return 1;
        //}


        //public int NthRoot(int N, int M)
        //{
        //    int low = 1,high = M;
        //    while (low <= high)
        //    {
        //        int mid = (high + low) / 2;
        //        int mf = GetData(mid, N, M);
        //        if (mf == 0)
        //        {
        //            return mid;
        //        }
        //        if (mf == 2)
        //        {
        //            high = mid - 1;
        //        }
        //        else
        //        {
        //            low = mid + 1;
        //        }
        //    }
        //    return -1;
        //}
        //public int GetData(int mid, int N, int M)
        //{
        //    long val = mid,ans=1;
        //    while (N > 0)
        //    {
        //        if (N % 2 == 1)
        //        {
        //            ans *= val;
        //            if (val > M) return 2;
        //            N--;
        //        }
        //        else
        //        {
        //            N /= 2;
        //            val *= val;
        //            if (val > M) return 2;
        //        }
        //    }
        //    if (M == ans) return 0;
        //    return 1;
        //}






        //public int NthRoot(int N, int M)
        //{
        //    int low = 1, high = M;
        //    while (low <= high)
        //    {
        //        int mid = (high + low) / 2;
        //        int cmp = helperFunc(mid, N, M);
        //        if (cmp == 1)
        //        {
        //            return mid;
        //        }
        //        else if (cmp == 0)
        //        {
        //            low = mid + 1;
        //        }
        //        else
        //        {
        //            high = mid - 1;
        //        }
        //    }
        //    return -1;
        //}
        //public int helperFunc(int mid, int n, int m)
        //{
        //    long ans = 1, baseVal = mid;
        //    while (n > 0)
        //    {
        //        if (n % 2 == 1)
        //        {
        //            ans *= baseVal;
        //            if (ans > m) return 2;
        //            n--;
        //        }
        //        else
        //        {
        //            n /= 2;
        //            baseVal *= baseVal;
        //            if (baseVal > m) return 2;
        //        }
        //    }
        //    if (ans == m) return 1;
        //    return 0;
        //}


        // LeetCode #540 - Single Element in a Sorted Array
        public int SingleNonDuplicate(int[] nums)
        {
            int k = nums.Max();
            int low = 0, high = nums.Length - 1;
            while (low <= high)
            {
                int mid = (high + low) / 2;
                if (nums[mid] != nums[mid + 1] && nums[mid] != nums[mid - 1])
                {
                    return nums[mid];
                }
                if ((mid % 2 == 1 && nums[mid] == nums[mid - 1]) || (mid%2 == 0 && nums[mid]== nums[mid + 1]))
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }
            }
            return -1;
        }

       

        // GFG - Find Rotation Count in a Rotated Sorted Array
        public int findKRotation(int[] nums)
        {
            int low = 0, high = nums.Length - 1;
            int ans = int.MaxValue;
            int index = -1;
            while (low <= high)
            {
                int mid = (high + low) / 2;
                if (nums[low] <= nums[high])
                {
                    if (nums[low] < nums[mid])
                    {
                        return low;
                    }
                }
                if (nums[low] <= nums[mid])
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }
            }
            return index;
        }


        //public int findKRotation(int[] nums)
        //{
        //    int low = 0, high = nums.Length - 1;
        //    int ans = int.MaxValue;
        //    int index = -1;
        //    while (low <= high)
        //    {
        //        int mid = low + (high - low) / 2;

        //        /* Search space is already sorted
        //           then nums[low] will always be
        //           the minimum in that search space */
        //        if (nums[low] <= nums[high])
        //        {
        //            if (nums[low] < ans)
        //            {
        //                index = low;
        //                ans = nums[low];
        //            }
        //            break;
        //        }

        //        // If left part is sorted update the ans
        //        if (nums[low] <= nums[mid])
        //        {
        //            if (nums[low] < ans)
        //            {
        //                index = low;
        //                ans = nums[low];
        //            }
        //            // Eliminate left half
        //            low = mid + 1;
        //        }
        //        else
        //        {
        //            /* update the ans if it 
        //            is less than nums[mid] */
        //            if (nums[mid] < ans)
        //            {
        //                index = mid;
        //                ans = nums[mid];
        //            }
        //            // Eliminate right half
        //            high = mid - 1;
        //        }
        //    }
        //    // Return the index as answer
        //    return index;
        //}


        // LeetCode #81 - Search in Rotated Sorted Array II (with duplicates)
        public bool searchInARotatedSortedArrayII(int[] nums, int k)
        {
            int low = 0, high = nums.Length - 1;
            while (low <= high)
            {
                int mid = (high + low) / 2;
                if (nums[mid] == k)
                    return true;
                if (nums[low] <= nums[mid])
                {
                    if (nums[low] <= k && k <= nums[mid])
                    {
                        high = mid - 1;
                    }
                    else
                    {
                        low = mid + 1;
                    }
                }
                else
                {
                    if (k <= nums[high] && nums[mid] <= k)
                    {
                        low = mid + 1;
                    }
                    else
                    {
                        high = mid - 1;
                    }
                }
            }
            return false;
        }

        // GFG - Floor and Ceil in a Sorted Array
        public int[] GetFloorAndCeil(int[] nums, int x)
        {
            int[] arr = { -1, -1 };
            arr[0] = Findfloor(nums, x);
            arr[1] = FindCeil(nums, x);
            return arr;
        }

        private int Findfloor(int[] nums, int x)
        {
            int low = 0, high = nums.Length - 1;
            int ans = -1;
            if (low <= high)
            {
                int mid = (high + low) / 2;
                if (nums[mid] <= x)
                {
                    ans = nums[mid];
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }
            }
            return ans;
        }
        private int FindCeil(int[] nums, int x)
        {
            int low = 0, high = nums.Length - 1;
            int ans = -1;
            if (low <= high)
            {
                int mid = (high + low) / 2;
                if (nums[mid] >= x)
                {
                    ans = nums[mid];
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }
            }
            return ans;
        }
    }

    public class LogicBuild
    {
       
        public static void Main()
        {
            int[] nums = { 10, 1, 2, 7, 5 };
            //List<int> nums = new List<int>() { 1, 2, 3, 4, 5 };
            int m = 3,k=2;
            


            Solution sol = new Solution();
            int result = sol.AggressiveCows(nums, 2);

            Console.WriteLine("The floor and ceil are: " + result);
        }
    }
}
