namespace Programming.Codility
{
    class LoadBalancer
    {
        public bool Solution(int[] A)
        {
            var ls = new int[A.Length];
            ls[0] = A[0];
            for (int i = 1; i < A.Length; i++)
            {
                ls[i] = ls[i - 1] + A[i];
            }

            int b1 = 1, b2 = 3;

            int li = A.Length - 1;
            int f = 0, s = 0, t = 0;

            while (b1 < b2 && b1 < A.Length && b2 < A.Length)
            {
                f = ls[b1] - A[b1];
                s = ls[b2] - A[b2] - ls[b1];
                t = ls[li] - ls[b2];

                if (f < s) b1++;
                else if (f > s) b2++;
                else if (f == t) break;
            }

            return f == s && s == t;
        }
    }
}
