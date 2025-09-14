
class MissingInteger
{
    public int Solution(int[] A)
    {
        int v, c = 0, l = A.Length;
        var b = new bool[l];

        for (int i = 0; i < l; i++)
        {
            v = A[i];
            if (v > 0 && v <= l && b[v - 1])
            {
                b[v - 1] = true;
                c++;
            }
        }

        int j = 0;
        for (; j < c; j++)
        {
            if (!b[j]) return j + 1;
        }

        return j == c ? j + 1 : 1;
    }

}

