namespace InterviewCoding.ThreadTest
{
    public class RefOutHelper
    {
        public RefOutHelper()
        {
            // No initialization will give error
            //int myRefNumber;
            int myRefNumber = 5;
            Console.WriteLine($"Before ModifyRefValue: {myRefNumber}");
            ModifyRefValue(ref myRefNumber);
            Console.WriteLine($"After ModifyRefValue: {myRefNumber}");

            Console.WriteLine("\n---");

            // Example with 'out'
            // No initialization required
            int myOutResult;
            // ERROR: Use of unassigned local variable
            //Console.WriteLine($"Before AssignOutValue: {myOutResult}");
            AssignOutValue(out myOutResult);
            Console.WriteLine($"After AssignOutValue: {myOutResult}");

        }

        public static void ModifyRefValue(ref int number)
        {
            Console.WriteLine($"Inside Calling (before modification): {number}"); // Can read initial value
            number += 10; // Modify the original variable
            Console.WriteLine($"Inside Calling (after modification): {number}");
        }

        // Method using 'out' parameter
        public static void AssignOutValue(out int result)
        {
            // ERROR: Cannot read unassigned 'out' parameter
            // Console.WriteLine($"Inside AssignOutValue: {result}");
            //result += 25; // Must assign a value before returning
            result = 25; // Must assign a value before returning
            Console.WriteLine($"Inside Calling: {result}");
        }
    }
}
