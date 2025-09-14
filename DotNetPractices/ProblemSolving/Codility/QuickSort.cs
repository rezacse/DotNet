class QuickSort
{
    void Swap(ref int a, ref int b)
    {
        int t = a;
        a = b;
        b = t;
    }

    int Partition(int[] a, int low, int high)
    {
        int pivot = a[high];
        int l = low;

        for (int i = low; i < high - 1; i++)
        {
            if (a[i] < pivot)
            {
                Swap(ref a[i], ref a[l]);
                l++;
            }
        }
        Swap(ref a[l], ref a[high]);
        return l;
    }


    public void Sort(int[] A, int low, int high)
    {
        while (low < high)
        {
            int pi = Partition(A, low, high);

            Sort(A, low, pi - 1);
            Sort(A, pi + 1, high);
        }
    }
}