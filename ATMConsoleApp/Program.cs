using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;
using ATMConsoleApp;

public class Program 
{
    public static void Main(String[] args)
    {
        CustomerDatabase.MakeHolders();
        StartATM();


        switch ()
        {
            case: "1"
        }


    }





    public static void StartATM()
    {
        //Prompt user
        Console.WriteLine("Welcome to SimpleATM");
        Console.WriteLine("Please insert your debit card: ");
        String debitCardNum = "";
        CardHolder currentUser;

        while (true)
        {
            try
            {
                debitCardNum = Console.ReadLine();
                // Check against our db
                currentUser = cardHolders.FirstOrDefault(a => a.CardNum == debitCardNum);
                if (currentUser != null)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Card not recognized. Please try again");
                }

            }
            catch
            {
                Console.WriteLine("Card not recognized. Please try again");
            }

        }









        Console.WriteLine("Please enter your pin: ");
        int userPin = 0;
        while (true)
        {
            try
            {
                userPin = int.Parse(Console.ReadLine());
                // Check against our db
                
                if (currentUser.GetPin() == userPin)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Incorrect pin. Please try again");
                }

            }
            catch
            {
                Console.WriteLine("Incorrect pin. Please try again");
            }
        }

        Console.WriteLine("Welcome " + currentUser.GetFirstName() + " :)");
        int option = 0;
        do
        {
            printOptions();
            try
            {
                option = int.Parse(Console.ReadLine());
            }
            catch { }
            if(option == 1)
            {
                deposit(currentUser);

            }
            else if(option == 2){ withdraw(currentUser); }
            else if (option == 3) { balance(currentUser); }
            else if (option == 4)
            {
                break;
            }
            else
            {
                option = 0;

            }


        } while (option != 4);

        Console.WriteLine("Thank you! Have a nice day :)");
    }
}