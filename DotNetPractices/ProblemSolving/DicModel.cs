using System.Collections.Generic;

namespace Programming
{

    public class Prog
    {
        public DicModel MakeModel()
        {
            var dicObj = new DicModel
            {
                id = "1",
                first_name = "",
                last_name = ""
            };

            var exchanges = new Dictionary<string, List<string>> {
                { "Binance", new List<string>{"a","b" } },
                { "Bitfinex", new List<string>{"a" } },
                { "Equos", new List<string>{"a" } },
            };
            dicObj.exchanges = exchanges;

            return dicObj;

        }
    }

    public class DicModel
    {
        public string id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string email { get; set; }
        public int license_starting { get; set; }
        public int license_ending { get; set; }
        public string license_type { get; set; }
        public Dictionary<string, List<string>> exchanges { get; set; }
    }



}
