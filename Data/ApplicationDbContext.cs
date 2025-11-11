using Microsoft.EntityFrameworkCore;
using Razor_Pages.Models;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace Razor_Pages.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData
                (
                    new Category { Id = 1, Name = "Tables", DisplayOrder = 1 },
                    new Category { Id = 2, Name = "Sofas", DisplayOrder = 2 },
                    new Category { Id = 3, Name = "Accessories", DisplayOrder = 3 }
                );
        }
    }
}
