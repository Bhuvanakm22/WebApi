using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    //class name with primary constructor  
    public class DataContext(DbContextOptions options) : DbContext(options)
    {
        //Table Users
        public DbSet<AppUser> Users { get; set; }
    }
}
