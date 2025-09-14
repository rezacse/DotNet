//100%
#include <string.h>


int permCheck(int A[], int N) {
    int v;
    char b[N];
    memset(b, 0, N);

    for(int i=0; i<N; i++) {
        v = A[i];
        if(v>N || b[v-1]=='0') return 0;
        b[v-1] = '0';
    }

    return 1;
}

//83%: [9, 5, 7, 3, 2, 7, 3, 1, 10, 8]
//int permCheck(int A[], int N) {
//    int i,r = A[0] - N;
//    for(i=1; i<N; i++) {
//        if(A[i]>N || A[i]==A[i-1]) break;
//        r += A[i] - (N-i);
//    }
//
//    return i==N && r == 0 ? 1 : 0;
//}
