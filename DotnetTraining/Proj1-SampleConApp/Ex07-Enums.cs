using System;

namespace Proj1_SampleConApp
{
    enum AccountType 
    {
        SBAccount = 1, RDAccount, FDAccount
    };

    class Ex07_Enums
    {
        static void Main(string[] args)
        {
            //basicsExample();
            Console.WriteLine("Please select the type of account from the list below");
            var arrayOfValues = Enum.GetValues(typeof(AccountType));
            foreach(var value in arrayOfValues)
                Console.WriteLine(value);
            string input = Console.ReadLine();
            var convertedValue = Enum.Parse(typeof(AccountType), input);
            AccountType acc = (AccountType)convertedValue;
            Console.WriteLine("The selected Account is " + acc);
        }

        private static void basicsExample()
        {
            AccountType acc = AccountType.SBAccount;
            Console.WriteLine("The Account type is " + acc);
            Console.WriteLine("The internal value of the acc is " + (int)acc);
            Console.WriteLine("Enter the Account type as 1, 2 or 3");
            acc = (AccountType)int.Parse(Console.ReadLine());
            Console.WriteLine("The selected account is " + acc);
        }
    }
}
