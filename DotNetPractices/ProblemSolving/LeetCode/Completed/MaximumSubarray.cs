namespace Programming.LeetCode
{
    public class MaximumSubarray
    {
        public MaximumSubarray()
        {

        }


        public int GetMax(int[] nums)
        {
            int lm = nums[0], gm = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                var m = lm + nums[i];
                lm = m > nums[i] ? m : nums[i];
                if (lm > gm) gm = lm;
            }
            return gm;
        }
    }
}
