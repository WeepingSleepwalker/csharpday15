using Microsoft.EntityFrameworkCore;
namespace Chefs.Models
{ 

        public class MyContext : DbContext 
    { 
        public MyContext(DbContextOptions options) : base(options) { 

        }


        public DbSet<Chef> Chefs { get; set; }
        public DbSet<Recipie> Recipies { get; set; }
    }
}