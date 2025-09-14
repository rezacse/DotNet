#include <iostream>
#include <vector>
using namespace std;

void swap(int* a, int* b) {
    int t = *a;
    *a = *b;
    *b = t;
}

int partition(vector<int>& v, int l, int h) {
    int pivot = v[h];
    int i = l;

    for (int j = l; j < h; j++)
    {
        if (v[j] < pivot) swap(&v[i++], &v[j]);
    }

    swap(&v[i], &v[h]);

    return i;
}

void sort(vector<int>& v, int l, int h) {
    if (l < h) {
        int p = partition(v, l, h);
        sort(v, l, p - 1);
        sort(v, p + 1, h);
    }
}

int abs(int a, int b) {
    return a > b ? a - b : b - a;
}

int minimumAbsoluteDifference(vector<int> arr) {
    sort(arr, 0, arr.size() - 1);

    int gd = 2000000001, ld = 0;
    for (int i = 1; i < arr.size(); i++)
    {
        ld = abs(arr[i - 1], arr[i]);
        if (ld < gd) gd = ld;
    }
    return gd;
}