using Microsoft.EntityFrameworkCore;


namespace Databaza.DB
{
     public class AppDbContext : DbContext
    {       
            public DbSet<Admin> Admins { get; set; }

            public DbSet<Aboutme> Aboutmes { get; set; }

            public DbSet<Project> Projects { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlServer(
                    @"Server=(localdb)\mssqllocaldb;Database=Portfolio;Integrated Security=True");
            }
        }
}
