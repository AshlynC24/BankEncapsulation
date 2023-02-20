namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            //now allow the user to make a deposit in the bank account
            //then they need to retrieve the balance 

 
            var account = new BankAccount();
            Console.WriteLine("Hello, how much would you like to deposit?");
            var amountToDeposit = double.Parse(Console.ReadLine());

            account.Deposit(amountToDeposit);//this takes the amount and stores it into the balance field

            Console.WriteLine($"Thank you, your balance is now: ${account.GetBalance()}");
            // now we write their new balance to the console 

        }
    }
}
