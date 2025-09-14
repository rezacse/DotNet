#include <stdio.h>
#include <stdlib.h>
#include <string.h>


//int mx = l>m ? l>n ? l : n>m ? n : m: m>n ? m : n;
//int mn = l<m ? l<n ? l : n<m ? n : m: m<n ? m : n;
//    for(int i=0; i< 3; i++) {
//        for(int j=i+1;j<3;j++){
//            if(b[i]>b[j]) {
//                int t = b[i];
//                b[i] = b[j];
//                b[j] = t;
//            }
//        }
//    }

int distinct(int A[], int N) {
    int b[5] = {1001, 1001, -1001, -1001, -1001};
    for(int i=0; i<N; i++) {
        if(A[i]>b[4]) {
            b[2] = b[3];
            b[3] = b[4];
            b[4] = A[i];
        } else if(A[i]>b[3]) {
            b[2] = b[3];
            b[3] = A[i];
        } else if(A[i]>b[2]) {
            b[2] = A[i];
        }

        if(A[i]<b[0]) {
            b[1] = b[0];
            b[0] = A[i];
        } else if(A[i]<b[1]) {
            b[1] = A[i];
        }
    }

    int l = b[0]*b[1]*b[4];
    int m = b[2]*b[3]*b[4];

    return l > m ? l : m;
}

int main(int argc, char** argv) {

    int a[] = {-4,-2,-5, 1};
    int l = sizeof(a)/sizeof(a[0]);

    printf("%d ", distinct(a, l));

    //printf("%d ", maxIn3(a[0], a[1], a[2]));

//    int a[100000];// = {9, 5, 7, 3, 2, 7, 3, 1, 10, 8};
//    for(int i=0;i<100000;i++) {
//        a[i] = i%2;
//    }

    return 0;
}

void print(int a[], int n) {
     for(int i = 0; i < n; i++) {
        printf("%d ", a[i]);
    }
}

