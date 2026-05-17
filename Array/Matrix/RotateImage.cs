namespace DSAAdvance.Array.Matrix
{
    // LeetCode #48 - Rotate Image
    // Rotate an n x n 2D matrix by 90 degrees (clockwise), in place.
    public class RotateImage
    {
        // Using an auxiliary copy - Time O(n^2), Space O(n^2)
        // Note: Optimal solution is transpose + reverse each row (O(1) space).
        public void Solve(int[][] matrix)
        {
            int R = matrix.Length, C = matrix[0].Length;
            int[][] tem = new int[R][];
            if (matrix.Length == 0) return;
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
    }
}
