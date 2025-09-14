#include <iostream>
#include <vector>
using namespace std;


int flatlandSpaceStations(int n, vector<int> c) {
    bool* v = new bool[n] {false};
    for (int i = 0; i < c.size(); i++)
        v[c[i]] = true;

    int li = -1, lm = 0, m = 0;
    for (int i = 0; i < n; i++)
    {
        if (v[i] == 0) lm = i - li;
        else {
            lm = li > -1 ? lm / 2 + lm % 2 : i;
            if (lm > m) m = lm;
            lm = 0;
            li = i;
        }
    }
    if (lm > m) m = lm;


    delete[] v;
    v = NULL;
    return m;
}
