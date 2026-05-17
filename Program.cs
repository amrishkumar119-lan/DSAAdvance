using DSAAdvance.Array.Sum;
using DSAAdvance.Basic;
using DSAAdvance.designPatterns;

namespace DSAAdvance
{
    // Main entry point + scratchpad.
    // Uncomment a block in Main() to test that problem.
    public class Program
    {
        public static void Main(string[] args)
        {
            // === Quick smoke test: Two Sum (LeetCode #1) ===
            int[] nums = { 2, 7, 11, 15 };
            int target = 9;
            int[] result = new TwoSum().Solve(nums, target);
            System.Console.WriteLine($"Two Sum indices: [{result[0]}, {result[1]}]");

            // === Other demos (uncomment to run) ===
            // Basic.Demo();             // Shallow vs Deep Copy demo
            // BasicOops.Demo();         // Interface implementation demo
            // factoryPattern.Demo();    // Factory pattern demo

            // SingletonDemo.Run();      // Singleton pattern (threaded test)

            System.Console.WriteLine("Press any key to exit...");
            System.Console.ReadLine();
        }

        // === Scratchpad: pattern-printing problems ===
        // Uncomment a pattern to see its output. These were used as logic-building exercises.

        //public static void RightTriangle(int n)
        //{
        //    for (int i = 1; i <= n; i++)
        //    {
        //        for (int j = 1; j <= i; j++) Console.Write("*");
        //        Console.WriteLine();
        //    }
        //}

        //public static void InvertedTriangle(int n)
        //{
        //    for (int i = n; i > 0; i--)
        //    {
        //        for (int j = 1; j <= i; j++) Console.Write("*");
        //        Console.WriteLine();
        //    }
        //}

        //public static void Pyramid(int n)
        //{
        //    for (int i = 1; i <= n; i++)
        //    {
        //        for (int k = 1; k <= n - i; k++) Console.Write(" ");
        //        for (int j = 1; j <= i + i - 1; j++) Console.Write("*");
        //        Console.WriteLine();
        //    }
        //}

        //public static void Diamond(int n)
        //{
        //    // Top half
        //    for (int i = 1; i <= n; i++)
        //    {
        //        for (int j = 1; j <= n - i; j++) Console.Write(" ");
        //        for (int j = 1; j <= i + i - 1; j++) Console.Write("*");
        //        Console.WriteLine();
        //    }
        //    // Bottom half
        //    for (int i = n - 1; i > 0; i--)
        //    {
        //        for (int j = 1; j <= n - i; j++) Console.Write(" ");
        //        for (int j = 1; j <= i + i - 1; j++) Console.Write("*");
        //        Console.WriteLine();
        //    }
        //}

        // === Function composition (functional programming exercise) ===
        // Given a list of functions, return a single function that applies them right-to-left.
        //public static System.Func<int, int> Compose(System.Collections.Generic.List<System.Func<int, int>> funcs)
        //{
        //    return (int x) =>
        //    {
        //        for (int i = funcs.Count - 1; i >= 0; i--)
        //        {
        //            x = funcs[i](x);
        //        }
        //        return x;
        //    };
        //}
    }
}
