namespace ATMConsoleApp;

public class ATM
{
    public List<CardHolder> CardHolders { get; set; }

    public ATM(List<CardHolder> cardHolders)
    {
       CardHolders = cardHolders;
    }



    void printOptions()
    {
        Console.WriteLine("Please choose from one of the following options...");
        Console.WriteLine("1. Deposit");
        Console.WriteLine("2. Withdraw");
        Console.WriteLine("3. Show Balance");
        Console.WriteLine("4. Exit");
    }
    void deposit(CardHolder currentUser)
    {
        Console.WriteLine("How much $$ would you like to deposit?");
        double deposit = Double.Parse(Console.ReadLine());
        currentUser.setBalance(deposit);
        Console.WriteLine("Thank you for your $$. Your new balance is: " + currentUser.GetBalance());


        //gammel.
        Console.WriteLine("How much $$ would you like to deposit?");
        double deposit = Double.Parse(Console.ReadLine());
        currentUser.setBalance(currentUser.GetBalance() + deposit);
        Console.WriteLine("Thank you for your $$. Your new balance is: " + currentUser.GetBalance());
    }

    void withdraw(CardHolder currentUser)
    {
        Console.WriteLine("How much $$ would you like to withdraw?");
        double withdrawal = Double.Parse(Console.ReadLine());
        //Check if the user has enough money
        if (currentUser.GetBalance() < withdrawal)
        {
            Console.WriteLine("Insufficent balance :(");
        }
        else
        {
            currentUser.setBalance(currentUser.GetBalance() - withdrawal);
            Console.WriteLine("You're good to go! Thank you :)");
        }
    }

    void balance(CardHolder currentUser)
    {
        Console.WriteLine("Current balance: " + currentUser.GetBalance());
    }
}