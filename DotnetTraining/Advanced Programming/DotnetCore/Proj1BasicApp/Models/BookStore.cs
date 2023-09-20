using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Proj1BasicApp.Models
{
    //BookId, Title, Author, Price,

    [Table("tblBook")]
    class Book
    {
        [Key]
        public int BookId { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Author { get; set; } = string.Empty;
        public int Price { get; set; }
    }
    class BookContext : DbContext
    {
        public DbSet<Book> Books { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            var connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=FaiTraining;Integrated Security=True; TrustServerCertificate=True";
            optionsBuilder.UseSqlServer(connectionString);
        }
    }

    interface IBookManager
    {
        void AddNewBook(Book book);
        void DeleteBook(int id);
        void UpdateBook(int id, Book book);
        List<Book> GetAllBooks();
        Book GetBook(int id);
        List<Book> GetAllBooks(string title);
    }

    class BookManager : IBookManager
    {
        private BookContext context;

        public BookManager()
        {
            context = new BookContext();
        }
        public void AddNewBook(Book book)
        {
            context.Books.Add(book);
            context.SaveChanges();
        }

        public void DeleteBook(int id)
        {
            var book = context.Books.Find(id);
            if(book == null)
            {
                throw new Exception("Book not found to update");
            }
            context.Books.Remove(book);
            context.SaveChanges();
        }

        public List<Book> GetAllBooks()
        {
            return context.Books.ToList();
        }

        public List<Book> GetAllBooks(string title)
        {
            return context.Books.Where((b)=>b.Title.Contains(title)).ToList();
        }

        public Book GetBook(int id)
        {
            return context.Books.Find(id) ?? throw new Exception("Book not found");
        }

        public void UpdateBook(int id, Book book)
        {
            var found = context.Books.Find(id);
            if (found != null)
            {
                found.Title = book.Title;
                found.Price = book.Price;
                found.Author = book.Author;
                return;
            }
            else
                throw new Exception("Book not found to update");
        }
    }
}