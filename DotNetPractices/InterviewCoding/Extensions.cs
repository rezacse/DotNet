namespace InterviewCoding
{
    public static class Extensions
    {
        public static DateTime PreviousWeekday(this DateTime dateTime, DayOfWeek dayOfWeek)
        {
            var dayToSubstract = ((int)dateTime.DayOfWeek - (int)dayOfWeek + 7) % 7;
            if (dayToSubstract == 0) dayToSubstract = 7;
            return dateTime.AddDays(-dayToSubstract);
        }

        public static DateTime NextWeekday(this DateTime dateTime, DayOfWeek dayOfWeek)
        {
            // The (... + 7) % 7 ensures we end up with a value in the range [0, 6]
            int daysToAdd = ((int)dayOfWeek - (int)dateTime.DayOfWeek + 7) % 7;
            if (daysToAdd == 0) daysToAdd = 7;
            return dateTime.AddDays(daysToAdd);
        }
    }
}
