#include <string.h>


int missingInteger(int A[], int N) {
    int v,c = 0;
    char b[N];
    memset(b, 0, N);

    for(int i=0; i<N; i++) {
        v = A[i];
        if(v > 0 && v <=N &&  b[v-1] != '1' ) {
            b[v-1] = '1';
            c++;
        }
    }

    int j=0;
    for(; j<c; j++) {
        if(b[j] != '1' ) return j+1;
    }

    return j==c ? j+1 : 1;
}
