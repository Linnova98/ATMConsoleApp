namespace ATMConsoleApp;

public class Display
{
    public static void runShit()
    {
        List<CardHolder> CardHolders = new List<CardHolder>();
        CardHolders.Add(new CardHolder("4532772818527395", 1234, "John", "Griffith", 150.31));
        CardHolders.Add(new CardHolder("4532761841325802", 4321, "ASHLEY", "JONES", 321.13));
        CardHolders.Add(new CardHolder("5128381368581872", 9999, "Frida", "Dickerson", 105.59));
        CardHolders.Add(new CardHolder("6011188364697109", 2468, "MUNEEB", "HARDING", 851.84));
        CardHolders.Add(new CardHolder("3490692153147110", 4826, "DAWN", "SMITH", 54.27));
        
        Console.WriteLine("Welcome to SimpleATM");
        Console.WriteLine("Please insert your debit card: ");
        string debitCardNum = "";
        CardHolder currentUser = null;


        while (currentUser == null)
        {
            debitCardNum = Console.ReadLine();


            for (int i = 0; i < CardHolders.Count; i++)
            {
                if (CardHolders[i].CardNum == debitCardNum)
                {
                    currentUser = CardHolders[i];
                    break;
                }

            }

            if (currentUser == null)
            {
                Console.WriteLine("Card not recognized. Please try again");
            }

        }
    
    Console.WriteLine("Please enter your pin: ");
    int userPin = 0;
    bool pinIsWrong = true;
    while (pinIsWrong)
       {
        userPin = Convert.ToInt32(Console.ReadLine());
        if (currentUser.Pin == userPin)
        {
            Console.WriteLine($"Welcome {currentUser.FirstName} :)");
            pinIsWrong = false;
        }
        else
        {
            Console.WriteLine("Pin not recognized. Please try again");
        }
       }

            PrintOptions();
            int option = 0;
    }

    public static void RunOtherShit()
    {
        while (true)
        {
            PrintOptions();
            Console.WriteLine("noe her");
            int idk = Convert.ToInt32(Console.ReadLine());

            switch (idk)
            {
                case 1 :
                    Console.WriteLine(); 
                    break;
                case 2:
                    Console.WriteLine();
                    break;
                default: 
                    break;
            }

        }
    }
    public static void PrintOptions()
    {
        Console.WriteLine("Please choose from one of the following options...");
        Console.WriteLine("1. Deposit");
        Console.WriteLine("2. Withdraw");
        Console.WriteLine("3. Show Balance");
        Console.WriteLine("4. Exit");
    }


}