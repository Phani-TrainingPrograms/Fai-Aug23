using System;

namespace Proj1_SampleConApp
{
    struct Dimension
    {
        public int height;
        public int width;
        //
        public Dimension(int height, int width)
        {
            this.height = height;
            this.width = width;
        }
    }

    struct Employee
    {
        private int empId ; //For private data use camelcasing. 
        private string empName ;
        private string empAddress ;
        private double empSalary;
        
        //constructors in Structs:

        //Property
        public int EmpId
        {
            get { return empId; }
            set { empId = value; }
        }

        public string EmpName
        {
            get { return empName; }
            set { empName = value; }
        }

        public string EmpAddress { get => empAddress; set => empAddress = value; }
        public double EmpSalary { get => empSalary; set => empSalary = value; }
    }                       
    class Ex08_Structs
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.EmpId = 123;
            emp.EmpName = "Phani Raj";
            Console.WriteLine("The name is " + emp.EmpName);

            //Creating structs without new operator. 
            Dimension dm = new Dimension(300, 300);
            Console.WriteLine("The Area is " + (dm.height * dm.width));

            dm.height = 200;
            dm.width = 400;

            Console.WriteLine("The Area is " + (dm.height * dm.width));
        }
    }
}
