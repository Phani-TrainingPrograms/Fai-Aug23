using System;

namespace Proj1_SampleConApp
{
    enum PaymentMode { Cash, Cheque, Card, UPI }
    class FatherBusiness
    {
        public virtual void MakePayment(int amount, PaymentMode mode)
        {
            if(mode == PaymentMode.Card || mode == PaymentMode.UPI)
            {
                Console.WriteLine("Unknown mode of Payment done as {0}, Not accepted", mode);
                return;
            }
            Console.WriteLine("Payment of Rs. {0} is accepted in the form of {1}", amount, mode);
        }

        public virtual void DisplayBusiness()
        {
            Console.WriteLine("The Business is owned by Mr. Ram Kumar from Bangalore");
        }
    }

    class ChildBusiness : FatherBusiness
    {
        public override void MakePayment(int amount, PaymentMode mode)
        {
            if (mode == PaymentMode.Cash || mode == PaymentMode.Cheque)
            {
                Console.WriteLine("Unknown mode of Payment done as {0}, Not accepted", mode);
                return;
            }
            Console.WriteLine("Payment of Rs. {0} is accepted in the form of {1}", amount, mode);
        }
        //Use the new keyword to remove the warning of Method Hiding, Behavior will not change. 
        public override void DisplayBusiness()
        {
            Console.WriteLine("The Business is owned by Mr. PHANI RAJ from Bangalore");
        }
    }

    class BusinessFactory
    {
        public static FatherBusiness CreateBusiness(string type)
        {
            if (type == "Father")
                return new FatherBusiness();
            else if (type == "Child")
                return new ChildBusiness();
            else
                return null;
        }
    }
    class Ex3_MethodOverriding
    {
        static void Main(string[] args)
        {
            string businessType = Utilities.GetString("Enter the Type of Business to run: Father or Child");
            var business = BusinessFactory.CreateBusiness(businessType);
            business.MakePayment(4000, PaymentMode.Cash);
            business.MakePayment(4000, PaymentMode.UPI);
            business.DisplayBusiness();

            //business = new ChildBusiness();
            //business.MakePayment(4000, PaymentMode.Cash);
            //business.MakePayment(4000, PaymentMode.UPI);
            //business.DisplayBusiness();//Calls the base class version...

            //ChildBusiness business1 = new ChildBusiness();//Runtime polymorphism does not work for hidden methods(Methods that are not virtual). 
            //business1.DisplayBusiness();
        }
    }
}
