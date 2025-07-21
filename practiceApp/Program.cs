
namespace test
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] result = TwoSum.Solution.TwoSum(new int[] { 2, 7, 11, 15 }, 9);
            // Console.WriteLine($"{result[0]}, {result[1]}");
            bool palindromeResult = PalindromeNumber.Solution.IsPalindrome(123124);
            // Console.WriteLine(palindromeResult);

            string MakeFancyString = DeleteCharatersToMakeFancyString.Solution.DeleteCharatersToMakeFancyString("leeetcode");
            // Console.WriteLine(MakeFancyString);

            bool isValid = IsValid.Solution.IsValid("UuE6");
            // Console.WriteLine(isValid);

            int IsLuckyInteger = LuckyInteger.Solution.FindLucky([1, 2, 2, 3, 3, 3]);
            Console.WriteLine(IsLuckyInteger);
        }
    }
}