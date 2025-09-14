using System.Collections.Generic;
class Distinct
{
    public int Solution(int[] A)
    {
        int d = 0;
        var dicts = new HashSet<int>();
        foreach (var item in A)
        {
            if (!dicts.Contains(item))
            {
                dicts.Add(item);
                d++;
            }

        }

        return d;
    }
}