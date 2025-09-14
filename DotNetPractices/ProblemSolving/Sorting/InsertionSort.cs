namespace Programming.Sorting
{
    internal class InsertionSort
    {
        public void Solution(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                var sv = arr[i];
                var j = i - 1;
                while (j >= 0 && arr[j] > sv)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = sv;

                //if(sv != i) (arr[i], arr[sv]) = (arr[sv], arr[i]);
            }
        }
    }
}
