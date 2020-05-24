using ECommerce.Auth.Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.Auth.DataAccess.Concrete.EntityFramework.Context
{
    public class ECommerceAuthApiProjectDbContext : DbContext
    {
        public ECommerceAuthApiProjectDbContext()
        {
        }

        public ECommerceAuthApiProjectDbContext(DbContextOptions<ECommerceAuthApiProjectDbContext> options)
            : base(options)
        {
        }

        public DbSet<Role> Role { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<UserRole> UserRole { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=MicroservicesDb;Trusted_Connection=true");
        }
    }
}