#include <string.h>

int frogRiverOne(int X, int A[], int N) {
    int c=0, v;
    char b[X];
    memset(b, 0, X);

    for(int i=0;  i<N; i++) {
        v = A[i];
        if(v <= X && b[v-1] != '1' ) {
            b[v-1] = '1';
            c++;
            if(c==X) return i;
        }
    }

    return -1;
}
