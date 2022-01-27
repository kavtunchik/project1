using System.Data.Entity;

namespace Collection.Data.Models
{
    public class UserContext : DbContext { 

        public UserContext() : base("DefaultConnection") { }
    
        public DbSet<User> Users { get; set; }
    
    }
    
}
