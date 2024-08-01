using System;
using Microsoft.EntityFrameworkCore;
using MyMinimalApi.Models;

namespace MyMinimalApi.Data
{

    public class AppDbContext : DbContext
    {
          public DbSet<Category> Categories { get; set; }

          public DbSet<Item> Items { get; set; }

          public DbSet<Comments> Comments { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>().HasData(
            new Category { Id = 1, Name = "מוצרי ניקיון" },
            new Category { Id = 2, Name = "גבינות" },
            new Category { Id = 3, Name = "ירקות ופירות" },
            new Category { Id = 4, Name = "בשר ודגים" },
            new Category { Id = 5, Name = "מאפים" },
            new Category { Id = 6, Name = "אחר" }
        );
    }
    }
}
