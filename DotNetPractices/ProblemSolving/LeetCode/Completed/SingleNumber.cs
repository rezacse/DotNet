namespace Programming.LeetCode
{
    public class SingleNumber
    {
        public SingleNumber()
        {

        }


        public int GetSingleNumber(int[] nums)
        {
            int sNum = 0;
            foreach (var num in nums)
            {
                sNum ^= num;
            }

            return sNum;
        }
    }
}
