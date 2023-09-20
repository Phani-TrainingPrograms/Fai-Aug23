using Proj1BasicApp.Data;
using Proj1BasicApp.Models;

namespace Proj1BasicApp
{
    class Employee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; } = string.Empty;
        public int EmpSalary { get; set; }
        public string EmpEmailAddress { get; set; } = string.Empty;
        public long EmpPhone { get; set; }

        public override string ToString()
        {
            return $"{EmpName} with Email {EmpEmailAddress}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //firstExample();
            //var component = new BookManager();
            //component.AddNewBook(new Book { Author = "Charles Dickens", Price = 440, Title = "Oliver Twist" });
            //var books = component.GetAllBooks();
            //foreach (var book in books)
            //{
            //    Console.WriteLine($"{book.BookId} with title {book.Title} written by {book.Author}");
            //}

            var context = new FaiTrainingContext();
            var empRecords = context.Emptables.ToList();
            foreach (var emp in empRecords)
            {
                Console.WriteLine(emp.EmpName);
            }

        }

        private static void firstExample()
        {
            Console.WriteLine("Hello, World!");
            var emp = new Employee { EmpEmailAddress = "phanirajbn@gmail.com", EmpId = 1, EmpName = "Phaniraj", EmpPhone = 9945205684, EmpSalary = 56000 };
            Console.WriteLine(emp);

            Book book = new Book();
            book.Author = "Phaniraj";
            book.Title = "Angular Training";
            book.Price = 100;

            var context = new BookContext();//object that links the App and database
            context.Books.Add(book);//Adds the book to the Books collection
            context.SaveChanges();//updates the collection to the database. 

            var books = context.Books.ToList();
            foreach (var bk in books)
            {
                Console.WriteLine(bk.Title);
            }
        }
    }
}