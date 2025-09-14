namespace Programming.Sorting
{
    internal class QuickSort
    {
        public int[] Solution(int[] nums)
        {
            Sort(nums, 0, nums.Length - 1);

            return nums;
        }


        private void Sort(int[] nums, int low, int high)
        {

            if (low > high) return;

            int pi = Partition(nums, low, high);

            Sort(nums, low, pi - 1);
            Sort(nums, pi + 1, high);
        }

        private int Partition(int[] nums, int low, int high)
        {
            var pivot = nums[high];

            int i = low - 1;
            for (int j = low; j < high; j++)
            {
                if (nums[j] < pivot)
                {
                    i++;
                    Swap(nums, i, j);
                }
            }

            Swap(nums, i + 1, high);

            return i + 1;
        }


        public void Swap(int[] nums, int i, int j)
        {
            (nums[j], nums[i]) = (nums[i], nums[j]);
        }
    }


}
