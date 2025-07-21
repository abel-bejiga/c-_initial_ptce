namespace LuckyInteger
{
    public static class Solution
    {

        // NOT COMPLETE
        public static int FindLucky(int[] arr)
        {
            int frequency = 1;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i - 1; i < arr.Length; j++)
                {
                    if (i < 0 && arr[i] == arr[j])
                    {
                        Console.WriteLine(arr[i] + " " + arr[j]);
                        frequency++;
                    }
                    else
                    {
                        return -1;
                    }

                }
            }



            return frequency;
        }
    }
}
