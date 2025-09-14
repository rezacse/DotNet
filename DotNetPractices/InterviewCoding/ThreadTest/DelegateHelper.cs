namespace InterviewCoding.ThreadTest
{

    // 1. Declare a delegate
    public delegate void CalculatorOperation(int a, int b);

    public class Calculator
    {
        // Methods that match the delegate's signature
        public void Add(int x, int y)
        {
            Console.WriteLine($"Sum: {x + y}");
        }

        public static void Subtract(int x, int y) // Static method also works
        {
            Console.WriteLine($"Difference: {x - y}");
        }


    }


    public class DelegateHelper
    {
        public DelegateHelper()
        {
            Calculator calc = new Calculator();

            // 2. Instantiate delegates and assign methods
            CalculatorOperation addOperation = new CalculatorOperation(calc.Add);
            CalculatorOperation subtractOperation = new CalculatorOperation(Calculator.Subtract);

            // 3. Invoke methods through delegates
            addOperation(10, 5);
            subtractOperation(10, 5);

            // Delegates can also be reassigned
            addOperation = new CalculatorOperation(Calculator.Subtract);
            addOperation(20, 10); // Now 'addOperation' calls Subtract
        }
    }
}
