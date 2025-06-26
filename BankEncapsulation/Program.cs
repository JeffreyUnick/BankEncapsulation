namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            //EASY WAY TO COMPLETE THE EXERCISE :
            BankAccount MyBankAcc = new BankAccount();

            MyBankAcc.Deposit(10000.00);
            var balance =MyBankAcc.GetBalance();
            Console.WriteLine($"Balance is : {balance}");
            
            //NOW LET'S TAKE THE CHALLENGE OF CREATING AN ATM MACHINE WITH IT'S OWN INTERFACE !!!
            MyBankAcc.AtmInterface();
        }
    }
}
