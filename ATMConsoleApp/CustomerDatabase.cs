namespace ATMConsoleApp;

public class CustomerDatabase
{
    public static void MakeHolders()
    {
        List<CardHolder> cardHolders = new List<CardHolder>();

        cardHolders.Add(new CardHolder("4532772818527395", 1234, "John", "Griffith", 150.31));
        cardHolders.Add(new CardHolder("4532761841325802", 4321, "ASHLEY", "JONES", 321.13));
        cardHolders.Add(new CardHolder("5128381368581872", 9999, "Frida", "Dickerson", 105.59));
        cardHolders.Add(new CardHolder("6011188364697109", 2468, "MUNEEB", "HARDING", 851.84));
        cardHolders.Add(new CardHolder("3490692153147110", 4826, "DAWN", "SMITH", 54.27));
    }
    
}