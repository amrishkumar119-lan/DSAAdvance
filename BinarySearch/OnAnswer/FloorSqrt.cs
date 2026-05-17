namespace DSAAdvance.BinarySearch.OnAnswer
{
    // LeetCode #69 - Sqrt(x) / Floor of Square Root
    // Find largest integer r such that r*r <= n. Binary search on the answer.
    public class FloorSqrt
    {
        public int Solve(int n)
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
    }
}
