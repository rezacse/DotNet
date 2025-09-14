using System;

namespace InterviewCoding
{
    public class DateTimeHelper
    {
        public DateTime GetPayoutDate(DateTime date)
        {
            //var today = DateTime.UtcNow;
            var nextSunday = date.NextWeekday(DayOfWeek.Monday);
            var nextThursday = date.NextWeekday(DayOfWeek.Thursday);
            if (nextSunday < nextThursday) return nextThursday;
            return nextThursday.NextWeekday(DayOfWeek.Thursday);
        }
    }

}
