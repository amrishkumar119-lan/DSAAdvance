using System.Collections.Generic;

namespace DSAAdvance.Array.Matrix
{
    // LeetCode #54 - Spiral Matrix
    // Given an m x n matrix, return all elements in spiral order (clockwise).
    public class SpiralMatrix
    {
        // Final clean version - Time O(m*n), Space O(1) (excluding output)
        public List<int> Solve(List<List<int>> matrix)
        {
            List<int> lst = new List<int>();
            int c = matrix.Count - 1, r = matrix[0].Count - 1;
            int top = 0, bottom = 0;
            while (top <= c && bottom <= r)
            {
                for (int i = top; i <= r; i++) { lst.Add(matrix[top][i]); }
                top++;
                for (int i = top; i <= c; i++) { lst.Add(matrix[i][r]); }
                r--;
                if (r >= top)
                {
                    for (int i = r; i >= bottom; i--) { lst.Add(matrix[c][i]); }
                    c--;
                }
                if (c >= bottom)
                {
                    for (int i = c; i >= top; i--) { lst.Add(matrix[i][bottom]); }
                    bottom++;
                }
            }
            return lst;
        }

        // int[][] version - same logic, different input type
        public IList<int> SolveJagged(int[][] matrix)
        {
            List<int> Lst = new List<int>();
            int c = matrix.Length - 1, r = matrix[0].Length - 1;
            int top = 0, bottom = 0;
            while (c > top && r > bottom)
            {
                for (int i = top; i <= r; i++) { Lst.Add(matrix[top][i]); }
                top++;
                for (int i = top; i <= c; i++) { Lst.Add(matrix[i][r]); }
                r--;
                if (top <= c)
                {
                    for (int i = r; i >= bottom; i--) { Lst.Add(matrix[c][i]); }
                    c--;
                }
                if (bottom <= r)
                {
                    for (int i = c; i >= bottom; i--) { Lst.Add(matrix[bottom][i]); }
                    bottom++;
                }
            }
            return Lst;
        }

        // --- Earlier attempt - kept for reference ---
        //public static List<int> SolveOld(List<List<int>> matrix)
        //{
        //    List<int> Lst = new List<int>();
        //    int c = matrix.Count - 1, r = matrix[0].Count - 1;
        //    int top = 0, bottom = 0;
        //    while (c >= top && r >= bottom)
        //    {
        //        for (int i = top; i <= r; i++) { Lst.Add(matrix[top][i]); }
        //        top++;
        //        for (int i = top; i <= c; i++) { Lst.Add(matrix[i][r]); }
        //        r--;
        //        if (c >= top)
        //        {
        //            for (int i = r; i >= bottom; i--) { Lst.Add(matrix[c][i]); }
        //            c--;
        //        }
        //        if (r >= bottom)
        //        {
        //            for (int i = c; i >= top; i--) { Lst.Add(matrix[bottom][i]); }
        //            bottom++;
        //        }
        //    }
        //    return Lst;
        //}
    }
}
