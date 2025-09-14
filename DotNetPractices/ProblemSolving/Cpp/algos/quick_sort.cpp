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


void print(vector<int> v) {
    for (int i = 0; i < v.size(); i++)
        cout << v[i] << " ";
}


int main()
{
    string s;

    vector<int> v;
    v.push_back(5);
    v.push_back(2);
    v.push_back(3);
    v.push_back(6);
    v.push_back(1);
    v.push_back(2);
    v.push_back(4);

    sort(v, 0, v.size() - 1);
    print(v);

    return 0;
}
