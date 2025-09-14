namespace Programming.LeetCode.July
{
    public class SingleNumber3
    {
        public int[] SingleNumber(int[] nums)
        {
            var r = 0;
            for (int i = 0; i < nums.Length; i++)
                r ^= nums[i];

            int m = r ^ (r & (r - 1));

            var results = new int[2];
            for (int i = 0; i < nums.Length; i++)
            {
                if ((nums[i] & m) == 0) results[0] ^= nums[i];
                else results[1] ^= nums[i];
            }


            return results;
        }
    }
}
