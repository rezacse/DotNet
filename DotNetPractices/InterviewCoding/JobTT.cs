using System;

namespace InterviewCoding;
public class JobTT
{
    public bool IsBalanced(int[] a)
    {
        int li = 0, ri = a.Length - 1;
        int ls = a[li], rs = a[ri], ms = 0;
        while (li < ri)
        {
            if (ls < rs) ls += a[++li];
            else if (ls > rs) rs += a[--ri];
            //else 

            //if (ls == rs && ls == ms) return true;
            if (ls == rs)
            {
                ms = Sum(a, li + 2, ri - 2);
                //ms = Sum(a, li + 1, ri - 1);
                if (ls == ms) return true;
                li++;
                ri--;
            }
        }
        return false;
    }


    private static int Sum(int[] a, int i, int j)
    {
        int s = 0;
        for (int k = i; k <= j; k++) s += a[k];
        return s;
    }

    public string Matrix(int u, int l, int[] a)
    {
        string us = "", ls = "";

        int s = 0;
        foreach (var item in a) s += item;

        if (s != u + l) return "IMPOSSIBLE";

        for (int i = 0; i < a.Length; i++)
        {
            //var sm = u > l ? u : l;
            if (u >= l && u > 0 && a[i] > 0)
            {
                us = $"{us}1";
                a[i]--;
                u--;
            }
            else us = $"{us}0";

            if (l > 0 && a[i] > 0)
            {
                ls = $"{ls}1";
                a[i]--;
                l--;
            }
            else ls = $"{ls}0";
        }
        return $"{us},{ls}";
    }

    public int[] LatticePoint(int Ax, int Ay, int Bx, int By) {
        // Move A to Origin
        var Cx = Bx - Ax;
        var Cy = By - Ay;
        // Rotate by 90 degree clockwise
        var Rx = Cy;
        var Ry = -Cx;
        // Normalize
        var norm = Gcd(Math.Abs(Rx), Math.Abs(Ry));
        var Nx = Rx / norm;
        var Ny = Ry / norm;
        return [Bx + Nx, By + Ny];
    }

    private static int Gcd(int a, int b) {
        if (b == 0) return a;

        return Gcd(b, a % b);
    }


    public string[] Allocation(string S, string[] B)
    {
        List<(decimal, int)> arrs = [];
        decimal sum = 0.00M;
        for (int i = 0; i < B.Length; i++) {
            decimal val = decimal.Parse(B[i]);
            arrs.Add((val, i));
            sum += val;
        }

        //arrs.Sort((a, b) => a.Item1.CompareTo(b.Item1));

        string[] res = new string[B.Length];
        decimal s = decimal.Parse(S);
        foreach (var item in arrs.OrderByDescending(i => i.Item1).ThenBy(i=>i.Item2))
        {
            if (sum == 0) res[item.Item2] = "0.00";
            else
            {
                decimal alloc = Math.Floor((s * item.Item1 / sum) * 100) / 100;
                res[item.Item2] = alloc.ToString("0.00");
                sum -= item.Item1;
                s -= alloc;
            }
        }

        return res;
    }


}
