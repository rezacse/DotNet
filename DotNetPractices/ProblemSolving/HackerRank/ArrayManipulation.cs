namespace Programming.HackerRank
{
    public class ArrayManipulation
    {
        public long Solution(int n, int[][] queries)
        {
            var a = new long[n];
            for (int i = 0; i < queries.Length; i++)
            {
                a[queries[i][0] - 1] += queries[i][2];
                if (queries[i][1] < n) a[queries[i][1]] -= queries[i][2];
            }

            long m = 0, x = 0;
            for (int i = 0; i < n; i++)
            {
                x += a[i];
                if (x > m) m = x;
            }

            return m;

        }
    }
}
