using System;

namespace Programming.Sorting
{
    internal class MergeSort
    {

        public MergeSort(int[] arr) {
            var newArr = new int[arr.Length];
            Sort(arr, 0, arr.Length - 1, newArr);
        }

        private void Sort(int[] arr, int li, int hi, int[] newArr)
        {
            if (li >= hi) return;

            int mi = (li + hi) / 2;

            Sort(arr, li, mi, newArr);
            Sort(arr, mi + 1, hi, newArr);

            Merge(arr, li, mi, hi, newArr);

        }

        private void Merge(int[] arr, int li, int mi, int hi, int[] tArr)
        {
            int s1 = li, ll = mi - li + 1;
            int s2 = mi + 1, rl = hi - mi;

            for (int ti = 0; ti < ll; ti++) tArr[s1 + ti] = arr[s1 + ti];

            for (int ti = 0; ti < rl; ti++) tArr[s2 + ti] = arr[s2 + ti];

            int i = 0, j = 0, k = li;
            while (i < ll && j < rl)
            {
                if (tArr[s1 + i] <= tArr[s2 + j])
                {
                    arr[k] = tArr[s1 + i];
                    i++;
                }
                else
                {
                    arr[k] = tArr[s2 + j];
                    j++;
                }
                k++;
            }

            while (i < ll)
            {
                arr[k] = tArr[s1 + i];
                i += 1;
                k += 1;
            }

            while (j < rl)
            {
                arr[k] = tArr[s2 + j];
                j += 1;
                k += 1;
            }
        }
    }
}
