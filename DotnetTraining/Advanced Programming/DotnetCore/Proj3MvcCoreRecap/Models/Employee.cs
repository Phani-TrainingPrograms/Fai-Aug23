using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Proj3MvcCoreRecap.Models
{
    [Table("EmpTable")]
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Name is mandatory")]
        public string? Name { get; set; }
   
        [Required(ErrorMessage = "Address is mandatory")]
        public string Address { get; set; } = string.Empty;

        [Required(ErrorMessage = "Salary is must")]
        [Range(10000, 50000, ErrorMessage ="Salary should be b/w 10000 to 50000")]
        public int Salary { get; set; }
        public int DeptId { get; set; }
    }

    [Table("DeptTable")]
    public class Dept
    {
        [Key]
        public int Id { get; set; }
        public string DeptName { get; set; } = string.Empty;
    }

    //create an overloaded constructor that takes DbContextOptions<T> as arg...
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
            
        }

        public DbSet<Employee> EmpTables { get; set; }
        public DbSet<Dept> DeptTables { get; set; }

    }
}
/**
 * Create the models required for the Table structure
 * Create the DBContext class with overloaded constructor
 * Use the services object to inject the ConnectionString to the DBContext. 
 * In the PMC, call the add-migration command with a name to it. 
 * Call the update-database command to update the changes to the database. 
 */