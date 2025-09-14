namespace Programming.LeetCode.July
{
    public class UglyNumber2
    {
        public int GetNthUglyNumber(int n)
        {
            int i2 = 0, i3 = 0, i5 = 0;
            var a = new int[n];
            a[0] = 1;

            for (int i = 1; i < n; i++)
            {
                a[i] = Min(a[i2] * 2, Min(a[i3] * 3, a[i5] * 5));
                if (a[i] == a[i2] * 2) i2 += 1;
                if (a[i] == a[i3] * 3) i3 += 1;
                if (a[i] == a[i5] * 5) i5 += 1;
            }

            return a[n - 1];
        }

        private int Min(int a, int b)
        {
            return a < b ? a : b;
        }


        private int NextFactor(int i)
        {
            var t = i;
            while (true)
            {
                while (t % 2 == 0) t /= 2;

                for (int j = 3; j <= 5; j += 2)
                    if (t % j == 0) t /= j;

                if (t <= 5) return t;
                t++;
            }
            //while (true)
            //{
            //    if (i % 2 == 0 || i % 3 == 0 || i % 5 == 0) return i;
            //    i++;
            //}
        }

        //public int GetNthUglyNumber(int n)
        //{
        //    int u = 1, i = 1;
        //    while (u < n)
        //    {
        //        var t = ++i;
        //        while (t % 2 == 0) t /= 2;

        //        for (int j = 3; j <= 5; j += 2)
        //            if (t % j == 0) t /= j;

        //        if (t <= 5) u++;
        //    }

        //    return i;
        //}

        //public int GetNthUglyNumber(int n)
        //{
        //    int u = 1, i = 1;
        //    while (u < n)
        //    {
        //        var t = ++i;
        //        while (true)
        //        {
        //            if (t % 2 == 0) t /= 2;
        //            else if (t % 3 == 0) t /= 3;
        //            else if (t % 5 == 0) t /= 5;
        //            else break;
        //        }
        //        if (t <= 5) u++;
        //    }

        //    return i;
        //}
    }
}
