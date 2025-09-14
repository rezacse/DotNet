namespace Programming.HackerRank
{
    public class CountingValleys
    {
        public int Solution(int[] arr)
        {
            int m = 0, i = 0;

            while (i < arr.Length)
            {
                if (arr[i] != i + 1)
                {
                    int t = arr[i];
                    arr[i] = arr[t - 1];
                    arr[t - 1] = t;
                    m++;
                }
                else i++;
            }


            return m;
        }
    }
}
