using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewCoding.ThreadTest
{
    internal class CastSmaple
    {
        List<string> tests = ["1","2","3"];

        List<int> val = [1,2,3];

        public CastSmaple()
        {
            var newTests = tests.Cast<int>();
            var newVal = val.Cast<bool>();
        }
    }
}
