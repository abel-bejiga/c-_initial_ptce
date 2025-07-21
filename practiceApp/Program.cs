using System;
using TwoSum; // ✅ import the correct namespace

namespace test
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] result = Solution.TwoSum(new int[] { 2, 7, 11, 15 }, 9);
            Console.WriteLine($"{result[0]}, {result[1]}");
        }
    }
}
