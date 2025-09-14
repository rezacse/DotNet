namespace Programming.LeetCode.TopInterviews
{
    public class FindKthLargestSolution
    {

        private int QuickSelect(int[] nums, int li, int ri, int k)
        {
            var pi = li;
            var pivot = nums[ri];
            for(int i = li; i < ri; i++) {
                if (nums[i] <= pivot)
                {
                    (nums[i], nums[pi]) = (nums[pi], nums[i]);
                    pi += 1;
                }
            }
            
            (nums[ri], nums[pi]) = (nums[pi], nums[ri]);

            if (k > pi) QuickSelect(nums, pi + 1, ri, k);
            else if(k < pi) QuickSelect(nums, li, pi - 1, k); 
            return nums[k];
        }

        public int FindKthLargest(int[] nums, int k)
        {
            return QuickSelect(nums, 0, nums.Length - 1, nums.Length - k);

        }
    }
}
