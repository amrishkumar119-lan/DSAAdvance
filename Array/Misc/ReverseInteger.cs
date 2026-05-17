namespace DSAAdvance.Array.Misc
{
    // LeetCode #7 - Reverse Integer
    // Reverse digits of a 32-bit signed integer. Return 0 on overflow.
    public class ReverseInteger
    {
        public int Solve(int x)
        {
            bool isTrue = x < 0;
            char[] chr = System.Math.Abs(x).ToString().ToCharArray();
            string str = string.Empty;
            for (int i = chr.Length - 1; i >= 0; i--)
            {
                str += chr[i].ToString();
            }
            long kk = long.Parse(str);
            if (kk > int.MaxValue)
            {
                return 0;
            }
            return (isTrue ? -(int)kk : (int)kk);
        }
    }
}
