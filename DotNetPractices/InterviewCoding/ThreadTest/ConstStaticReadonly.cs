namespace InterviewCoding.ThreadTest
{
    public class ConstStaticReadonly
    {
        public const int test = 0;
        public const string ConstVal = "";
        //public const List<string> Languages  = new List<string> { "" };
        public static string StaticVal;
        public readonly static string RStaticVal;
        private protected string Content { get; set; } = string.Empty;


        public readonly string ReadonlyVal;
        static ConstStaticReadonly()
        {
            StaticVal = "Static Value";
            RStaticVal = "R Static Value";
            Console.WriteLine($"StaticVal: {StaticVal}");
        }

        public static int counter;
        public string Props = "";
        public ConstStaticReadonly()
        {
            StaticVal = "Static Value";
            //RStaticVal = "R Static Value";
            counter++;
            Props = $"static: {counter}";
            Console.WriteLine($"Counter: {counter}");
        }

        public ConstStaticReadonly(string content)
        {
            //ConstVal = "Test";
            ReadonlyVal = content;
        }
    }

    public class SealedClass : ConstStaticReadonly
    {

        public SealedClass(): base("seal class")
        {
        }
        //public void SetContent(string content)
        //{
        //    Content = content;
        //}

        public void SetContent(string content)
        {
            Content = content;
        }
    }


}
