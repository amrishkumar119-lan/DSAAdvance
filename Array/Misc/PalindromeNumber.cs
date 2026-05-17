namespace DSAAdvance.Array.Misc
{
    // LeetCode #9 - Palindrome Number
    // Determine if a number reads the same forward and backward.
    public class PalindromeNumber
    {
        public bool Solve(int x)
        {
            if (x < 0) return false;
            string d = x.ToString();
            int a = 0, b = d.Length - 1;
            while (a < b)
            {
                if (d[a] != d[b]) return false;
                a++; b--;
            }
            return true;
        }
    }
}
