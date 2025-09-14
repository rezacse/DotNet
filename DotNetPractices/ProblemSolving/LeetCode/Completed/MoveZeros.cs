namespace Programming.LeetCode
{
    public class MoveZeros
    {

        public int[] Move(int[] nums)
        {
            int ix = nums.Length;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                {
                    ix = i;
                    break;
                }
            }

            for (int i = ix; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    nums[ix] = nums[i];
                    ix += 1;
                }
            }

            for (int i = ix; i < nums.Length; i++)
                nums[i] = 0;

            return nums;
        }
    }
}
