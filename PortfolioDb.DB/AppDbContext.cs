using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace PortfolioDb.DB
{
    public class AppDbContext : DbContext
    {
        
            public DbSet<Resume> Resumes { get; set; }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlServer(
                    @"Server=(localdb)\mssqllocaldb;Database=Portfolio;Integrated Security=True");
            }
    }
}

