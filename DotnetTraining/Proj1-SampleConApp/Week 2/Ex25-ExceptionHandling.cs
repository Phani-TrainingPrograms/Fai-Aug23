using System;
using System.Collections.Generic;
using System.IO;
//FileNotFoundException, DivideByZeroException.
namespace Proj1_SampleConApp.Week_2
{

    class UserAlreadyRegisteredException : Exception
    {
        public UserAlreadyRegisteredException() : base("User is already registered")
        {

        }
        public UserAlreadyRegisteredException(string message) : base(message) { }
    }


    public class EmployeeNotFoundException : Exception
    {
        public EmployeeNotFoundException() { }
        public EmployeeNotFoundException(string message) : base(message) { }

    }
    //todo: Modify the EmpBinaryDatabase implementation to throw EmployeeNotFoundException for the functions of Update, Delete and the indexer. handle the Exception appropriately at the front end App. 

    //todo: create a program that handles dividebyzero exception. 
    class Ex25_ExceptionHandling
    {
        static Dictionary<string, string> users = new Dictionary<string, string>();

        static void SignIn(string username, string password)
        {

        }

        static void SignUp(string username, string password)
        {
            try
            {
                users.Add(username, password);
            }
            catch (ArgumentException)
            {
                throw new UserAlreadyRegisteredException($"User by name {username} already exists");
            }
        }
        static void trycatchExample()
        {
            Console.WriteLine("Enter a number to add");

        RETRY:
            try
            {
                int no = int.Parse(Console.ReadLine());
                Console.WriteLine("The value inserted is: " + no);
            }
            catch (FormatException)
            {
                Console.WriteLine("Input should be a whole number");
                goto RETRY;
            }
            catch (OverflowException)
            {
                Console.WriteLine($"Value of the number should be from {int.MinValue} and {int.MaxValue}");
                goto RETRY;
            }
            finally
            {
                Console.WriteLine("End of the Program");
            }
        }
        private static void fileHandlingExample()
        {
            try
            {
                var fileName = "Phaniraj.txt";
                //if (File.Exists(fileName))
                //{
                    var content = File.ReadAllText(fileName);
                    Console.WriteLine(content);
                //}else
                Console.WriteLine("File does not exist");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File does not exist");
            }
        }
        static void Main(string[] args)
        {
            //fileHandlingExample();
            do
            {
                string uname = Utilities.GetString("Enter the Registration name");
                string pwd = Utilities.GetString("Enter the Password");
                try
                {
                    SignUp(uname, pwd);
                }
                catch (UserAlreadyRegisteredException ex)
                {
                    Console.WriteLine(ex.Message);
                    //goto RETRY;
                }
            } while (true);
            //trycatchExample();
        }

    }
}
