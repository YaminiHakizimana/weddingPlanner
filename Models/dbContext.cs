using Microsoft.EntityFrameworkCore;
 
namespace WeddingPlanner.Models
{
    public class UserContext : DbContext
    {
        // base() calls the parent class' constructor passing the "options" parameter along
        public UserContext(DbContextOptions options) : base(options) { }

         public DbSet<User> users {get;set;}
         public DbSet<Wedding> wedding {get;set;}
         public DbSet<Reservation> reservation {get;set;}
    }
}