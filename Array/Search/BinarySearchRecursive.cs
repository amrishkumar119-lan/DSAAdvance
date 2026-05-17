namespace DSAAdvance.Array.Search
{
    // Classic Binary Search (recursive)
    // Time O(log n), Space O(log n) due to recursion stack.
    public class BinarySearchRecursive
    {
        public int Solve(int[] array, int high, int low, int target)
        {
            if (high < low) return -1;
            int mid = (high + low) / 2;

            if (array[mid] == target) return mid;
            else if (array[mid] > target) return Solve(array, mid - 1, low, target);
            else return Solve(array, high, mid + 1, target);
        }
    }
}
