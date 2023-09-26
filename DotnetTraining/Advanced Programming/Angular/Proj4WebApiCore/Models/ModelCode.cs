using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Proj4WebApiCore.Models
{
    [Table("ExampleTable")]
    public class Example
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string FileLocation { get; set; } = string.Empty;
    }
    
    public class ExampleDbContext : DbContext
    {
        public ExampleDbContext(DbContextOptions<ExampleDbContext> options) : base(options)
        {
            
        }

        public DbSet<Example> Examples { get; set; }

    }

}
