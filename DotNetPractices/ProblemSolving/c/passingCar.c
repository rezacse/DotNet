//90%
//int a[100000];
//for(int i=0;i<100000;i++) {
//    a[i] = i%2;
//}
int passingCar(int A[], int N) {

    int l = 0, pz = 0;
    for(int i=0; i<N; i++) {
        if(A[i]==0) {
            l += N - (i+1) - pz;
            pz++;
        }
    }

    return l> 1000000000 ? -1 : l;
}

