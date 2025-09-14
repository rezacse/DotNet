

//int * cyclicRotation(int A[], int N, int K) {
//
//    if(N==K || K==0) {
//        print(A, N);
//        return A;
//    }
//
//    int v = 0;
//    int ti, t, tt;
//
//    t = A[0];
//    for(int i = 0; v < N; ) {
//
//        ti = i + K;
//        if(ti >= N) ti = ti%N;
//
//        tt = A[ti];
//        A[ti] = t;
//        t = tt;
//
//        i = ti;
//        v++;
//    }
//
//    print(A, N);
//
//    return A;
//}

int * cyclicRotation(int A[], int N, int K) {

    if(N==K || K==0) return A;

    int k = K>N ? K%N : K;
    int t;
    for(int i = 0; i < k; i++){
        t = A[N-1];
        for(int j = N-1; j >0 ; j--) {
            A[j] = A[j-1];
        }
        A[0] = t;
    }

    print(A, N);

    return A;
}
