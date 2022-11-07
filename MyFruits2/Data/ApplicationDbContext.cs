using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyFruits2.Models;

namespace MyFruits2.Data
{
    //public class ApplicationDbContext : IdentityDbContext
    public class ApplicationDbContext : DbContext

    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<MyFruits2.Models.Fruit> Fruits { get; set; }
        public DbSet<MyFruits2.Models.Image> Images { get; set; }

    }
}