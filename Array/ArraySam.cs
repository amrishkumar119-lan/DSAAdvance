using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAAdvance.Array
{
    public class ArraySam
    {
        // LeetCode #1 - Two Sum (Brute Force O(n^2))
        //public int[] TwoSum(int[] nums, int target)
        //{
        //    var find = new int[2];
        //    for (int i = 0; i < nums.Length; i++) {
        //        int complement = target - nums[i];
        //        for (int j = i + 1; j < nums.Length; j++) {
        //            if (nums[j] == complement) {
        //                find[0] = i;
        //                find[1] = j;
        //            }
        //        }
        //    }
        //    return find;
        //}


        // LeetCode #1 - Two Sum
        // Given nums[] and target, return indices of two numbers that add up to target.
        // Approach: HashMap, Time O(n), Space O(n)
        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                map[nums[i]] = i;
            }
            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];
                if (map.ContainsKey(complement) && map[complement] != i)
                {
                    return new int[] { i, map[complement] };
                }

            }
            return new int[] { };
        }
        
        // Scratchpad / driver method.
        // Uncomment a block below to test that problem.
        public static void Main()
        {
            // --- LeetCode #1 - Two Sum ---
            //ArraySam arraySam = new ArraySam();
            //int[] nums = { 2, 5, 10, 5, -2 };
            //int target = 3;
            //int[] ints = arraySam.TwoSum(nums, target);
            //for (int i = 0; i < ints.Length; i++) {
            //    Console.WriteLine(ints[i]);
            //}
            //Console.ReadLine();

            // --- Insert element at index (manual shift) ---
            //List<int> nums = new List<int>() { 1,2,3,5,6};//{1,2,10,3,5,6}
            //nums.Insert(2, 10);

            //int[] arr = { 1, 2, 3, 5, 6 };
            //int insertArry = 10;
            //int index = 3;

            //int[] NewArray = new int[arr.Length+1];
            //NewArray[index] = insertArry;
            //for (int i = 0; i < index; i++)
            //{
            //    NewArray[i] = arr[i];
            //}

            //for(int i = index; i < arr.Length; i++)
            //{
            //    NewArray[i+1]=arr[i];
            //}

            //foreach(int item in NewArray)
            //{
            //    Console.WriteLine(item);
            //}

            // --- LeetCode #344 - Reverse Array (in-place swap) ---
            //int[] ints = { 1, 2, 3, 4, 5 };
            //bool target=true;
            //for (int i = 0; i < ints.Length-1; i++)
            //{
            //    int temp = ints[i];
            //    ints[i] = ints[ints.Length-1-i];
            //    ints[ints.Length-1-i] = temp;
            //}
            //for(int i = 0;i < ints.Length; i++)
            //{
            //    Console.WriteLine(ints[i]);
            //}

            // --- Find maximum element ---
            //int[] ints = { -4, -3, 0, 1, -8 };
            //int Target = 0;
            //for (int i = 0; i<ints.Length-1; i++)
            //{
            //    if (ints[i] < ints[i + 1])
            //    {
            //        Target = ints[i+1];
            //    }
            //}

            //Console.WriteLine(Target);


            // --- LeetCode #14 - Longest Common Prefix ---
            //string[] arr = { "flower", "flow", "flight" };
            //string str = string.Empty;
            //string fl = arr[0];
            //int k = fl.Length;
            //for (int i = 1; i < arr.Length; i++)
            //{
            //    string s = arr[i];
            //    while (k > s.Length || !fl.Equals(s.Substring(0, k)))
            //    {
            //        k--;
            //        if (k == 0)
            //        { Console.WriteLine(""); }
            //        fl = fl.Substring(0, k);
            //    }
            //}
            //Console.WriteLine(fl);

            // --- Rotate array left by 1 ---
            ///int[] num = { 8, 8, 7, 6, 5 };
            //int[] num = { 8, 10, 7, 6, 5 };

            //int[] array = { 1, 2, 3, 4, 5 };
            //int f = array[0];
            //for (int i = 0; i < array.Length-1; i++)
            //{
            //    array[i] = array[i+1];
            //}
            //array[4] = f;
            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.WriteLine(array[i]);
            //}

            // --- LeetCode #26 - Remove Duplicates from Sorted Array (HashSet approach) ---
            int[] array = {1, 1, 1, 1, 2, 3, 4, 4, 5, 8, 8, 8, 8, 8, 9, 9, 9, 10, 10, 10, 12, 13, 13, 13, 13, 13, 13, 14, 14, 14, 15, 15, 16, 16, 16, 17, 17, 17, 18, 18, 19, 20, 20, 21, 21, 22, 22, 23, 24, 24, 24, 25, 25, 28, 28, 28, 29, 29, 29, 29, 31, 32, 32, 32, 33, 33, 33, 35, 36, 37, 37, 37, 37, 39, 40, 40, 40, 40, 41, 42, 42, 42, 43, 43, 43, 43, 43, 44, 45, 45, 45, 45, 45, 46, 47, 48, 48, 49, 49, 50};

            int up = 0;
            //int[] newarray=new int[array.Length];
            //for (int i = 0; i < array.Length; i++)
            //{
            //    if (array[i] != up)
            //    {
            //        newarray[k] = array[i];
            //        up=array[i];
            //        k++;
            //    }
            //}
            //int[] array = { 0, 0, 3, 3, 5, 6 };
            //List<int> list = new List<int>();
            //for (int i = 0; i < array.Length-1; i++)
            //{
            //    if (array[i] != array[i+1])
            //    {
            //        list.Add(array[i]);
            //    }

            //}
            //list.Add(array[array.Count() - 1]);
            //for (int i = 0; i < list.Count; i++)
            //{
            //   array[i]= list[i];
            //}

            int[] arrays = { 1, 2, 3 };
            //Array.Sort(arrays);


            HashSet<int> down = new HashSet<int>();

            foreach(int i in array)
            {
                down.Add(i);
            }

            int j= 0;
            foreach(int i in down)
            {
                array[j++] = i;
            }


            foreach (var m in array) { Console.WriteLine(m); }



        }
    }
}
