class BinaryGap
{
    public int Solution(int n)
    {
        int lg = 0, gg = 0, pn = 0;

        do
        {
            if (n % 2 == 1)
            {
                if (pn == 1 && lg > gg) gg = lg;
                lg = 0;
                pn = 1;
            }
            else if (pn == 1) lg++;

            n = n / 2;
        } while (n > 0);

        return gg;
    }
}