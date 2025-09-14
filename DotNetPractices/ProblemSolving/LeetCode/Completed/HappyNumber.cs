namespace Programming.LeetCode
{
    public class HappyNumber
    {
        public HappyNumber()
        {

        }


        public bool IsHappy(int n)
        {
            if (n < 1) return false;

            while (n != 1)
            {
                int s = 0;
                while (n != 0)
                {
                    int r = n % 10;
                    n /= 10;
                    s += r * r;
                }
                if (s == 4) return false;
                n = s;
            }

            return true;
        }
    }
}
