using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Proj3MvcCoreApp.Models
{
    [Table("ExpenseTable")]
    public class Expense
    {
        [Key]
        public int ExpenseId { get; set; }

        public string Detail { get; set; } = string.Empty;
        public DateTime ExpenseDate { get; set; }
        public int Amount { get; set; }
    }

    public class ExpenseDbContext : DbContext
    {
        public ExpenseDbContext(DbContextOptions<ExpenseDbContext> options) :base(options)
        {
            
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            //optionsBuilder.UseSqlServer("Data Source=.\\SQLEXPRESS;Initial Catalog=FaiTraining;Integrated Security=True; TrustServerCertificate=True");
        }
        public DbSet<Expense> Expenses { get; set; }
    }
}
