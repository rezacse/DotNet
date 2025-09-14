#include <iostream>
#include <string>
#include <vector>
#include <algorithm>

using namespace std;

int customCompare(string a, string b)
{
    string ab = a.append(b);
    string ba = b.append(a);

    return ab>ba?1:0;
}

void printLargestForm(vector<string> v)
{
    sort(v.begin(), v.end(), customCompare);
    for(int i=0;i<v.size();i++)
        cout<<v[i];
}

int main()
{
    int t;
    cin >> t;
    while (t--)
    {
        vector<string> v;
        int n, m;
        cin>>n;
        for(int i=0;i<n;i++)
        {
            cin>>m;
            v.push_back(to_string(m));

        }

        printLargestForm(v);
        cout << endl;
    }

    return 0;
}