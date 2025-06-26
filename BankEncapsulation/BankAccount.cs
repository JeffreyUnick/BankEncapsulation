namespace BankEncapsulation;

public class BankAccount
{
    private double _balance = 0;
    public double Deposit(double amount)
    {
        return _balance += amount;
    }

    public double GetBalance()
    {
        return _balance;
    }
    // LET'S CREATE A METHOD FOR THE INTERFACE OF OUR ATM

    public void AtmInterface()
    {
        Console.WriteLine("Hellooooo !!! Welcome to NOT_SO_SECURED_BANK\nWe are glad to have you " +
                          "as one of our faithful customers\nWhat do you need help with today ?\n" +
                          "1-Acc Balance            2-Acc Deposit\n" +
                          "3-Acc Withdraw           4-Exit");
        double input;
        var allowedNumbers = new double[] { 1, 2, 3, 4 };
        do
        {
            Console.WriteLine("Type the number of the transaction you need !!");
            input = UserInputCheck();
            if (input == 1 || input == 2 || input == 3)
            {
                switch (input)
                {
                    case 1:
                        Console.WriteLine($"Your balance is : {_balance}");
                        break;

                    case 2:
                        Console.WriteLine("What's the amount you're trying to deposit?");
                        double amount = UserInputCheck();
                        Deposit(amount);
                        Console.WriteLine($"Your new balance is now : {_balance}");
                        break;

                    case 3:
                        Console.WriteLine("what's the amount you're trying to withdraw ?");
                        double amount2 = UserInputCheck();
                        Withdraw(amount2);
                        break;

                }
            }
            else if (input == 4)
            {
                Console.WriteLine("Thank you for using NOT_SO_SECURED_BANK, ATM !!! BYE");
            }
            else Console.WriteLine("That's not a valid input");
        }
        while (!allowedNumbers.Contains(input));
    }
    
   // THOSE ARE THE CUSTOM METHODS I CREATED FOR MY ATM INTERFACE
   
    public double UserInputCheck()
    {
        double input;
        bool isValid;
        do 
        { 
            var userinput = Console.ReadLine();
            isValid = double.TryParse(userinput, out input);
            if (!isValid)
            {
                Console.WriteLine("That's not a valid input");
            }
            
        }
        while (!isValid);
        return input;
    }

    public void Withdraw(double amount)
    {
        _balance -= amount;
        if (_balance < 0)
        {
            Console.WriteLine(" Insufficient fund !!! Your balance is too low");
        } else Console.WriteLine($"Your new balance is : {_balance}");
        
    }
}