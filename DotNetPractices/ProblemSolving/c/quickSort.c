
void swap(int *a, int *b) {
    int t = *a;
    *a = *b;
    *b = t;
}

int partition(int a[], int low, int high) {
    int pivot = a[high];
    int l = low;

    for(int i=low;i<high-1;i++) {
        if(a[i]<pivot) {
            swap(&a[i], &a[l]);
            l++;
        }
    }
    swap(&a[l], &a[high]);
    return l;
}


void quickSort(int a[], int low, int high) {
    while(low<high) {
        int pi = partition(a, low, high);

        quickSort(a, low, pi-1);
        quickSort(a, pi+1, high);
    }
}
