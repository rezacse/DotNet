namespace InterviewCoding;

public class UtitilityHelper
{

    public int[] ConvertToInt(string orderIDs)
    {
        return orderIDs.Split("O", StringSplitOptions.RemoveEmptyEntries)
                .Select(c => Convert.ToInt32(c)).ToArray();
    }
}
