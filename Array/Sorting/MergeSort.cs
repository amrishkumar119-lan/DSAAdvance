using System.Collections.Generic;

namespace DSAAdvance.Array.Sorting
{
    // Merge Sort + GFG - Number of Inversions in an array
    // Time O(n log n), Space O(n).
    // Bonus: this implementation also counts inversions (pairs i<j with arr[i]>arr[j]).
    public class MergeSort
    {
        // Driver - sorts the list in place
        public List<int> Sort(List<int> nums)
        {
            int n = nums.Count;
            this.mergeSort(nums, 0, n - 1);
            return nums;
        }

        // GFG - returns total inversion count
        public long NumberOfInversions(List<int> nums)
        {
            int n = nums.Count;
            return mergeSort(nums, 0, n - 1);
        }

        public long mergeSort(List<int> arr, int low, int high)
        {
            long cnt = 0;
            if (low < high)
            {
                int mid = low + (high - low) / 2;
                cnt += mergeSort(arr, low, mid);
                cnt += mergeSort(arr, mid + 1, high);
                cnt += merge(arr, low, mid, high);
            }
            return cnt;
        }

        public long merge(List<int> arr, int low, int mid, int high)
        {
            List<int> temp = new List<int>();
            int left = low;
            int right = mid + 1;
            long cnt = 0;
            while (left <= mid && right <= high)
            {
                if (arr[left] <= arr[right])
                {
                    temp.Add(arr[left]);
                    left++;
                }
                else
                {
                    temp.Add(arr[right]);
                    cnt += (mid - left + 1); // all remaining left elements form inversions
                    right++;
                }
            }
            while (left <= mid)
            {
                temp.Add(arr[left]);
                left++;
            }
            while (right <= high)
            {
                temp.Add(arr[right]);
                right++;
            }
            for (int i = low; i <= high; i++)
            {
                arr[i] = temp[i - low];
            }
            return cnt;
        }
    }
}
