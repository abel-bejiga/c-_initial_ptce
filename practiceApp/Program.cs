
namespace test
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] result = TwoSum.Solution.TwoSum(new int[] { 2, 7, 11, 15 }, 9);
            Console.WriteLine($"{result[0]}, {result[1]}");
            bool palindromeResult = PalindromeNumber.Solution.IsPalindrome(123124);
            Console.WriteLine(palindromeResult);

        }
    }
}
