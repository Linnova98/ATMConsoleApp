using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;
using ATMConsoleApp;

public class Program 
{
    public static void Main(String[] args)
    {
        //var disp = new Display();

        Display.runShit();
        Display.CheckShit();

        //Console.WriteLine(disp);

        /*
 
         //Prompt user
         Console.WriteLine("Welcome to SimpleATM");
         Console.WriteLine("Please insert your debit card: ");
         string debitCardNum = "";
         CardHolder currentUser = null;
 
 
         while (currentUser == null)
         {
             debitCardNum = Console.ReadLine();
 
 
             for (int i = 0; i < CustomerDatabase.CardHolders.Count; i++)
             {
                 if (CustomerDatabase.CardHolders[i].CardNum == debitCardNum)
                 {
                     currentUser = CustomerDatabase.CardHolders[i];
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
             if (currentUser.Pin == userPin){
                 Console.WriteLine($"Welcome {currentUser.FirstName} :)");
                 pinIsWrong = false;
             }
             else
             {
                 Console.WriteLine("Pin not recognized. Please try again");
             }
         }
 
         Display.PrintOptions();
         int option = 0;
         
 
     }
 
 
 */


        /*public static void StartATM()
        {
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
        }*/
    }
}