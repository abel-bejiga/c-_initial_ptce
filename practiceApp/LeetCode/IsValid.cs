

namespace IsValid
{
    public static class Solution
    {
        public static bool IsValid(string word)
        {
            if (word.Length < 3) return false;
            foreach (char letter in word)
            {
                if (!char.IsLetterOrDigit(letter)) return false;
            }

            string vowels = "aeiouAEIOU";
            bool hasVowel = false;
            bool hasConsonant = false;

            foreach (char letter in word)
            {
                if (char.IsLetter(letter))
                {
                    if (vowels.Contains(letter))
                    {
                        hasVowel = true;
                    }
                    else
                    {
                        hasConsonant = true;
                    }
                }

            }
            return hasVowel && hasConsonant;
        }
    }
}