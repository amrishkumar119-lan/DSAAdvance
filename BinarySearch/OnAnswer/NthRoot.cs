namespace DSAAdvance.BinarySearch.OnAnswer
{
    // GFG - Find Nth Root of a Number
    // Find r such that r^N = M (return -1 if no integer root exists).
    // Binary search on the answer (root value).
    public class NthRoot
    {
        public int Solve(int N, int M)
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
                if (ans == M) return mid;
                if (ans > M) high = mid - 1;
                else low = mid + 1;
            }
            return -1;
        }

        // Fast exponentiation helper - returns:
        // 0 if mid^N == M, 1 if mid^N < M, 2 if mid^N > M (overflow)
        public int FindRoot(int mid, int N, int M)
        {
            int val = mid, ans = 1;
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
            if (ans == M) return 0;
            return 1;
        }

        // --- Earlier attempts kept for reference ---
        //public int SolveV1(int N, int M)
        //{
        //    int low = 1, high = M;
        //    while (low <= high)
        //    {
        //        int mid = (high + low) / 2;
        //        int em = FindRoot(mid, N, M);
        //        if (em == 0) return mid;
        //        if (em == 2) high = mid - 1;
        //        else low = mid + 1;
        //    }
        //    return -1;
        //}
    }
}
