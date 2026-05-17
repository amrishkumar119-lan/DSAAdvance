using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using DSAAdvance.Basic;

namespace DSAAdvance.Array
{
    public class BasicArray
    {

        public int SingleNonDuplicate(int[] nums)
        {
            int n = nums.Length; // Size of the array.

            // Edge cases:
            if (n == 1) return nums[0];
            if (nums[0] != nums[1]) return nums[0];
            if (nums[n - 1] != nums[n - 2]) return nums[n - 1];

            int low = 1, high = n - 2;
            while (low <= high)
            {
                int mid = low + (high - low) / 2;

                // If nums[mid] is the single element:
                if (nums[mid] != nums[mid + 1] && nums[mid] != nums[mid - 1])
                {
                    return nums[mid];
                }

                // We are in the left part:
                if ((mid % 2 == 1 && nums[mid] == nums[mid - 1])
                    || (mid % 2 == 0 && nums[mid] == nums[mid + 1]))
                {
                    // Eliminate the left half:
                    low = mid + 1;
                }
                // We are in the right part:
                else
                {
                    // Eliminate the right half:
                    high = mid - 1;
                }
            }

            // Dummy return statement:
            return -1;
        }

        public int[] SearchRange(int[] nums, int target)
        {
            int k=int.MinValue;
            int first = -1, sec = -1;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == target)
                {
                    first = i;
                }
                else if (nums[i] == target && first != sec)
                {
                    sec = i;
                }
            }
            return new int[] { first, sec };
        }



        int cnt = 0;

        public void print(int i,int n)
        {
            if (i>n) return;
            print(i+1,n);
            Console.WriteLine(i);
        }

        public int search(int[] array,int high,int low,int target)
        {
            if (high<low)
                return -1;
            int mid = (high + low) / 2;

            if (array[mid] == target)
                return mid;
            else if (array[mid] > target)
                return search(array, mid-1, low, target);
            else return search(array, high, mid + 1, target);
        }

        public int[] InsertionSort(int[] nums)
        {
            for (int i = 1; i < nums.Length - 1; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    if (nums[j - 1]>nums[j])
                    {
                        int temp = nums[j-1];
                        nums[j - 1] = nums[j];
                        nums[j] = temp;
                    }
                }
            }
            return nums;
        }

        public List<int> margeS(List<int> nums)
        {
            int n=nums.Count;
            this.mergeSort(nums, 0, n - 1);
            return nums;
        }

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
                    cnt += (mid - left + 1);
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


        public static IList<int> SpiralOrder2(int[][] matrix)
        {
            List<int> Lst = new List<int>();
            int c = matrix.Length - 1, r = matrix[0].Length - 1;
            int top = 0, bottom = 0;
            while (c > top && r > bottom)
            {
                for (int i = top; i <= r; i++)
                {
                    Lst.Add(matrix[top][i]);
                }
                top++;
                for (int i = top; i <= c; i++)
                {
                    Lst.Add(matrix[i][r]);
                }
                r--;
                if (top <= c)
                {
                    for (int i = r; i >= bottom; i--)
                    {
                        Lst.Add(matrix[c][i]);
                    }
                    c--;
                }
                if (bottom <= r)
                {
                    for (int i = c; i >= bottom; i--)
                    {
                        Lst.Add(matrix[bottom][i]);
                    }
                    bottom++;
                }
            }
            return Lst;
        }

        public static IList<IList<int>> ThreeSum(int[] nums)
        {
           System.Array.Sort(nums);
            IList<IList<int>> lst = new List<IList<int>>();
            for (int i = 0; i < nums.Count(); i++)
            {
                if (i > 0 && nums[i] == nums[i - 1]) continue;
                int mid = i + 1, Last = nums.Count() - 1;
                while (mid <= Last)
                {
                    int sum = nums[i] + nums[mid] + nums[Last];
                    if (sum == 0)
                    {
                        lst.Add(new List<int>() { nums[i], nums[mid], nums[Last] });
                        mid++; Last--;
                        while (mid < Last && nums[mid] == nums[mid - 1]) mid++;
                        while (mid < Last && nums[Last] == nums[Last + 1]) Last--;
                    }
                    else if (sum < 0)
                    {
                        mid++;
                    }
                    else
                    {
                        Last--;
                    }
                }
            }
            return lst;
        }
        public static int Reverse(int x)
        {
            bool isTrue = x < 0;
            char[] chr =Math.Abs(x).ToString().ToCharArray();
            string str = string.Empty;
            for (int i = chr.Length - 1; i >= 0; i--)
            {
                str += chr[i].ToString();
            }
            long kk = long.Parse(str);
            if(kk > int.MaxValue)
            {
                return 0;
            }
            return (isTrue ? - (int)kk : (int)kk);
        }

        public static bool IsPalindrome(int x)
        {
            string d = x.ToString();
            int a = 0, b = d.Length - 1;
            while (a < b)
            {
                if (d[a] != d[b]) return false;
                a++;b--;
            }
            return false;

        }

        //public static IList<IList<int>> ThreeSum(int[] nums)
        //{
        //    //Array.Sort(nums);
        //    IList<IList<int>> list1 = new List<IList<int>>();
        //    for (int i = 0; i < nums.Length - 2; i++)
        //    {
        //        if (i > 0 && nums[i] == nums[i - 1]) continue;
        //        int mid = i + 1, high = nums.Length - 1;
        //        while (mid < high)
        //        {
        //            int sum = nums[i] + nums[mid] + nums[high];
        //            if (sum < 0)
        //            {
        //                mid++;
        //            }
        //            else if (sum > 0)
        //            {
        //                high--;
        //            }
        //            else
        //            {
        //                list1.Add(new List<int>() { nums[i], nums[mid], nums[high] });
        //                mid++; high--;
        //                while (mid < high && nums[mid] == nums[mid - 1]) mid++;
        //                while (mid < high && nums[high] == nums[high - 1]) high--;
        //            }
        //        }

        //    }
        //    return list1;
        //}

        public static IList<IList<int>> FourSum(int[] nums, int target)
        {
            List<IList<int>> lst = new List<IList<int>>();
            //Array.Sort(nums);
            for (int i = 0; i < nums.Length; i++)
            {
                if (i > 0 && nums[i] == nums[i - 1]) continue;
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (j > i + 1 && nums[j] == nums[j - 1]) continue;
                    int mid = j + 1, high = nums.Length - 1;
                    while (mid < high)
                    {
                        long sum = nums[i] + nums[j] + nums[mid] + nums[high];
                        if (sum == target)
                        {
                            lst.Add(new List<int>() { nums[i], nums[j], nums[mid], nums[high] });
                            mid++; high--;
                            while (mid < high && nums[mid] == nums[mid - 1]) mid++;
                            while (mid < high && nums[high] == nums[high + 1]) high--;
                        }
                        else if (sum > target)
                        {
                            high--;
                        }
                        else
                        {
                            mid++;
                        }
                    }
                }
            }
            return lst;
        }

        public static void SortArrayUsing0s1s2s(int[] nums)
        {
            int m = Math.Abs(nums.Length);
            int low = 0, mid = 0, high = nums.Length - 1;
            while (mid <= high)
            {
                if (nums[mid] == 0)
                {
                    int temp = nums[low];
                    nums[low] = nums[mid];
                    nums[mid] = temp;
                    low++; mid++;
                }
                if (nums[mid] == 1)
                {
                    mid++;
                }
                else
                {
                    int temp = nums[high];
                    nums[high] = nums[mid];
                    nums[mid] = temp;
                    high--;
                }
            }
            //int n = arr.Length;
            //int lo = 0, mid = 0;
            //int hi = n - 1;
            //while (mid <= hi)
            //{
            //    if (arr[mid] == 0)
            //    {
            //        int temp = arr[lo];
            //        arr[lo] = arr[mid];
            //        arr[mid] = temp;
            //        lo++;
            //        mid++;

            //    }
            //    else if (arr[mid] == 1)
            //    {
            //        mid++;
            //    }
            //    else
            //    {
            //        int temp = arr[mid];
            //        arr[mid] = arr[hi];
            //        arr[hi] = temp;
            //        hi--;
            //    }
            //}

        }

        public static List<int> MajorityElementTwo(List<int> nums)
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
                else if (el1 == nums[i])
                {
                    count1++;
                }
                else if (el2 == nums[i])
                {
                    count2++;
                }
                else
                {
                    count1--; count2--;
                }
            }
            lst.Add(el1);
            lst.Add(el2);
            return lst;
        }

        public static List<int> SpiralOrder1(List<List<int>> matrix)
        {
            List<int> Lst = new List<int>();
            int c = matrix.Count - 1, r = matrix[0].Count - 1;
            int top = 0, bottom = 0;
            while (c >= top && r >= bottom)
            {
                for (int i = top; i <= r; i++)
                {
                    Lst.Add(matrix[top][i]);
                }
                top++;
                for (int i = top; i <= c; i++)
                {
                    Lst.Add(matrix[i][r]);
                }
                r--;

                if (c >= top)
                {
                    for (int i = r; i >= bottom; i--)
                    {
                        Lst.Add(matrix[c][i]);
                    }
                    c--;
                }
                if (r >= bottom)
                {
                    for (int i = c; i >= top; i--)
                    {
                        Lst.Add(matrix[bottom][i]);
                    }
                    bottom++;
                }
            }
            return Lst;
        }


        public static int SecondLargestElement(List<int> nums)
        {

            HashSet<int> set = new HashSet<int>(nums);
            var sets = set.OrderByDescending(o => o);
            int m = sets.ElementAt(set.Count - set.Count);
            foreach (int i in sets)
            {
                if (i != m)
                {
                    return i;
                }
            }
            return -1;
        }

        public static int FindMaxConsecutiveOnes(int[] nums)
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
                    if (temp < k)
                    {
                        temp = k;

                    }
                    k = 0;
                }
            }
            if (k > temp)
            {
                return k;
            }
            return temp;
        }

        public static void rotateArray(List<int> nums, int k)
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

        public static int removeDuplicates(List<int> nums)
        {
            int k = 0;
            for (int i = 0; i < nums.Count - 1; i++)
            {

                if (nums[i] == nums[i + 1])
                {
                    nums.Remove(nums[i]);
                    i--;
                }

            }
            return nums.Count;
        }

        public static List<int> UnionArray(List<int> nums1, List<int> nums2)
        {
            List<int> lst = new List<int>();
            for (int i = 0; i < nums1.Count; i++)
            {
                lst.Add(nums1[i]);
            }
            for (int i = 0; i < nums2.Count; i++)
            {
                lst.Add(nums2[i]);
            }

            HashSet<int> set = new HashSet<int>(lst);
            List<int> s1 = lst.ToList();
            // List<int> s1= nums1.Union(nums2).ToList();
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

        public static int CountQuadruplets(int[] nums)
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

        public static int MajorityElement(List<int> nums)
        {
            int count = 0, Element = 0;
            for (int i = 0; i < nums.Count; i++)
            {
                if (count == 0)
                {
                    count++;
                    Element = nums[i];
                }
                if (Element == nums[i])
                {
                    count++;
                }
                else
                {
                    count--;
                }
            }
            return Element;
        }

        public static List<int> FindMissingRepeatingNumbers(List<int> nums)
        {
            //List<int> lst = new List<int>();
            int n = nums.Count;
            int repeat = 0, missing = 0;

            for (int i = 1; i <= n; i++)
            {

                int count = 0;
                for (int j = 0; j < n; j++)
                {
                    if (i == nums[j])
                    {
                        count++;
                    }
                }
                if (count == 2)
                {
                    repeat = i;
                }
                else if (count == 0)
                {
                    missing = i;
                }
                if (repeat > 0 && missing > 0)
                {
                    break;
                }
            }

            return new List<int>() { repeat, missing };
        }

        //public IList<IList<int>> ThreeSum(int[] nums)
        //{
        //    HashSet<string> set = new HashSet<string>();
        //    for (int i = 0; i < nums.Length - 2; i++)
        //    {
        //        for (int j = i + 1; j < nums.Length - 1; j++)
        //        {
        //            for (int k = j + 1; k < nums.Length; k++)
        //            {
        //                if ((nums[i] + nums[j] + nums[k] == 0))
        //                {
        //                    List<int> temp = new List<int> { nums[i], nums[j], nums[k] };
        //                    set.Add(string.Join(",", temp));
        //                }
        //            }
        //        }
        //    }
        //    List<IList<int>> ans = new List<IList<int>>();
        //    foreach (string trl in set)
        //    {
        //        ans.Add(trl.Split(',').Select(int.Parse).ToList());

        //    }

        //    return ans;
        //}

        //public static IList<IList<int>> FourSum(int[] nums, int target)
        //{
        //    HashSet<string> set = new HashSet<string>();
        //    int length = nums.Length - 1;
        //    List<IList<int>> lst = new List<IList<int>>();
        //    for (int i = 0; i <= length - 2; i++)
        //    {
        //        if (i > 0 && nums[i] == nums[i + 1]) continue;
        //        for (int j = i + 1; j <= length - 1; j++)
        //        {
        //            if (j > i + 1 && nums[j] == nums[j + 1]) continue;

        //            int left = j + 1, right = nums.Length - 1;
        //            int remaining = nums[j] + nums[i];

        //            while (right >= left)
        //            {
        //                if (nums[i] + nums[j] + nums[left] == 0)
        //                {
        //                    List<int> ad = new List<int>() { nums[i], nums[j], nums[left] };
        //                    //ad.Add(new  nums[i], nums[j], nums[left]);
        //                    //lst.Add(new List<int>() { nums[i], nums[j], nums[left] });
        //                    set.Add(string.Join(",", ad));
        //                    left++;
        //                    right--;
        //                    while (right > left && nums[left] == nums[left - 1]) left++;
        //                    while (left < right && nums[right] == nums[right + 1]) right--;

        //                }
        //                else
        //                {
        //                    left++; right--;
        //                }
        //            }
        //        }
        //    }

        //    foreach (string trl in set)
        //    {
        //        lst.Add(trl.Split(',').Select(int.Parse).ToList());
        //    }
        //    return lst;
        //}

        //public static IList<IList<int>> ThreeSum(int[] nums)
        //{
        //    //Array.Sort(nums);
        //    int length = nums.Length - 1;
        //    List<IList<int>> lst = new List<IList<int>>();
        //    HashSet<string> set = new HashSet<string>();
        //    for (int i = 0; i <= length; i++)
        //    {
        //        if (i > 0 && nums[i] == nums[i + 1]) continue;
        //        for (int j = i + 1; j <= length; j++)
        //        {
        //            if (j > i + 1 && nums[j] == nums[j + 1]) continue;
        //            for (int k = length; k >= 0; k--)
        //            {
        //                if (k > j + 1 && nums[k] == nums[k - 1]) continue;
        //                if (nums[i] + nums[j] + nums[k] == 0)
        //                {
        //                    List<int> ad = new List<int>() { nums[i], nums[j], nums[k] };
        //                    ad.Sort();
        //                    set.Add(string.Join(",", ad));
        //                }
        //            }
        //        }
        //    }
        //    foreach (string trl in set)
        //    {
        //        lst.Add(trl.Split(',').Select(int.Parse).ToList());
        //    }
        //    return lst;
        //}



        public static int SingleNumber(int[] nums)
        {
            for (int i = 0; i < nums.Length - 1; i += 2)
            {
                if (nums[i] != nums[i + 1])
                {
                    return nums[i];
                }
            }
            return nums[nums.Length - 1];

        }


        public static int[] IntersectionArray(int[] nums1, int[] nums2)
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

        public static List<int> Leaders(List<int> nums)
        {
            List<int> lst = new List<int>();
            int k = nums[nums.Count - 1];
            lst.Add(k);
            for (int i = nums.Count - 2; i >= 0; i--)
            {
                if (nums[i] > k)
                {
                    lst.Add(nums[i]);
                    k = nums[i];
                }
            }
            var s = lst.OrderByDescending(x => x).ToList();
            return s;
        }


        public static int skk(int r, int k)
        {

            int res = 1;
            for (int i = 0; i < k; i++)
            {
                res = res * (r - i);
                res = res / (i + 1);
            }
            return res;
        }


        public static List<int> SpiralOrder(List<List<int>> matrix)
        {
            List<int> lst = new List<int>();
            int c = matrix.Count - 1, r = matrix[0].Count - 1;
            int top = 0, bottom = 0;
            while (top <= c && bottom <= r)
            {
                for (int i = top; i <= r; i++)
                {
                    lst.Add(matrix[top][i]);
                }
                top++;
                for (int i = top; i <= c; i++)
                {
                    lst.Add(matrix[i][r]);
                }
                r--;
                if (r >= top)
                {
                    for (int i = r; i >= bottom; i--)
                    {
                        lst.Add(matrix[c][i]);
                    }
                    c--;
                }
                if (c >= bottom)
                {
                    for (int i = c; i >= top; i--)
                    {
                        lst.Add(matrix[i][bottom]);
                    }
                    bottom++;
                }
            }
            return lst;
        }

        public void SortZeroOneTwo(List<int> nums)
        {
            int low = 0, mid = 0, high = nums.Count - 1;
            while (mid <= high)
            {
                if (nums[mid] == 0)
                {
                    int temp = nums[low];
                    nums[low] = nums[mid];
                    nums[mid] = temp;
                    low++; mid++;
                }
                else if (nums[mid] == 1)
                {
                    mid++;
                }
                else
                {
                    int temp = nums[high];
                    nums[high] = nums[mid];
                    nums[mid] = temp;
                    high--;
                }
            }
        }

        //public static void SortColors(int[] nums)
        //{
        //    int low=0,mid=0,high=nums.Length-1;
        //    while (high >= mid)
        //    {
        //        if (nums[mid] == 0)
        //        {
        //            int temp=nums[low];
        //            nums[low]=nums[mid];
        //            nums[mid]=temp;
        //            low++;
        //            mid++;
        //        }
        //        else if (nums[mid] == 1)
        //        {
        //            mid++;
        //        }
        //        else {
        //             int temp=nums[high];
        //             nums[high]=nums[mid];
        //             nums[mid]=temp;

        //             high--;
        //        }
        //    }
        //}

        public static void RotateMatrix(int[][] matrix)
        {
            int R = matrix.Length, C = matrix[0].Length;
            int[][] tem = new int[R][];
            if (matrix.Count() == 0)
            {
                return;
            }
            for (int i = 0; i < R; i++)
            {
                tem[i] = new int[matrix[0].Length];
            }
            for (int i = 0; i < R; i++)
            {
                for (int j = 0; j < C; j++)
                {
                    tem[i][j] = matrix[i][j];
                }
            }

            int m = 0;
            for (int i = R - 1; i >= 0; i--)
            {
                for (int j = 0; j < C; j++)
                {
                    matrix[j][m] = tem[i][j];
                }
                m++;
            }
        }

        public List<int> TwoSum(List<int> nums, int target)
        {
            List<int> lst = new List<int>();
            for (int i = 0; i < nums.Count; i++)
            {
                int comp = target - nums[i];
                for (int j = i + 1; j < nums.Count; j++)
                {
                    if (nums[j] == comp)
                    {
                        lst.Add(i);
                        lst.Add(j);
                        return lst;
                    }
                }
            }
            return lst;
        }


        public static IList<int> MajorityElement2(List<int> nums)
        {
            List<int> lst = new List<int>();
            int n = nums.Count;
            int count1 = 0, count2 = 0;
            int Element1 = 0, Element2 = 0;
            for (int i = 0; i < n; i++)
            {
                if (count1 == 0 && Element2 != nums[i])
                {
                    count1++;
                    Element1 = nums[i];
                }
                else if (count2 == 0 && Element1 != nums[i])
                {
                    count2++;
                    Element2 = nums[i];
                }
                else if (Element1 == nums[i])
                {
                    count1++;
                }
                else if (Element2 == nums[i])
                {
                    count2++;
                }
                else { count1--; count2--; }
            }
            count1 = 0; count2 = 0;
            for (int i = 0; i < n; i++)
            {
                if (Element1 == nums[i])
                {
                    count1++;
                }
                if (Element2 == nums[i])
                {
                    count2++;
                }
            }
            int mini = (n / 3) + 1;

            if (count1 >= mini)
            {
                lst.Add(Element1);
            }
            if (count2 >= mini && Element2 != Element1)
            {
                lst.Add(Element2);
            }

            return lst;
        }

        public static void Main()
        {
            //int[][] twoD = new int[][] { new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 }, new int[] { 7, 8, 9 } };


            //int[] nums = { 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2 };
            // int target = 8;
            //[2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2]

            int[] nums = { 1, 1, 2, 2, 3, 3, 4, 5, 5, 6, 6 };
            //var holds = CountQuadruplets(nums);
            //List<List<int>> lst = new List<List<int>>() { new List<int>() { 1, 2, 3 }, new List<int>() { 4, 5, 6 }, new List<int>() { 7, 8, 9 } };
            
            int k= new BasicArray().SingleNonDuplicate(nums);
            
            new BasicArray().print(1,5);
            //int[] lstt= { 3, 4, 6, 7, 9, 12, 16, 17 };
            //var merge = new BasicArray().search(lstt,7,0,13);
            //List<int> num =new List<int>() {3,4,6,7,9,12,16,17 };
            //var cnt=new BasicArray().NumberOfInversions(num);
            //int[][] lst = { new int[] { 1, 2, 3, 4  },new int[] { 5, 6, 7, 8 },new int[] { 9, 10, 11, 12 } };
            //var datas = SpiralOrder2(lst);
            //int[] nums =  { -1, 0, 1, 2, -1, -4 };
            // List<int> nums =new List<int>() { 1, 2, 1, 1, 3, 2, 2 };
            //var data = ThreeSum(nums);
            //var dat = TwoSumUsingHasMap(nums, 7);
            //int k = Reverse(1534236469);
            //bool ispal= IsPalindrome(121);
            //Console.WriteLine(ispal);
           

            //int[] ints =  { 0,2,1,2,0,1};
            //SortColors(ints);



            //List<List<int>> matrix = new List<List<int>>() {
            // new List<int>(){ 1,2,3,4, },
            // new List<int>(){ 5,6,7,8 },
            // new List<int>(){ 9,10,11,12}

            // //1 2 3 4 8 12 16 15 14 13 9 5 6 7 11 10
            //};
            //List<int> order = SpiralOrder(matrix);

            //Console.WriteLine(k);
            //int[] arr = { 7, 7, 2, 2, 10, 10, 10 };
            //SortArrayUsing0s1s2s(arr);
        }
    }
}
