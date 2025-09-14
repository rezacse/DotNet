namespace InterviewCoding.ThreadTest
{
    public class BankAccount
    {
        // Private field: This data is hidden from direct external access.
        private decimal _balance;

        // Public property: Provides controlled access to the private _balance field.
        public decimal Balance
        {
            get
            {
                // The 'get' accessor allows reading the balance.
                return _balance;
            }
            private set // Private set: The balance can only be set from within the class.
            {
                // Optional: Add validation logic here before setting the value.
                if (value >= 0)
                {
                    _balance = value;
                }
                else
                {
                    Console.WriteLine("Balance cannot be negative.");
                }
            }
        }

        // Constructor to initialize the account with an initial balance.
        public BankAccount(decimal initialBalance)
        {
            Balance = initialBalance; // Uses the private set of the Balance property.
        }

        // Public method to deposit funds, providing controlled modification of the balance.
        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                Balance += amount; // Uses the private set of the Balance property.
                Console.WriteLine($"Deposited {amount}. New balance: {Balance}");
            }
            else
            {
                Console.WriteLine("Deposit amount must be positive.");
            }
        }

        // Public method to withdraw funds, providing controlled modification of the balance.
        public void Withdraw(decimal amount)
        {
            if (amount > 0 && Balance >= amount)
            {
                Balance -= amount; // Uses the private set of the Balance property.
                Console.WriteLine($"Withdrew {amount}. New balance: {Balance}");
            }
            else
            {
                Console.WriteLine("Invalid withdrawal amount or insufficient funds.");
            }
        }
    }


    public class EncapsulationHelper
    {
        public EncapsulationHelper()
        {
            BankAccount myAccount = new BankAccount(1000);

            // Accessing the balance through the public property's get accessor.
            Console.WriteLine($"Initial Balance: {myAccount.Balance}");

            // Modifying the balance through public methods (Deposit, Withdraw).
            myAccount.Deposit(500);
            myAccount.Withdraw(200);
            myAccount.Withdraw(2000); // This will be prevented due to validation.

            Console.WriteLine($"Final Balance: {myAccount.Balance}");
        }
    }
}
