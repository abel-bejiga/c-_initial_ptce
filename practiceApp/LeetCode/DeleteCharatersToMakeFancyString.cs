using System.Text;
namespace DeleteCharatersToMakeFancyString
{
    public static class Solution
    {
        public static string DeleteCharatersToMakeFancyString(string s)
        {
            int count = 1;
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < s.Length; i++)
            {
                if (i > 0 && s[i] == s[i - 1])
                {
                    count++;
                }
                else
                {
                    count = 1;
                }
                if (count < 3)
                {
                    result.Append(s[i]);
                }
            }

            return result.ToString();
        }
    }
}