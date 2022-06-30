namespace ATMConsoleApp;

public class ATM
{
    public List<CardHolder> CardHolders { get; set; }

    public ATM()
    {
        //List<CardHolder> CardHoldersCardHolders = CardHolders;
    }



    /*void PrintOptions()
    {
        Console.WriteLine("Please choose from one of the following options...");
        Console.WriteLine("1. Deposit");
        Console.WriteLine("2. Withdraw");
        Console.WriteLine("3. Show Balance");
        Console.WriteLine("4. Exit");
    }*/

    void Deposit(int amount)
    {
        //Balance += amount;

        /*
        Console.WriteLine("How much $$ would you like to Deposit?");
        double deposit = Double.Parse(Console.ReadLine());
        currentUser.setBalance(deposit);
        Console.WriteLine("Thank you for your $$. Your new Balance is: " + currentUser.GetBalance());


        //gammel.
        Console.WriteLine("How much $$ would you like to Deposit?");
        double deposit = Double.Parse(Console.ReadLine());
        currentUser.setBalance(currentUser.GetBalance() + deposit);
        Console.WriteLine("Thank you for your $$. Your new Balance is: " + currentUser.GetBalance());
        */
    }

    /*void Withdraw(CardHolder currentUser)
    {
        Console.WriteLine("How much $$ would you like to Withdraw?");
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
        }
    }*/

    /*void Balance(CardHolder currentUser)
    {
        Console.WriteLine("Current Balance: " + currentUser.GetBalance());
    }*/
}