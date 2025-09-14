int unpairedNumber(int A[], int N) {
    // write your code in C99 (gcc 6.2.0)
    int n = 0;
    int ml = N/2;
    for(int i = 0; i<ml; i++) {
        n = n^A[i]^A[N-i-1];
    }

    n = n^A[ml];

    return n;
}

