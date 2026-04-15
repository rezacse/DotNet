namespace InterviewCoding.ThreadTest
{

    public class Singleton
    {
        // Static field initializer calls instance constructor.
        //public static Singleton instance = new Singleton();
        public const string ConstVal = "Initial";
        public static string StaticVal = "Initial";
        public readonly static string RStaticVal = "Initial";

        //private Singleton()
        //{
        //    Console.WriteLine("Executes before static constructor.");
        //}
        private Singleton()
        {
            StaticVal = "ConstructorSingleton";
            //RStaticVal = "RStaticVal";
            //Console.WriteLine($"Executes Constructor Singleton: ConstVal: {ConstVal}");
            Console.WriteLine($"ConstructorSingleton: ConstVal: {ConstVal}, StaticVal: {StaticVal}, RStaticVal: {RStaticVal}");
        }


        static Singleton()
        {
            StaticVal = "StaticSingleton";
            RStaticVal = "StaticSingleton";
            //Console.WriteLine($"Executes StaticSingleton: ConstVal: {ConstVal}");
            Console.WriteLine($"StaticSingleton: ConstVal: {ConstVal}, StaticVal: {StaticVal}, RStaticVal: {RStaticVal}");
        }

        //public static Singleton Instance => instance;
    }
}
