#include <iostream>
using namespace std;

bool isBadVersion(int n) {
    return n % 2 == 0;
}

int firstBadVersion(int n) {
    int l = 1, h = n, m = 0;
    while (l < h) {
        m = l + (h - l) / 2;
        if (isBadVersion(m)) h = m;
        else l = m + 1;
    }
    return h;
}

int firstBadVersion2(int n) {
    while (n > 0) {
        if (isBadVersion(n)) n--;
        else break;
    }
    return n + 1;
}
