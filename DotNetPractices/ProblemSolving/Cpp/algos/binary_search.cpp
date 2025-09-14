#include <iostream>
#include <vector>
using namespace std;

int binarySearch(vector<int> v, int t) {
    int l = 0, h = v.size() - 1, m = 0;
    while (l <= h) {
        m = (l + h) / 2;
        if (v[m] == t) return m;
        else if (t < v[m]) h = m - 1;
        else l = m + 1;
    }
    return -1;
}