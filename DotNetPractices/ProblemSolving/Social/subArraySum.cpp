#include <iostream>

void getIndex(int a[101], int n, int s)
{
    int l = 1;
    int h = -1;
    int cs = 0;
    for (int i = 1; i <= n; i++)
    {
        cs += a[i];
        while (cs > s)
        {
            cs -= a[l];
            l++;
        }

        if (cs == s)
        {
            h = i;
            break;
        }
    }

    if (h > 0)
        cout << l << " ";

    cout << h;
    cout << endl;
}