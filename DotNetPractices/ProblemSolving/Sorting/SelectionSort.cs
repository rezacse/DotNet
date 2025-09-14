namespace Programming.Sorting
{
    internal class SelectionSort
    {
        public void Solution(int[] arr)
        {
            for (var i = 0; i < arr.Length; i++)
            {
                var mi = i;
                for (var j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[mi]) mi = j;
                }

                if (mi != i)
                {
                    (arr[i], arr[mi]) = (arr[mi], arr[i]);
                }
            }
        }
    }
}
