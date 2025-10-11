namespace ProblemSolving.LeetCode.InProgress;
public class RemoveDuplicate
{
    public int SortedArrayII(int[] nums)
    {
        int k = 0, p = nums[0], c = 1;
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] != p)
            {
                nums[++k] = nums[i];
                c = 1;
                p = nums[i];
            }
            else
            {
                nums[k + 1] = nums[i];
                c++;
            }

            if (c == 2) k++;
        }

        nums[k] = p;

        return k + 1;
    }
}
