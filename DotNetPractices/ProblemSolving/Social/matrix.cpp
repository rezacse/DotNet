#include <iostream>
using namespace std;

void diagonalElement()
{
    cin>>m>>n;
    int** a = new int*[m];
    for(int i=0;i<m;i++)
        a[i] = new int[n];

    for(int i=0;i<m;i++)
        for(int j=0;j<n;j++)
            cin>>a[i][j];

    for(int i=0;i<n;i++)
        cout<< a[i][i]<<" "; 
        
    cout<<endl;

    for(int j=0;j<n;j++)
        cout<< a[m-j-1][j]<<" ";

}