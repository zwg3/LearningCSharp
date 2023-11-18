public enum AccountType { Checking, Depopsit };

class Enum
{
    static void Main()
    {
        AccountType goldAccount;
        AccountType platinumAccount;
        goldAccount = AccountType.Checking;
        platinumAccount = AccountType.Depopsit;
        Console.WriteLine("The customer account type is {0}", goldAccount);
        Console.WriteLine("The customer account type is {0}", platinumAccount);
    }
}