using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Proj4WebApiCore.Models
{
    [Table("Employee")]
    public class Employee
    {
        [Key]
        public int EmpId { get; set; }
        public string EmpName { get; set; }= string.Empty;
        public string EmailAddress { get; set; } = string.Empty;
        public long PhoneNo { get; set; }
        public string ImageFile { get; set; } = string.Empty;
    }

    public class EmpDbContext : DbContext
    {
        public EmpDbContext(DbContextOptions<EmpDbContext> options) : base(options) { }

        public DbSet<Employee> Employees { get; set; }
    }
}

/*
 * Run the following commands:
 * add-migration -context Proj4WebApiCore.Models.EmpDbContext
 * update-database -context Proj4WebApiCore.Models.EmpDbContext
 * Create an interface for all the CRUD operations for the Employee Table and a class that implements this interface. The functions should be return Task objects. 
 * Using DI, use the interface object in the controller of the API..
 */