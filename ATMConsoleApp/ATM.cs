namespace ATMConsoleApp;

public class ATM
{
    public List<CardHolder> CardHolders { get; set; }

    public ATM()
    {
        //List<CardHolder> CardHoldersCardHolders = CardHolders;
    }


    public static void Deposit(CardHolder currentUser)
    {
        Console.WriteLine("How much $$ would you like to Deposit?");
        double amount = Convert.ToDouble(Console.ReadLine());
        currentUser.Balance += amount;
        Console.WriteLine($"Thank you for your $$. Your new Balance is: {currentUser.Balance}.");
    }



    void Withdraw(CardHolder currentUser)
    {
        Console.WriteLine("How much $$ would you like to Withdraw?");
        double amount = Convert.ToDouble(Console.ReadLine());
        if (currentUser.Balance < amount)
        {
            Console.WriteLine("Insufficent Balance");
        }
        else
        {
            currentUser.Balance -= amount;
            Console.WriteLine($"You withdrew {amount}");
            Console.WriteLine($"{amount}");
        }

        /* Console.WriteLine("How much $$ would you like to Withdraw?");
         double withdrawal = Double.Parse(Console.ReadLine());
         //Check if the user has enough money
         if (currentUser.GetBalance() < withdrawal)
         {
             Console.WriteLine("Insufficent Balance :(");
         }
         else
         {
             currentUser.setBalance(currentUser.GetBalance() - withdrawal);
             Console.WriteLine("You're good to go! Thank you :)");
         }*/
    }

    void Balance(CardHolder currentUser)
    {
        Console.WriteLine($"Current Balance: {currentUser.Balance}.");
    }
}