namespace InterviewCoding.ThreadTest
{
    public class ExceptionHandler
    {
        public ExceptionHandler()
        {
            try
            {
                try
                {
                    int number = 3;
                    int result = 10 / number; // May throw DivideByZeroException

                    Console.WriteLine($"Result: {result}");

                    throw new Exception("From 1st try");
                }
                catch (FormatException ex)
                {
                    Console.WriteLine($"Catch: FormatException ({ex.Message})");
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine($"Catch: DivideByZeroException ({ex.Message})");
                    throw ex;
                }
                catch (Exception ex) // Generic catch for any other exceptions
                {
                    Console.WriteLine($"Catch: Generc Catch {ex.Message}");
                    //throw ex;
                }
                finally
                {
                    Console.WriteLine("Finally: 1st finally block completed.");
                    //throw;
                    //throw new Exception("From 1st Finally");
                }

            }
            catch (Exception ex)
            {

                Console.WriteLine($"Catch: 2nd try catch. {ex.Message}");
            }
            finally
            {

                Console.WriteLine($"Finally: 2nd finally block completed");
            }


            Console.ReadKey();
        }
    }
}
