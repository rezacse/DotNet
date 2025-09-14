#include <iostream>
using namespace std;

int compare(const void * a, const void * b)
{
	return (*(char*)a - *(char*)b);
}

void swap(char *a, char *b)
{
    char t = *a;
    *a = *b;
    *b = t;
}

void permutaions(char *s, int l, int r)
{
    if(l==r)
    {
        cout<< s << " ";
    }
    else 
    {
        for(int i=l;i<=r;i++)
        {
            swap(s+l, s+i);
            permutaions(s, l+1, r);
            swap(s+l, s+i);
        }
    }
}