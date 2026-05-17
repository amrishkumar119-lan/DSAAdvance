namespace DSAAdvance.Array.Misc
{
    // Compute nCk (binomial coefficient) - used in Pascal's Triangle problems.
    // Multiplicative formula: nCk = n*(n-1)*...*(n-k+1) / k!
    // Time O(k), Space O(1).
    public class BinomialCoefficient
    {
        public int Solve(int n, int k)
        {
            int res = 1;
            for (int i = 0; i < k; i++)
            {
                res = res * (n - i);
                res = res / (i + 1);
            }
            return res;
        }
    }
}
