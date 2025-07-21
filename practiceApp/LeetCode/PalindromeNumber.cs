using System.Text;
namespace PalindromeNumber
{
    public static class Solution
    {

            /*
            
Code
Testcase
Test Result
Test Result
9. Palindrome Number
Solved
Easy
Topics
premium lock icon
Companies
Hint
Given an integer x, return true if x is a palindrome, and false otherwise.

 

Example 1:

Input: x = 121
Output: true
Explanation: 121 reads as 121 from left to right and from right to left.
Example 2:

Input: x = -121
Output: false
Explanation: From left to right, it reads -121. From right to left, it becomes 121-. Therefore it is not a palindrome.
Example 3:

Input: x = 10
Output: false
Explanation: Reads 01 from right to left. Therefore it is not a palindrome.
 

Constraints:

-231 <= x <= 231 - 1
            */
            public static bool IsPalindrome(int x)
            {
                string input = x.ToString();
                StringBuilder reversed = new StringBuilder();
                for (int i = input.Length - 1; i >= 0; i--)
                {
                    reversed.Append(input[i]);
                }

                return reversed.ToString().ToLower() == input.ToLower();
            }
        }
    }
