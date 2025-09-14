#include <iostream>
#include <vector>
using namespace std;

long repeatedString(string s, long n) {
    int noOfa = 0, sLen = s.length();
    for (int i = 0; i < sLen; i++)
        if (s[i] == 'a') noOfa++;

    noOfa = (n / sLen) * noOfa;
    int r = n % sLen;
    for (int i = 0; i < r; i++)
        if (s[i] == 'a') noOfa++;

    return noOfa;
}