using System;

namespace DSAAdvance.Array.Misc
{
    // Logic-building exercise: print numbers from n down to i using recursion.
    // Demonstrates how recursion unwinds (post-order print after the recursive call).
    public class PrintRecursive
    {
        public void Solve(int i, int n)
        {
            if (i > n) return;
            Solve(i + 1, n);
            Console.WriteLine(i);
        }
    }
}
