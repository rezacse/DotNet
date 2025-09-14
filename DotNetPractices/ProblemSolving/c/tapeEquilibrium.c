#include <stdlib.h>


int tapeEquilibrium(int A[], int N) {
    int s = 0;
    for(int i=0; i<N; i++) {
        s += A[i];
    }

    int m = 100000000, ls =0, d = 0;
    for(int i=0; i<N-1; i++) {
        ls += A[i];
        s -= A[i];
        d = abs(s - ls);
        if(d<m) m = d;
    }

    return m;
}

