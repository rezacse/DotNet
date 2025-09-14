using System;

namespace Programming.Sorting
{
    internal class HeapSort
    {
        private void Heapify(int[] arr, int n, int i)
        {
            // Initialize largest as root
            int largest = i;

            // left index = 2*i + 1
            int l = 2 * i + 1;

            // right index = 2*i + 2
            int r = 2 * i + 2;

            // If left child is larger than root
            if (l < n && arr[l] > arr[largest])
            {
                largest = l;
            }

            // If right child is larger than largest so far
            if (r < n && arr[r] > arr[largest])
            {
                largest = r;
            }

            // If largest is not root
            if (largest != i)
            {
                (arr[largest], arr[i]) = (arr[i], arr[largest]);
                Heapify(arr, n, largest);
            }
        }

        private void HeapSortArray(int[] arr)
        {
            int n = arr.Length;

            // Build heap (rearrange array)
            for (int i = n / 2 - 1; i >= 0; i--)
                Heapify(arr, n, i);

            // One by one extract an element from heap
            for (int i = n - 1; i > 0; i--)
            {
                (arr[i], arr[0]) = (arr[0], arr[i]);

                // Call max heapify on the reduced heap
                Heapify(arr, i, 0);
            }
        }

        private void PrintArray(int[] arr)
        {
            foreach (int value in arr)
            {
                Console.Write(value + " ");
            }
            Console.WriteLine();
        }

        // Driver's code
        public void Solution(int[] arr)
        {
            //int[] arr = { 9, 4, 3, 8, 10, 2, 5 };
            HeapSortArray(arr);
            Console.WriteLine("Sorted array is ");
            PrintArray(arr);
        }
    }
}
