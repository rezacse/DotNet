namespace Programming.LeetCode.July
{
    public class HammingDistance
    {
        public int GetDistance(int x, int y)
        {
            var n = x ^ y;

            int d = 0;
            while (n > 0)
            {
                d += n & 1;
                n >>= 1;
            }
            return d;
        }
    }
}
