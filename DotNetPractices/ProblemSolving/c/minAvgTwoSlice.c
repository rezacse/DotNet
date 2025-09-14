int minAvgTwoSlice(int A[], int N) {
    float s2, s3, m = 10001;
    int l = N-2, mi = 0;

    for(int i=0; i<N-1; i++) {
        s2 = (float)(A[i] + A[i+1])/2;
        if(s2<m){
            mi = i;
            m = s2;
        }

        if(i<l){
            s3 = (float)(A[i] + A[i+1] + A[i+2])/3;
            if(s3<m) {
                mi = i;
                m = s3;
            }
        }
    }

    return mi;
}
