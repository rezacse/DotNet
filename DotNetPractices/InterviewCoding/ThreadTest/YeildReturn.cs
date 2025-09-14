using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewCoding.ThreadTest
{
    public class YeildReturn
    {
        public static IEnumerable<int> GetEvenNumbers(int limit)
        {
            for (int i = 0; i <= limit; i += 2)
            {
                yield return i; // Yields an even number and pauses execution
            }
        }
    }
}
