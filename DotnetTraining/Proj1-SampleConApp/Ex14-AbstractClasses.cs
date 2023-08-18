using System;

namespace Proj1_SampleConApp
{
    class Constants
    {
        public const string DEBITERROR = "Insufficient Funds!!!";
    }
    abstract class Account
    {
        public Account()
        {
            Balance = 5000;
        }
        public int AccountNo { get; set; }
        public string HolderName { get; set; }
        public int Balance { get; private set; }
        public void Credit(int amount) => Balance += amount;

        public void Debit(int amount)
        {
            if(amount > Balance)
            {
                throw new Exception(Constants.DEBITERROR);
            }
            Balance -= amount;
        }

        public abstract void CalculateInterest();
    }

    class SBAccount : Account
    {
        //Any class that is derived from the abstract class must override the abstract methods. 
        public override void CalculateInterest()
        {
            double principal = Balance;
            double rate = 6.5/100;
            double time = 0.25;

            double interest = principal * rate * time;
            Credit((int)interest);

        }
    }
    //class RDAccount : Account { }
    //class FDAccount : Account { }
    class AbstractClasses
    {
        static void Main(string[] args)
        {
            Account acc = new SBAccount();
            acc.HolderName = "Phaniraj";
            acc.AccountNo = 1111;
            acc.Credit(50000);
            acc.Debit(30);
            acc.CalculateInterest();
            Console.WriteLine("The current balance is " + acc.Balance);

        }
    }
}
