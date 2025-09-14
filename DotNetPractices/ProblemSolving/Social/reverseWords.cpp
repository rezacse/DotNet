#include <iostream>

using namespace std;

string takeWord(string s, int i, int j)
{
    string t="";
    while(i <= j)                
    {
        t +=s[i];
        i++;
    }
    return t;
}

string reverseWords(string s)
{
    string o = "";
    int lastIndex = s.length() - 1;
    for (int i = lastIndex; i >= 0; i--)
    {
        if(s[i]=='.' || i==0)
        {
            o += takeWord(s, i+1, lastIndex);
            o += '.';
            lastIndex = i-1;
        }
        else if()
        {
            o += takeWord(s, 0, lastIndex);
            lastIndex = i-1;
        }
    }
    return o;
}
