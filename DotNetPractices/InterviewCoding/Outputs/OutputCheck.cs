namespace InterviewCoding.Outputs
{
    public class OutputCheck
    {
        public async Task RunAsync()
        {
            Console.WriteLine("Start");
            var task = DoWork();
            Console.WriteLine("Middle");
            await task;
            Console.WriteLine("End");
        }

        private async Task DoWork()
        {
            await Task.Delay(1000);
            Console.WriteLine("Work Done");
        }
    }


    public class ObjectCheck
    {
        public void CheckStrObject()
        {
            String s1 = new String("hello");
            String s2 = new String("he" + "llo");
            Console.WriteLine(object.ReferenceEquals(s1, s2));
            Console.WriteLine(s1 == s2);
            Console.WriteLine(s1.Equals(s2));


            String s3 = "hello";
            String s4 = "he" + "llo";
            Console.WriteLine(object.ReferenceEquals(s3, s4));
            Console.WriteLine(s3 == s4);
            Console.WriteLine(s3.Equals(s4));
        }
    }

    public class BoxUnbox
    {

        public void Box()
        {
            int x = 10;
            object obj = x;
            x = 20;
            Console.WriteLine(obj);
        }

        public void Unbox()
        {
            object x = 10;
            int obj = (int)x;
            x = 20;
            Console.WriteLine(obj);
        }
    }


    public class ActionTest
    {

        public void TestAction()
        {
            var actions = new List<Action>();
            for (int i = 0; i < 3; i++)
            {
                actions.Add(() => Console.WriteLine(i));
            }
            foreach (var action in actions) action();
        }
    }
}
