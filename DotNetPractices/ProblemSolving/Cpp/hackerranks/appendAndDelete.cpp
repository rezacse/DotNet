#include <iostream>
#include <vector>
using namespace std;

string appendAndDelete(string s, string t, int k)
{
    int sLen = s.length();
    int tLen = t.length();
    int i = 0;
    int l = tLen < sLen ? tLen : sLen;
    for (i = 0; i < l && s[i] == t[i]; i++)
        ;

    int r = sLen + tLen - 2 * i;
    if (r > k)
        return "No";
    if (r % 2 == k % 2)
        return "Yes";
    if (sLen + tLen < k)
        return "Yes";
    return "No";
}