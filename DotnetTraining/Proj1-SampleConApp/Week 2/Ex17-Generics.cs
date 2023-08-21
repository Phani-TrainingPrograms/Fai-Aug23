using System;
using System.Collections.Generic;


namespace Proj1_SampleConApp.Week_2
{
    class Employee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public string EmpAddress { get; set; }
        public int EmpSalary { get; set; }

        public override int GetHashCode()
        {
            return EmpId;
        }

        public override bool Equals(object obj)
        {
            var temp = obj as Employee;
            if (this.EmpId == temp.EmpId)
                return true;
            else
                return false;
        }
    }

    class Ex17_Generics
    {
        static void Main(string[] args)
        {
            //listExample();
            //hashSetExample();
            //hashSetWithEmployees();
            //DictionaryExample();
            //queueExample();
            //stackExample();
        }

        private static void stackExample()
        {
            Stack<string> stack = new Stack<string>();
            stack.Push("Fruits");
            stack.Push("Vegetables");
            stack.Push("Grocery");
            stack.Push("Electronic");
            stack.Push("Software");
            foreach(var item in stack)
                Console.WriteLine(item);
            Console.WriteLine("The total count: " + stack.Count);
            stack.Pop();//Removes the lastly added item from the collection.
            foreach (var item in stack)
                Console.WriteLine(item);
        }

        private static void queueExample()
        {
            Queue<string> recentList = new Queue<string>();
            do
            {
                string detail = Utilities.GetString("Enter the Product Name to view details");
                recentList.Enqueue(detail);
                if(recentList.Count > 5) 
                {
                    recentList.Dequeue();//Removes the 1st item in the queue...
                }
                Console.WriteLine("The recent list of items U viewed......");
                var tempList = recentList.ToArray();
                var list = new List<string>(tempList);
                list.Reverse();
                foreach(var item in list)
                    Console.WriteLine(item);
            } while (true);
        }

        private static void DictionaryExample()
        {
            Dictionary<string, string> users = new Dictionary<string, string>();
            //Add the key-value pair:
            users.Add("phaniraj", "apple@123");//if a key already exists, it will throw an exception else, its simply adds the pair to the bottom of the Collection. 
            users["Suresh"] = "test@123";//If the key already exists, it replaces the value, else it adds a new key and a value to the collection. 
            if (!users.ContainsKey("Ramesh"))
            {
                users["Ramesh"] = "ram@321";
            }

            foreach(var pair in users)
            {
                Console.WriteLine($"The Key: {pair.Key}\tThe value: {pair.Value}");
            }
            var uname = Utilities.GetString("Enter the username");
            var pwd = Utilities.GetString("Enter the password");
            if (!users.ContainsKey(uname))
            {
                Console.WriteLine("User name is not registered with us!!");
            }
            else
            {
                if(users[uname] != pwd)
                {
                    Console.WriteLine("Password is wrong");
                }
            }
        }
        //todo: Create 2 functions signIn and signUp and implement dictionary for an user to login and register. 

        private static void hashSetWithEmployees()
        {
            HashSet<Employee> empCollection = new HashSet<Employee>();
            empCollection.Add(new Employee { EmpId = 111, EmpName = "Phaniraj", EmpAddress = "Bangalore", EmpSalary = 45000 });
            empCollection.Add(new Employee { EmpId = 111, EmpName = "Phaniraj", EmpAddress = "Bangalore", EmpSalary = 45000 });
            empCollection.Add(new Employee { EmpId = 111, EmpName = "Phaniraj", EmpAddress = "Bangalore", EmpSalary = 45000 });
            empCollection.Add(new Employee { EmpId = 111, EmpName = "Phaniraj", EmpAddress = "Bangalore", EmpSalary = 45000 });
           foreach(var emp in empCollection)
            {
                Console.WriteLine(emp.EmpName);
            }

        }

        private static void hashSetExample()
        {
            HashSet<string> basket = new HashSet<string>();
            basket.Add("Apples");
            basket.Add("Mangoes");
            basket.Add("Oranges");
            if (!basket.Add("Oranges"))
            {
                Console.WriteLine("Basket already has oranges");
            }
            basket.Add("Apples");

            foreach(var item in basket)
                Console.WriteLine(item);
            //Rest of the other functions are same as List. 
        }

        private static void listExample()
        {
            List<string> fruits = new List<string>();//It creates a blank array with size 0.
            fruits.Add("Apples");
            fruits.Add("Mangoes");
            fruits.Add("Bananas");
            fruits.Add("Oranges");//Adds the item to the bottom of the list.  

            foreach (string item in fruits)
                Console.WriteLine(item.ToUpper()) ;//Unboxing is not required as U have already specified the type of data U want to store in this collection. 

            //todo: Create an List of Employees and try to add multiple employees and read the Names of the Employees/ 
        }
    }
}
