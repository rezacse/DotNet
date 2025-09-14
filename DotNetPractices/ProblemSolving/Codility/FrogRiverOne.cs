
class FrogRiverOne
{
    public int Solution(int X, int[] A)
    {
        int c = 0, v;
        var b = new bool[A.Length];

        for (int i = 0; i < A.Length; i++)
        {
            v = A[i];
            if (v <= X && !b[v - 1])
            {
                b[v - 1] = true;
                c++;
                if (c == X) return i;
            }
        }

        return -1;
    }
}